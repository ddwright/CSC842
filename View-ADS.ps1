
#Define GUI form for the display of the hex data

function View-Hex( $Path, $HexDump ) {
    [reflection.assembly]::loadwithpartialname("System.Windows.Forms") | Out-Null
    [reflection.assembly]::loadwithpartialname("System.Drawing") | Out-Null

    $ViewForm = New-Object System.Windows.Forms.Form
    $HexBox = New-Object System.Windows.Forms.RichTextBox
    $DrawSize = New-Object System.Drawing.Size
    $DrawPoint = New-Object System.Drawing.Point

    $LoadHexBox = {
        $HexBox.AppendText($HexDump)
        $HexBox.Select(0,0)
    }

#Define main form

    $ViewForm.ClientSize = $DrawSize
    $DrawPoint.X = 347
    $DrawPoint.Y = 182
    $ViewForm.Location = $DrawPoint
    $DrawSize.Height = 574
    $DrawSize.Width = 574
    $ViewForm.MinimumSize = $DrawSize
    $ViewForm.Name = "ViewForm"
    $ViewForm.Text = $Path
    $ViewForm.add_Load($LoadHexBox)

# Define Box to display hex data

    $HexBox.Anchor = 15
    $DrawPoint.X = 8
    $DrawPoint.Y = 8
    $HexBox.Location = $DrawPoint
    $HexBox.Name = "HexBox"
    $DrawSize.Height = 508
    $DrawSize.Width = 538
    $HexBox.Size = $DrawSize
    $HexBox.TabIndex = 2
    $HexBox.Text = ""
    $HexBox.font = "Lucida Console"
    $ViewForm.Controls.Add($HexBox)

#Show form

    $ViewForm.ShowDialog()| Out-Null

} 


<#
    http://windowsitpro.com/powershell/get-hex-dumps-files-powershell
#>
function Get-Hex( $Path ) {

    $Path

    [Char] $UnprintableChar = "."
    [UInt32] $BufferSize = 65536


# The file will be output in 16-byte lines.
    $bytesPerLine  = 16


# Keep track of our position within the file.
    [UInt32] $fileOffset = 0

    $HexDump = ""

    try {
        $stream = [System.IO.File]::OpenRead($Path)
        while ( $stream.Position -lt $stream.Length ) {
# Read $BufferSize bytes into $buffer, returning $bytesRead.
            $buffer = new-object Byte[] $BufferSize
            $bytesRead = $stream.Read($buffer, 0, $BufferSize)
# Step through buffer $bytesPerLine bytes at a time.
            for ( $line = 0; $line -lt [Math]::Floor($bytesRead / $bytesPerLine); $line++ ) {
# Grab 16-byte buffer slice, and created formatted string.
                $slice = $buffer[($line * $bytesPerLine)..(($line * $bytesPerLine) + $bytesPerLine - 1)]
                $hexOutput = "{0:X8}  {01:X2} {02:X2} {03:X2} {04:X2} {05:X2} {06:X2} {07:X2} {08:X2} {09:X2} {10:X2} {11:X2} {12:X2} {13:X2} {14:X2} {15:X2} {16:X2} " -f (, $fileOffset + $slice)
                $charOutput = ""
# Create ASCII printable character output.
                foreach ( $byte in $slice ) {
                    if ( ($byte -ge 32) -and ($byte -le 126) ) {
                        $charOutput += [Char] $byte
                    }
                    else {
                        $charOutput += $UnprintableChar
                    }
                }
                $HexDump += "{0} {1}" -f $hexOutput, $charOutput + "`r`n"

                $fileOffset += $bytesPerLine
            }
# Process bytes from end of file when file size not multiple of $bytesPerLine.
            if ( $bytesRead % $bytesPerLine -ne 0 ) {
                $slice = $buffer[($line * $bytesPerLine)..($bytesRead - 1)]
                $hexOutput = "{0:X8}  " -f $fileOffset
                $charOutput = ""
                foreach ( $byte in $slice ) {
                    $hexOutput += "{0:X2} " -f $byte
                    if ( ($byte -ge 32) -and ($byte -le 126) ) {
                        $charOutput += [Char] $byte
                    }
                    else {
                        $charOutput += $UnprintableChar
                    }
                }
# PadRight needed to align the output.
                $HexDump += "{0} {1}" -f $hexOutput.PadRight(58), $charOutput
            }
            write-progress -activity "Loading File" `
                -status ("Dumping file '{0}'" -f $item.FullName) `
                -percentcomplete (($fileOffset / $stream.Length) * 100)
        }
    }
    catch [System.Management.Automation.MethodInvocationException] {
        throw $_
    }
    finally {
        $stream.Close()
    }
#    $HexDump
     View-Hex $Path $HexDump
}


Clear-Host

[System.Reflection.Assembly]::LoadWithPartialName("System.windows.forms") | Out-Null

# Select Directory    
$DirDialog = New-Object Windows.Forms.FolderBrowserDialog

if( ( $DirDialog.ShowDialog() ) -ne "OK" ){
    Return
}

# Where to put extracted streams to stage for view
$StreamDir = "C:\streams\"

#$DirDialog = "C:\*, *"

# Get ADS list
try {
#$ads = gci -path "C:\*, *" -recurse -Attributes !Directory+!System -ErrorAction SilentlyContinue -Force | % { gi $_.FullName -Force -stream *  } | where stream -ne ':$Data
    $ads = gci -path $DirDialog.SelectedPath -recurse -Attributes !Directory+!System -ErrorAction SilentlyContinue -Force | % { gi $_.FullName -Force -stream *  } | where stream -ne ':$Data' 
}
finally {	
}

# Loop until form is cancelled
do {
    $Result = $ads | Select-Object -Property FileName, Stream, Length, PSPath | out-gridview -Title "Alternate Data Streams" -OutputMode single 

    if( $Result -ne $null ) {

        if ( !(Test-Path $StreamDir -pathType container) ){
            mkdir $StreamDir
        }
        $PullStream = $StreamDir + ( Split-Path -Path $Result[0].FileName -Leaf -Resolve )  + "." + $Result[0].Stream

        Get-Content -Path $Result[0].PSPath -Stream $Result[0].Stream | Out-File $PullStream  
        Get-Hex $PullStream
    }

}
until( $Result -eq $null ) 
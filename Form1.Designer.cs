using System;
using System.DirectoryServices;
using System.Windows.Forms;

namespace minfo
{
    partial class minfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Win32PropertiesDataGrid = new System.Windows.Forms.DataGridView();
            this.Win32Properties = new System.Windows.Forms.Label();
            this.SelectWin32 = new System.Windows.Forms.Label();
            this.Win32API = new System.Windows.Forms.ComboBox();
            this.ComputerComboBox = new System.Windows.Forms.ComboBox();
            this.Computer = new System.Windows.Forms.Label();
            this.GoButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Win32PropertiesDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // Win32PropertiesDataGrid
            // 
            this.Win32PropertiesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Win32PropertiesDataGrid.Location = new System.Drawing.Point(12, 142);
            this.Win32PropertiesDataGrid.Name = "Win32PropertiesDataGrid";
            this.Win32PropertiesDataGrid.Size = new System.Drawing.Size(732, 819);
            this.Win32PropertiesDataGrid.TabIndex = 1;
            // 
            // Win32Properties
            // 
            this.Win32Properties.AutoSize = true;
            this.Win32Properties.Location = new System.Drawing.Point(16, 116);
            this.Win32Properties.Name = "Win32Properties";
            this.Win32Properties.Size = new System.Drawing.Size(54, 13);
            this.Win32Properties.TabIndex = 3;
            this.Win32Properties.Text = "Properties";
            // 
            // SelectWin32
            // 
            this.SelectWin32.AutoSize = true;
            this.SelectWin32.Location = new System.Drawing.Point(16, 36);
            this.SelectWin32.Name = "SelectWin32";
            this.SelectWin32.Size = new System.Drawing.Size(91, 13);
            this.SelectWin32.TabIndex = 4;
            this.SelectWin32.Text = "Select Win32 API";
            // 
            // Win32API
            // 
            this.Win32API.AutoCompleteCustomSource.AddRange(new string[] {
            "Win32_ComputerSystem",
            "Win32_DiskDrive",
            "Win32_OperatingSystem",
            "Win32_Processor",
            "Win32_ProgramGroup",
            "Win32_StartupCommand",
            "Win32_SystemDevices"});
            this.Win32API.FormattingEnabled = true;
            this.Win32API.Items.AddRange(new object[] {
            "Win32_ComputerSystem",
            "Win32_DiskDrive",
            "Win32_NetworkAdapterConfiguration",
            "Win32_OperatingSystem",
            "Win32_PhysicalMedia",
            "Win32_PhysicalMemory",
            "Win32_Processor",
            "Win32_ProgramGroup",
            "Win32_SecurityDescriptor",
            "Win32_StartupCommand",
            "Win32_SystemDevices",
            "Win32_Binary"});
            this.Win32API.Location = new System.Drawing.Point(19, 72);
            this.Win32API.Name = "Win32API";
            this.Win32API.Size = new System.Drawing.Size(222, 21);
            this.Win32API.TabIndex = 5;
            this.Win32API.SelectedIndexChanged += new System.EventHandler(this.Win32API_SelectedIndexChanged);
            // 
            // ComputerComboBox
            // 
            this.ComputerComboBox.FormattingEnabled = true;
            this.ComputerComboBox.Location = new System.Drawing.Point(323, 72);
            this.ComputerComboBox.Name = "ComputerComboBox";
            this.ComputerComboBox.Size = new System.Drawing.Size(222, 21);
            this.ComputerComboBox.TabIndex = 6;
            this.ComputerComboBox.SelectedIndexChanged += new System.EventHandler(this.ComputerComboBox_SelectedIndexChanged);
            // 
            // Computer
            // 
            this.Computer.AutoSize = true;
            this.Computer.Location = new System.Drawing.Point(320, 36);
            this.Computer.Name = "Computer";
            this.Computer.Size = new System.Drawing.Size(85, 13);
            this.Computer.TabIndex = 7;
            this.Computer.Text = "Select Computer";
            // 
            // GoButton
            // 
            this.GoButton.Location = new System.Drawing.Point(600, 72);
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(75, 23);
            this.GoButton.TabIndex = 8;
            this.GoButton.Text = "Go";
            this.GoButton.UseVisualStyleBackColor = true;
            this.GoButton.Click += new System.EventHandler(this.GoButton_Click);
            // 
            // minfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 973);
            this.Controls.Add(this.GoButton);
            this.Controls.Add(this.Computer);
            this.Controls.Add(this.ComputerComboBox);
            this.Controls.Add(this.Win32API);
            this.Controls.Add(this.SelectWin32);
            this.Controls.Add(this.Win32Properties);
            this.Controls.Add(this.Win32PropertiesDataGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "minfo";
            this.Text = "minfo";
            this.Load += new System.EventHandler(this.minfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Win32PropertiesDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView Win32PropertiesDataGrid;
        private System.Windows.Forms.Label Win32Properties;
        private System.Windows.Forms.Label SelectWin32;
        private System.Windows.Forms.ComboBox Win32API;
        private System.Windows.Forms.ComboBox ComputerComboBox;
        private System.Windows.Forms.Label Computer;
        private Button GoButton;
    }
}


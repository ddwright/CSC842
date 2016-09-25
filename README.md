# CSC842
Security Tool Development

<h1>minfo</h1>

<h1>Overview</h1>
<hr />
<p>Win32 Class in windows monitor and manage system hardware and features. This tool uses them to get all kinds of system information.  This can be useful when you are looking for vulnerabilities. There are six broad categories of Win32 classes. They are Computer System Hardware, Installed Application, Operation System, Performance Counter, Security Descriptor Helper   You can find more information about them from the link in the references section. The ones that will give us some info are those that say "represents" in their description.</p>
<p>It provides a drop down with some common Win32 classes to explore but you can type your own into the combo box form.  The ones that
<p>It was written in Visual Studio using C#</p>

<h1>Dependencies</h1>
<hr />
<ul>
<li>Was written for Windows</li>
<li>This program requires the .NET runtime in order to execute.</li>
</ul>

<h1>To Execute</h1>
<hr />
<p>Simply run the .exe file. Select the Win32 Class you are interested in and hit Go.  If you want you can select another computer on the network to view. Note : I did not have the environment available to check another computer.</p>

<h1>References</h1>
<hr />
<p>An overview of Win32 classes can be found at https://msdn.microsoft.com/en-us/library/aa394084(v=vs.85).aspx</p>

<h1>Future Work</h1>
<hr />
<ul>
<li>Expand the data retrieved using different intelligence sources.</li>
<li>Add the ability to notify the user when someone tries to connect to a port.</li>
<li>Add the ability to block a specified IP from connecting to a port.</li>
</ul>

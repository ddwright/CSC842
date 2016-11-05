# CSC842

#Security Tool Development
<h1>Log Checker</h1>
<h1>Overview</h1>
<hr />
<p>
This projects reads a security file and cross references that with a log file to make a user with access to a timekeeping system is not performing transactions on themselves.
Sometimes we get requests from labor relations to look into possible fraud.  Sometimes timekeepers have been found giving themselves extra benefit time or not reporting benefit time they used.
These programs pull the individuals security record, we are interested in userid and SSN.  Userid of the individual doing the transaction is in the log and time entries done are keyed by SSN.
</p>
<p>
After my REXX project last week I got some questions regarding the mainframe, considering it old technology.  Mainframes keep pace with new technology and are quite good at moving large amounts of data around. 
I thought I would demonstrate the benefits of that platform.  Plus I need this for work ;)  It reads almost over 980,000 records, roughly up to 7k per record depending on the type of transaction.
</p>
<p>
These programs are written in Easytrieve Plus, a 4GL, mainly used for report generation but great for other puposes as well.
</p>
<p>Youtube Link : </p>
<h1>Dependencies</h1>
<hr />
<ul>
<li>IBM Mainframe or compatable platform.</li>
<li>TSO.</li>
<li>Easytrieve Plus</li>
</ul>
<h1>To Execute</h1>
<hr />
<p>These programs are designed to be submitted batch only.
One of the imputs is the SSN you wish to look for.
</p>

<h1>Output</h1>
<hr />
<ul>
<li>Output to job listing.</li>
<li>Formatted reports listing the questionable access</li>
<p>
Note the CPU time to read all of the records and process them is only .00019 hours.
</p>
<h1>References</h1>
<hr />
<p>http://www.ca.com/us/products/ca-easytrieve-report-generator.html</p>
<h1>Future Work</h1>
<hr />
<ul><li>Highlight or seperate out vacation, holiday, etc time entered.</li></ul>

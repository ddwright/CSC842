# CSC842
#Security Tool Development<h1>Process Tracker</h1><h1>Overview</h1><hr /><p>This tool monitors processes on an IBM mainframe.  I have a need to monitor several mainframe developers and this tool will be helpful in seeing who is logged on, for how long and what tasks they are executing.Others have written similar tools for other platforms in this class.</p><p>Youtube Link : https://www.youtube.com/watch?v=qGvXRcv0OdI</p><h1>Dependencies</h1><hr /><ul><li>IBM Mainframe or compatable platform.</li><li>TSO.</li><li>Rexx</li></ul><h1>To Execute</h1><hr /><p>This tool can be executed online or in a batch mode.</p>Command line options :<ul><li>User ID or User ID Mask</li><li>Number of seconds to monitor.</li><li>Type of job to monitor, blank for all.</li></ul><h1>Output</h1><hr /><ul><li>Output to console.</li><li>Output to job listing.</li><li>More detailed information is sent to .CSV file.</li>Data elements available and written to .CSV are<ul><li>JNAME   </li><li>TOKEN   </li><li>STEPN   </li><li>PROCS   </li><li>JOBID   </li><li>OWNERID </li><li>JCLASS  </li><li>POS     </li><li>DP      </li><li>REAL    </li><li>PAGING  </li><li>EXCPRT  </li><li>CPUPR   </li><li>ASID    </li><li>ASIDX   </li><li>EXCP    </li><li>CPU     </li><li>SWAPR   </li><li>STATUS  </li><li>SYSNAME </li><li>SPAGING </li><li>SCPU    </li><li>WORKLOAD</li><li>SRVCLASS</li><li>PERIOD  </li><li>RESGROUP</li><li>SERVER  </li><li>QUIESCE </li><li>ECPU    </li><li>ECPUPR  </li><li>CPUCRIT </li><li>STORCRIT</li><li>RPTCLASS</li><li>MEMLIMIT</li><li>TRANACT </li><li>TRANRES </li><li>SPIN    </li><li>SECLABEL</li><li>GCPTIME </li><li>ZAAPTIME</li><li>ZAAPCPTM</li><li>GCPUSE  </li><li>ZAAPUSE </li><li>SZAAP   </li><li>SZIIP   </li><li>PROMOTED</li><li>JTYPE   </li><li>ZAAPNTIM</li><li>ZIIPTIME</li><li>ZIIPCPTM</li><li>ZIIPNTIM</li><li>ZIIPUSE </li><li>SLCPU   </li><li>IOPRIOGRP</li><li>JOBCORR </li></ul><h1>References</h1><hr /><p>https://en.wikipedia.org/wiki/Rexx</p><h1>Future Work</h1><hr /><ul><li>Generate reports from data file.</li></ul>

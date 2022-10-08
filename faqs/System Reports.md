# System Reports
Updated 2022-03-16 01.08.38  
Version 7  

System reports detail the hardware and software configuration of your machine - these reports allow our technical support department to review your machine for hardware and software conflicts to recommend solutions to crashes and other issues.  
  
[h5]Select your Operating System:[/h5]  
  
[expand type=title title="Windows"]  
[h5]Important[/h5]Before creating and submitting an MSINFO32 report, ensure that your copy of Windows is fully updated. See [Microsoft's update FAQ](https://support.microsoft.com/en-us/windows/windows-update-faq-8a903416-6f45-0718-f5c7-375e92dddeb2) for more information on how to update Windows.  
  
### Generating a MSINFO32 Report
Please observe the following instructions to run and save an MSINFO32 report if requested by Steam Support:  
* Please press **Windows Key + R** to open the **Run** Menu
* Type *msinfo32* and click **OK**
* While viewing the **System Summary** node go to **File** then **Save** (Please do not use **Export**)
* Save your MSINFO32 report as **msinfo32.nfo** on your desktop for easy access (you may delete the file once you have sent it to Steam Support)
  
  
### Large File Sizes for MSINFO32 Reports
If there is a lot of information stored in the error logs of the MSINFO32 report, this can cause the reports to be very large in size (10+ mb). If your MSINFO32 file is particularly large, please follow these instructions to clear the error log:  
* Please hit 'Windows Key + R' to open the **Run** Menu
* Type *compmgmt.msc* and hit *Enter*
  
The ‘Computer Management’ window will now prompt you.  
  
Directly underneath the 'Computer Management' icon, you should see the category called 'System Tools'.  
* Click the *>* box, next to 'System Tools' to expand the folder tree
* Select the *Event Viewer* category and expand *Windows Logs*
* Highlight *Application*
* Right click and select *Clear all Events* or *Clear Log...*  
  
![https://support.steampowered.com/images/faq/EventViewerClearLogs.png](https://support.steampowered.com/images/faq/EventViewerClearLogs.png)
* When asked to Save Application Data, click *Clear* to clear the error log and save a new instance of the report.
* Attach the file to your Steam Support help request.
  
[h5]Note:[/h5]If possible, please submit your file directly, rather than using a hosting website.[/expand]  
[expand type=title title="macOS"]   
[h5]Important[/h5]Before creating and submitting an System Profiler, please ensure that your macOS installation is fully updated. See [Apple's Mac update page](https://support.apple.com/en-us/HT201541) for more information.  
### Generating a System Report
Please observe the following instructions to run and save an System report if requested by Steam Support  
* Open the Apple menu and click *"About This Mac."*  
  
![https://support.steampowered.com/images/faq/4840-QWJX-0408/1-apple_menu.png](https://support.steampowered.com/images/faq/4840-QWJX-0408/1-apple_menu.png)
* Click the *"More Info..."* button at the bottom of the *"About This Mac"* dialog.  
  
![https://support.steampowered.com/images/faq/4840-QWJX-0408/2-about_this_mac.png](https://support.steampowered.com/images/faq/4840-QWJX-0408/2-about_this_mac.png)
* Click the *"System Report..."* button at the bottom of the new, detailed *"About This Mac"* dialog. The System Information application should appear.  
  
![https://support.steampowered.com/images/faq/4840-QWJX-0408/3-system_profiler_basic.png](https://support.steampowered.com/images/faq/4840-QWJX-0408/3-system_profiler_basic.png)
* In the Menu Bar, click *"File" > "Save..."*  
  
![https://support.steampowered.com/images/faq/4840-QWJX-0408/4-system_profiler_save_menu.png](https://support.steampowered.com/images/faq/4840-QWJX-0408/4-system_profiler_save_menu.png)
* The save dialog should appear. In the *"Save As:"* field, name the file *SystemProfiler* and select *"Desktop"* as where it will be saved.  
  
![https://support.steampowered.com/images/faq/4840-QWJX-0408/5-system_profiler_save_dialog.png](https://support.steampowered.com/images/faq/4840-QWJX-0408/5-system_profiler_save_dialog.png)
* Attach the file to your Steam Support help request.
 [/expand]   
[expand type=title title="Linux"]  
There are several ways to generate this report on Linux but the easiest one is to install System Profiler and Benchmark through the Ubuntu Software Center.  
In order to do this please do the following:  
* Click on the Ubuntu Software Center
* In the Search field type "System Profiler"
* Select "System Profiler and Benchmark"
* Click on Install
* Enter your password to install the program
* Once downloaded click on the "System Profiler and Benchmark" icon on the left menu bar to start the program
* To create the report click on "Generate Report" at the top
* Uncheck Benchmarks and click on Generate
* Select the location you'd like to save the HTML file and save it
* Attach this HTML file to your Steam Support help request and we will be able to further assist you
  This process can be done using the Terminal command lshw however when exporting the report in an HTML file the formatting is not as clean as using the above instructions. For the quickest and best support please use the above process.[/expand]
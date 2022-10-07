# My computer crashes or stops at a blue or gray screen and I am forced to restart or it restarts itself
Updated 2021-12-02 21.12.48  
Version 6  

Your computer restarts without warning or you see any of the following errors:  

* Windows: "A problem has been detected and Windows has been shut down to prevent damage to your computer." or ":( Your PC ran into a problem and needs to restart."
* macOS: "You need to restart your computer. Hold down the Power button for several seconds or press the Restart button."

  
  
These errors indicate a problem with your computer, **not** Steam, the game, or the application.  
  
Provided below are fixes to some common issues, but if you are unable to understand the instructions or resolve the issue on your own, you must contact the manufacturer of your computer or allow your local computer professional to diagnose the issue.  
  
#### Drivers and Firmware
*Main article:* [*Updating Drivers*](https://help.steampowered.com/en/faqs/view/5799-495F-1F25-D15B)  
  
If your drivers are not updated to the latest version, you may be encountering a bug that has since been fixed in the new version of the drivers. Please update ALL of your drivers to the latest version.  
  
If you are using macOS, please ensure that you have installed all of the available system updates. See Apple Support for more information.  
  
  
#### Overheating
Overheating is especially likely if you encounter performance issues (games or applications slowing down or stuttering) before the error occurs.  
  
Please note that some laptops or compact desktops may not have sufficient cooling to run high-usage applications (such as games) for a sustained period, especially in a warm environment.  
  
Please ensure that the computer has adequate ventilation:  
  

* Laptops should be placed on a hard surface. The air used to cool them is often pulled from under the laptop, so soft surfaces (like couches, beds, blankets, or pillows) can easily cause overheating.
* Desktops should be placed with adequate (4+ inches/10+ cm) space around all sides, front, back, and the top to allow air flow.
* Some users have opened their case and used a regular desk fan to improve ventilation, however you will need to be careful to prevent foreign objects from entering the computer.

  
  
If your computer is more than a few months old, or if you have pets or an otherwise dusty environment, please check your computer for dust and hair. If you are not comfortable opening your computer to check and/or clean the heat sinks and fans, please bring it to your local computer professional for cleaning. When cleaning, use only compressed air without touching interior surfaces (do not vacuum or brush as this can destroy your computer).  
  
#### Data Errors (Hard Drive or RAM)
Some of the tests involved may require advanced technical knowledge. If you cannot understand the instructions, please contact your computer manufacturer or allow your local computer professional to troubleshoot the issue.  
  
The first step is to verify that your hard drive is in good health and that all bad sectors have been marked as such by the drive. Instructions may vary depending on the version of Windows or macOS you are running.  
  
[h5]Windows:[/h5]
* Locate the hard drive Steam is installed on in your file explorer. By default, this is *C:*
* Right-click this drive and select **Properties**.
* Click the **Tools** tab.
* In the **Error-checking** category, click **Check**
* In the dialog that appears, check "Automatically fix file system errors" and "Scan for and attempt recovery of bad sectors."
* Click Start.
* If you are scanning the *C:* drive, you will be asked to schedule the disk check the next time you start Windows. Accept, restart your computer, and allow the disk check to start—do not press any keys to skip the disk check.
* Allow the disk check to complete. This process may take up to several hours, depending on the size of your hard drive and the number of errors.

  
If errors are detected, you should also verify that your Windows system files are not corrupted. Please see the Microsoft Support article [Use the System File Checker tool to repair missing or corrupted system files](https://support.microsoft.com/en-us/kb/929833) and follow the instructions to verify your system files.  
  
[h5]macOS:[/h5]Follow the instructions provided in the Apple Support article [Using Disk Utility to verify or repair disks](https://support.apple.com/en-us/HT201639).  
  
If no errors are found or the issue continues, please ensure your system's memory (RAM) is functioning properly  
  
[h5]Windows and macOS:[/h5]Another possible cause for this issue is bad system memory. You can use memory testing software to help determine potential issues with your memory. Errors with your memory may indicate faulty RAM. In those cases you would need to isolate and replace the faulty module.  
  
#### Non-standard modifications (Overclocking)
Adjusting the configuration of your computer for more performance outside the manufacturer's specifications, including activities such as overclocking or core unlocking, can introduce instability. If you have made any such modifications, please set all configurations to their defaults and test the issue again.
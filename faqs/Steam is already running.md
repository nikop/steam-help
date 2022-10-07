# Steam is already running
Updated 2021-08-05 19.57.40  
Version 8  

When I attempt to launch Steam or a game, I get an error message saying that Steam is already running.  How can I resolve the problem?  
  
This error message indicates that Steam is not loading properly. The process is running in the background and is visible in Task Manager's Processes tab, but is not launching the user interface.  
  
#### Compatibility Mode
Please ensure that Steam is not set to use Compatibility features:  

* Browse to your Steam installation (Usually C:\Program Files (x86)\Steam\)
* Right click on steam.exe, choose Properties.
* Click on the Compatibility tab.
* Uncheck any boxes that are checked, and click Apply.
* Then, click the "Change settings for all users" button.
* Again, make sure none of these boxes are checked, and click Ok.
* Click Ok to close any open dialog boxes.

  
  
#### Reinstall Steam
If Compatibility features were not enabled, or if disabling them fails to resolve the issue, your Steam installation may be corrupted. Please follow the instructions below to reinstall Steam files without affecting your installed games:  
  

* Exit Steam and go to the folder called C:\Program Files (x86)\Steam\ (this is the default location for a Steam installation - if you set a different installation directory, you will need to browse to it).
* Delete all of the files in this folder except: The steamapps folder and steam.exe (If 'exe' is not visible, look for the blue and white Steam icon)
* Restart your computer.
* Then, you will need to launch steam.exe from within the Steam installation folder, and not from a pre-existing shortcut.

  
  
#### Interfering Applications and Malware
To test if there are interfering applications, please review the information provided in [Programs Which May Interfere with Steam](https://help.steampowered.com/en/faqs/view/1F39-DCB4-FF28-5748).  
  
In some cases, malware may be to blame for this issue. Please ensure your computer is free from any possibly malicious software.
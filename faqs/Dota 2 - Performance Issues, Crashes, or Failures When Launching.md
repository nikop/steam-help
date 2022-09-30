# Dota 2 - Performance Issues, Crashes, or Failures When Launching
Updated 2021-08-12 17.21.26

If you are encountering performance issues, game crashes, or Dota 2 is failing to launch with or without an error message, proceed through this article from top to bottom and complete all applicable steps to troubleshoot the issue.  
  
### Crashes or failures to launch with specific error messges
  
Check to see if there is an article related to the error message that you are seeing in the [Specific Error Messages category.](https://support.steampowered.com/kb_cat.php?id=59)  
  
If there is no article related to the message that you are seeing, continue through this article to troubleshoot the issue.  
  
  
### Troubleshooting performance issues and crashes
  
Please read and complete all applicable troubleshooting steps in the [Common Dota 2 Technical Issues and Solutions](http://dev.dota2.com/showthread.php?t=15261) guide provided by the Dota 2 developers.  
  
Refer to our articles regarding Hardware and Software based performance issues. Complete all steps exactly as they are presented.  

* [Troubleshooting Game Performance Issues - Hardware ](https://help.steampowered.com/en/faqs/view/7289-6080-C6E3-AE81)
* [Troubleshooting Game Performance Issues - Software](https://help.steampowered.com/en/faqs/view/5B03-A517-D747-9421)

  
  
### Updating your drivers
  
If you are encountering any issues with your Steam games, [ensure that your drivers are completely up to date](https://help.steampowered.com/en/faqs/view/5799-495F-1F25-D15B).  
  
### Blue Screen issues in Windows
  
If you encounter a Blue Screen error with Dota 2 or your computer is restarting when launching or playing Dota 2, make sure that your BIOS and Chipset Drivers are fully up to date (see your motherboard manufacturer's instruction manual or website for specific instructions and updates).  
  
### Verifying your game files
  
If you think some files of your game installation may be corrupt or have been deleted as a false positive by antivirus or security software, try [Verify Integrity of Game Files](https://help.steampowered.com/en/faqs/view/0C48-FCBD-DA71-93EB).  
  
### Launching with -autoconfig or -safe mode 
  
If Dota 2 is failing to start after preparing to launch, we recommend that you attempt to launch with either the -autoconfig or -safe launch option in that order.  
  
  ### Note:
Only one of these launch options can be used at a time. Once you are able to launch this game, you will need to remove these launch options if you wish to change any video settings.  
  
Using the -autoconfig launch option  

* Open Steam
* Go to the "Library"
* Right-click the game which needs to be reconfigured
* Select "Properties" from the menu
* Go to the "Launch Options" section in the window
* Remove any launch options currently shown.
* Type `-autoconfig`in the box and close the window.
* Launch the game and test the issue again

  
  
Using the -safe launch option  

* Open Steam
* Go to the "Library"
* Right-click the game which needs to be reconfigured
* Select "Properties" from the menu
* Go to the "Launch Options" section in the window
* Remove any launch options currently shown.
* Type `-safe`in the box and close the window.
* Launch the game and test the issue again.

  
  
### Reacquiring all Dota 2 files
  
This should be done if you think some of the game's files may be corrupt, or if you have overwritten any game files with custom assets or mods and you wish to restore the game to its original state. If your game was working previously but is now crashing or freezing and you have completed the above instructions under the [Verifying your game files](#verify) section with no results, try this next.  
  
**For Windows computers:**  

* Exit Steam entirely.
* Browse to your Steam installation (Usually C:\Program Files(x86)\Steam\)
* Rename the "steamapps" folder to "old_steamapps"
* Re-launch Steam and re-install the game.
* Once the installation is complete, test the issue.
* If this resolves the issue, you may copy the new files into the "old_steamapps" folder and rename it to "steamapps" to restore your other games without re-downloading.
* If the issue is not resolved, you can rename the folder back to avoid having to re-install other games.

  
  
**For Linux computers:**  
  
  ### Note:
Steam for Linux is currently only supported on Ubuntu 12.04/12.10 with Unity, Gnome, or KDE desktops.  

* Exit Steam and go to your Home folder.
* Press CTRL+H to reveal any hidden folders.
* Click on .local > share > Steam and do the following:
* Rename the "steamapps" folder to "old_steamapps"
* Re-launch Steam and re-install the game.
* Once the installation is complete, test the issue again.

  
  
**For Mac computers:**  

* Exit Steam entirely.
* Open Finder and navigate to the folder containing your SteamApps folder (/Users/[username]/Library/Application Support/Steam/)
* Rename the "steamapps" folder to "steamapps_old".
* Re-launch Steam and re-install the game.
* Once the installation is complete, test the issue.

  
  
**To locate your Steam installation folder when using Lion or any newer macOS version, do the following:**  

* Open Terminal
* Type chflags nohidden ~/Library
* Close Terminal

  
  
You should see the Library folder available through the Go menu on the menu bar while holding the option key.  
  
### Reporting a bug, crash, or other issue
  
If you are still encountering this issue within Dota 2, please create or join an existing thread regarding that issue on the [Dota 2 Development Forums](http://dev.dota2.com/).  
  
Widespread crashes or other issues will often be fixed by the Dota 2 development team within days of the issue appearing.
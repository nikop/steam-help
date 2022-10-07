# Failed to create D3D Device
Updated 2021-08-09 23.02.40  
Version 5  

D3D errors typically occur if you are running the game at settings which your machine does not adequately support or if you are running outdated video drivers. Other potential causes include outdated Windows installs or larger video card issues.  
  
## Reduce your video resolution
If you have recently increased or changed your game's video resolution, a good first step is to revert your resolution to a setting that previously worked and re-test the issue. If you are able to play at a lower resolution we recommend using that going forward.  
## Use the -autoconfig launch option
If you would like the game to automatically choose appropriate settings for your machine, please use the *-autoconfig*  [launch option](https://help.steampowered.com/en/faqs/view/2542-790F-14F8-D66A#autoconfig).  
## Update your video drivers
Before updating your drivers, please visit the [Windows Update FAQ](http://www.update.microsoft.com/microsoftupdate/v6/default.aspx?ln=en-us) and make sure you have all of the critical updates and the .NET Framework installed.  
  
To update your video drivers, please follow the instructions below for your current operating system:  

* [Windows 10](https://support.microsoft.com/en-us/help/4028443/windows-10-update-drivers)
* [Windows 8](https://support.microsoft.com/en-us/help/15046/windows-8-download-install-drivers)
* [macOS](https://help.steampowered.com/en/faqs/view/6073-E74C-A033-48A4)

    
## None of these solutions worked. What can I do now?
If you have reduced your video resolution, are running the game using settings your machine can adequately support, and have the latest drivers for your video card and are still receiving D3D errors it's possible that your system has gotten into an unusual state. Please restart your machine and re-test the issue.  
  
If the issue persists, please set the following launch option for the affected game: *-dxlevel 81*  
  
[/h5] If you are attempting to play Left 4 Dead, Left 4 Dead 2, Portal 2, or Counter-Strike: Global Offensive, you must set your launch option to *-dxlevel 90* instead.
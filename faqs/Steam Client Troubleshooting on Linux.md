# Steam Client Troubleshooting on Linux
Updated 2021-07-10 19.49.55

What should I do if Steam is crashing, not opening correctly or closing immediately after launching?  
  
[section style=important] ### Important:
Currently, Steam for Linux is only supported on the most recent version of Ubuntu LTS with the Unity, Gnome, or KDE desktops.[/section]  
#### Troubleshooting
  
  
[h5]Check Video Drivers[/h5]You will want to install a 32-bit OpenGL program and make sure it runs properly, as most issues with Steam starting up on Linux are due to problems with the installation OpenGL drivers, or the lack of drivers entirely.  
  
On Ubuntu, the easiest way to verify this is by installing mesa-utils:i386 and running glxinfo from a console.  
  
[h5]Check the Wiki[/h5]The Valve Wiki hosted by Ubuntu has some common solutions and recommendations for installing and troubleshooting the Steam client. [Valve Ubuntu Wiki](https://wiki.ubuntu.com/Valve)  
  
[h5]Still Not Working?[/h5]Crashes or bugs can be reported to our GitHub. Those reports are then used by our developers to help determine what needs to be fixed. [Valve GitHub](https://github.com/ValveSoftware/steam-for-linux/)  
  

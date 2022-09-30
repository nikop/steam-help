# Using Launch Settings for Video and Display Problems
Updated 2021-08-03 23.30.47

I'm having video and display problems in a Valve/Source game, how do I change my video and display settings during launch?  
  
[section style=important][h5]Check Drivers are recently Updated[/h5]  
If you have not recently changed your video settings and you are experiencing video and display problems, please ensure your video drivers and DirectX are updated before proceeding:  
  
[Updating Drivers](https://help.steampowered.com/en/faqs/view/5799-495F-1F25-D15B)  
  
If that does not resolve the issue you can try using the launch options below to try and troubleshoot the issue.  
  
**Note:** The following processes are suggested only for Valve games. These options will have no effect when launching other Steam games.[/section]  
  

* [How do I set the autoconfig launch option?](#autoconfig)
* [How do I set the safe mode launch option?](#safe)
* [How do I force a working DirectX level and video mode?](#force)

  
  
[section id=#autoconfig]# How do I set the autoconfig launch option?
[/section]The *-autoconfig* launch option will allow Steam to configure a Valve/Source game with the best settings for use on your machine.  

* Open Steam
* Go to the "Library"
* Right-click the game which needs to be reconfigured
* Select "Properties..." from the menu
* Go to the section "Launch Options"
* Remove any launch options currently shown in the input box
* Type *-autoconfig* in the box

    
 [section id=#safe]# How do I set the safe mode launch option?
[/section]The *-safe* launch option will cause the game to launch with minimal video settings, in windowed mode and with a 640 x 480 resolution. This can be helpful for solving video configuration problems.  

* Open Steam
* Go to the "Library"
* Right-click the game which needs to be reconfigured
* Select "Properties..." from the menu
* Go to the section "Launch Options"
* Remove any launch options currently shown in the input box
* Type *-safe* in the box.

    
  
 [section id=#force]# How do I force a working DirectX level and video mode?
[/section]If the Valve/Source game fails to load with the default settings, you will need to test for a working DirectX level and video mode.  
  
#### Force a DirectX level
This process may help with some older video cards - some users report the game will run faster, as well:  

* Open Steam
* Go to the "Library"
* Right-click the game which needs to be reconfigured
* Select "Properties..." from the menu
* Go to the section "Launch Options"
* Remove any launch options currently shown in the input box
* Type one of the DirectX level launch options specified below in the box

  **DirectX Level Launch Options**
* *-dxlevel 90* (DirectX v9.0)
* *-dxlevel 81* (DirectX v8.1)
* *-dxlevel 80* (DirectX v8.0)

  
  
#### Force a Video Mode
Follow these instructions to configure your video mode and resolution before launching a game:  
  
[section style=important] ### Important:
If you are forcing a refresh rate on your system (this is not recommended), you will need to ensure that you specify the forced refresh rate in the launch options.[/section] 
* Open Steam
* Go to the "Library"
* Right-click the game which needs to be reconfigured
* Select "Properties..." from the menu
* Go to the section "Launch Options"
* Remove any launch options currently shown in the input box
* Specify the appropriate Video Mode and Video Option switches from the lists below

  
  
**Supported Video Modes**
* *-gl* use the OpenGL engine **GoldSource Only**
* *-16bpp* or *-32bpp* - Forces the selected color mode (bit depth). **GoldSource only**
* *-soft* use the Software engine
* *-width #* (where " *#* " is the width in pixels of desired video mode) sets the video mode width
* *-w #* (see the [Supported Video Resolutions](#videores) list below)
* *-fullscreen* or *-full* use Full Screen mode (default)
* *-startwindowed* / *-sw* / *-windowed* / *-window* / *-win* use the Window display mode (game appears as a window on the desktop)

  
  
[section id=#videores]**Supported Video Resolutions**[/section]Use the *-w #* switch (where " *#* " is a number from the list below) to specify the display resolution:  

* *640* (640x480) **GoldSource Only**
* *720* (720x576)
* *800* (800x600)
* *1024* (1024x768)
* *1152* (1152x864)
* *1280* (1280x1024)
* *1600* (1600x1200)
* *1768*  (1768 x 992)
* *1920* (1920 x 1080)
* *2560* (2560 x 1440)

  
[section style=note]**Notes on Display Resolution Settings**
* Higher resolutions will affect the Frames Per Second which your machine can display.
* 640x480 resolution may run slower than 800x600 resolution on newer video cards.

[/section]
# Optimus and Steam for Linux
Updated 2021-08-10 21.16.23  
Version 4  

## How can I force a Steam for Linux game to use my NVidia card instead of the integrated video card?
  
  
The latest client release includes support for using Primus to run Steam client games. To take advantage of this you will need to install Primus for Bumblebee on your system. For installation instructions, see [https://wiki.ubuntu.com/Bumblebee](https://wiki.ubuntu.com/Bumblebee) or [here](http://www.webupd8.org/2012/11/primus-better-performance-and-less.html).  
  
**Note - Primus must be installed with 32-bit support because Steam for Linux (and most games downloaded from Steam) are 32-bit.**  
  
To verify that Primus is available on your system, run the following command: **primusrun glxspheres**.  
  
There are two methods for using Primus with Steam. The first method involves running Steam on the Intel GPU and only selected graphically intensive games on the discrete GPU.  
  
To make a game run using the discrete GPU, use these simple steps:  

* Select a game - that you want to run using your discrete Nvidia card - from the **Library** page of the Steam client, right-click, and select **Properties...**.
* On the **General** tab go to the section **LAUNCH OPTIONS** and enter the command: **primusrun %command%** for the command line.
* Close the window. This method allows you to pick when the discrete NVidia GPU should be used on a per-game basis.

  
The second method is not as efficient (in terms of power consumption) but quicker by running the Steam client and all games using Primus. From the command line, enter **primusrun steam** instead of **steam**. This is inefficient because all games do not require the power of an NVidia card and power consumption is greatly increased during a Steam client/game session.  
  
For more information about instaling and configuring Primus (and installing Steam on Ubuntu, 64-bit), see this [article](http://cjenkins.wordpress.com/2013/01/01/steam-for-linux-on-optimus-enabled-computer-running-ubuntu-12-04-64bits).
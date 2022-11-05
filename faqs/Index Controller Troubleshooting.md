# Index Controller Troubleshooting
Updated 2021-12-02 21:13:55  
Version 8  

![https://support.steampowered.com/steamvr/FitGuide/GuideHeader.png](https://support.steampowered.com/steamvr/FitGuide/GuideHeader.png) # General troubleshooting
Before reading further, be sure to:  
  
[*]Ensure your device is charged and powered.[/*]  		[*]Ensure your firmware is up to date.[/*]  		[*]Restart SteamVR.[/*] 
---
# Input issues
#### Track Button
Responsiveness and output can be affected if the controller detects input on the Track Button while it is being powered on. If the Track Button does not seem to   		be registering input or feels sluggish, try these steps:  
  
[*]Hold down the System button for 5 seconds to turn the controller off.[/*]  		[*]Wait 2 seconds.[/*]  		[*]Power the controller back on by pressing the System Button. Make sure you do not touch the Track Button.[/*]  
Try this a couple of times. If the problem persists, go to [Help With Valve Index](https://help.steampowered.com/wizard/HelpWithValveIndex) to contact Steam Support regarding the issue.  
  
#### Issue with legacy bindings or app-specific input
Titles without native Index Controller support should automatically map existing control schemes and work without additional customization. If you would like to   		remap these controls or load a custom controller binding from the Steam Workshop, you can do so by going to the SteamVR status window, opening the menu, and selecting*Devices* > *Configure Controller*.  
  
For advanced information about how to use the legacy input system to create custom controller bindings, you can check out[our rebinding guide](https://steamcommunity.com/sharedfiles/filedetails/?id=1545634111).  
  
---
  
  
 # Controller is not solid green in SteamVR status window
If your controller is not ready, first check the LED above the Track Button and follow the steps below:  
  
#### LED is blue
Controller is powered, but not paired to your headset. Pair your controller again:   

* Navigate to the SteamVR status window.
* Open the menu and select *Devices* > *Pair Controller*.
* Hold down both the System and B buttons for a few seconds.
* If this does not pair the controller, try turning the device on and off to power-cycle it.

  
  
#### LED is red (flashing)
The controller is in an error state. If you just updated your controller firmware, go to [Help With Valve Index](https://help.steampowered.com/wizard/HelpWithValveIndex) to contact Steam Support regarding the issue.  
  
If you did not just update your controller firmware, you should be able to recover your controller by following the *Reset your controller* instructions below.  
  
#### LED is off
Controller is not powered. If your controller will not power on, plug it in for a while to ensure that it has a charge and then try again. If the LED remains off, check the device's status in VR Monitor. It should be gray. If it is in another state, you can try resetting your controller using the instructions immediately below.  
  
#### Still having problems? Reset your controller.
If none of this information solved the problem, you can try performing a "hard reset" on your controller. To do this:  
  
[*]Plug the controller in via USB and leave it to charge for 10 minutes.[/*]  		[*]Unplug it and hold down the System Button for 15 seconds, then release.[/*]  		[*]Power the controller on again.[/*]  
The controller should recover. If you continue having problems, go to [Help With Valve Index](https://help.steampowered.com/wizard/HelpWithValveIndex) to contact Steam Support regarding the issue.  
  
---
 # Controller is not tracking
If you're having a tracking issue, please refer to our [Base Station & Lighthouse Tracking](https://help.steampowered.com/en/faqs/view/1AF1-670B-FF5C-3323) article.  
  
---
  
# Other Issues
  
  
#### Wired Controller Usage
  
Please unplug controllers during gameplay. Pulling the charge cable at an angle may cause damage.  
  
![{STEAM_CLAN_IMAGE}/1976/4dee04d8473768abe44989c4901ac18aba13d406.png]({STEAM_CLAN_IMAGE}/1976/4dee04d8473768abe44989c4901ac18aba13d406.png)  
  
If you suspect damage to your controller's USB-C connector, please [contact Steam Support](https://help.steampowered.com/en/wizard/HelpWithGameIssue/?appid=250820&issueid=370&nodeid=44&return_nodeid=48)  
  
Developers and users who prefer wired controller workflows should consider using a "USB-C breakaway cable".  
#### 3rd-party charging cables
We're aware that some USB-C charging cables are not compatible with the molding around the controller's ports. We recommend using the included cables or avoiding cables with bulky plug housings.  
  
#### Fast Charging
To take advantage of fast charging, you can use any USB charging port capable of at least 1 Amp with the included Type-A to Type-C charge cable.  
  
Examples of fast charge ports:  
[*]Cell phone charger  
[*]USB Charge station  
  
Examples of standard charge ports:  
[*]PC USB host ports  
[*]USB hub ports[/*]  
The device does not take advantage of USB PD ports (power delivery).
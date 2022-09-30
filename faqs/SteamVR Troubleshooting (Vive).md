# SteamVR Troubleshooting (Vive)
Updated 2021-08-13 18.55.49

![https://support.steampowered.com/images/faq/steam_vr/vive_install/SteamVR_Support_Header_Main.png](https://support.steampowered.com/images/faq/steam_vr/vive_install/SteamVR_Support_Header_Main.png)  
  
# SteamVR Troubleshooting
  
[table noborder=1]  
 [tr]  
 [td]
* [SteamVR + HTC Vive](#steamvr-ts)
* [General PC Troubleshooting](#gen-pc)
* [Headset](#headset)
* [Controllers](#controllers)
* [Base Stations](#base-stations)

  
[/td]  
 [td]
* [Tracking Issues](#tracking-issues)
* [SteamVR Issues](#steamvr-issues)
* [Audio Issues](#audio-issues)
* [Wireless Receivers](#wireless-receivers)
* [Still Need Help?](#last-resort)

    
[/td]  
 [/tr]  
[/table]  
  
  
## SteamVR + HTC Vive Troubleshooting
  
Welcome to the troubleshooting guide for the HTC Vive + SteamVR. Troubleshooting for the first generation development kit can be found [here](https://developer.valvesoftware.com/wiki/SteamVR/TroubleshootingFirstGen).  
  
If you have a Vive Pre Developer kit, the troubleshooting instructions below will also apply to you. The only difference is the Vive Pre uses white LEDs instead of green LEDs to signify that a device is ready to be used.  
  
For a guided troubleshooting experience, please visit the [SteamVR help site](https://help.steampowered.com/en/wizard/HelpWithGame/?appid=250820).    
  
  
## General PC Troubleshooting
  
Please ensure that you have optimized your PC Settings for SteamVR by completing the following steps:  
  

* Set your PC's power plan to "High performance" (Press the Windows key > Type: power > Select "Power Options" > Select "High performance")
* Set NVIDIA power management to "prefer maximum performance" as outlined [here](http://nvidia.custhelp.com/app/answers/detail/a_id/3130/~/setting-power-management-mode-from-adaptive-to-maximum-performance).
* Get the latest drivers from [NVIDIA](http://www.nvidia.com/Download/index.aspx) or [AMD](http://support.amd.com/en-us/download).
* Set your default audio playback device to HTC-VIVE-0.
* Make sure you are running Steam as an administrator.

    
  
[expand type=title title="Static Electricity"]  
In some environments, the audio extension cable of the Vive headset can build up static electricity and deliver a small static shock when touched or when used with certain earbuds. This does not necessarily indicate an issue with your Vive - it happens for the same reason that shuffling your feet across carpet and touching a door knob causes a static shock.  
  
Some things to try if this happens regularly:  
  

* Use a humidifier – dry environments are conducive for static buildup
* Anti-static sprays can help reduce environmental static
* Anti-static lotion can help customers with dry skin who experience this issue
* Clothing made of natural fibers are less likely to hold a static charge than clothing made of synthetic materials.

[/expand]     
  
  
## Headset
  
If you are experiencing issues with the Headset, please see the topics below for troubleshooting suggestions:  
  
[expand type=title title="Error 108 (Headset not found)"]  
  
This error may be a USB driver issue. Please try the following troubleshooting steps:  
  
Restart your headset:  
  

* Right click on the headset icon in SteamVR.
* Select Restart Headset, and wait while the process completes.

  
  
Power cycle your Link Box:  
  

* Quit SteamVR
* Unplug the Power and USB cords from the PC side of the Link Box (not the orange side).
* Wait a few seconds, then plug the Power and USB cords back into the Link Box. You may see more drivers install. Wait for this process to finish.
* Launch SteamVR.
* Repeat steps if needed

  
  
Restart your computer (Quit SteamVR before shutting down your PC)  
  
Plug your Link Box into a different USB port on your PC:  
  

* Try plugging your Link Box into a USB 2.0 port, as some USB 3.0 and 3.1 chipsets can cause issues.
* You can also try a USB port that's already in-use and working - move the other device to another port and plug in your Link Box.
* If this problem persists, try resetting your USB devices.

  
[/expand][expand type=title title="Error 109 / Error 400"]  
  
You may see one of these errors if you are not connected to your machine's dedicated graphics card.  
  
Please make sure that both the Vive's Link Box and your primary display are connected to the same GPU. If you are using a laptop, make sure that you are connected to the machine’s discrete GPU. You may need to set your machine to "prefer maximum performance."  
  
Additionally, if you have multiple graphics cards in a desktop PC, make sure that the Vive and your primary display are connected to the same card. Some users have reported that connecting their primary monitor over DVI causes issues next to the Vive. Try using a DisplayPort or HDMI connection.  
  
[/expand][expand type=title title="Resetting USB Devices"]  
  
As a last resort for headset detection issues, you can reset your SteamVR USB devices.  
  

* Unplug all Link Box cables from your PC.
* From the SteamVR window on your desktop, open the menu in the upper left and go to Developer > Developer Settings.
* Under Reset, click on Remove all SteamVR USB Devices. Make sure the Link Box's USB cable is not plugged in and click Yes.
* Once this is complete, quit SteamVR, plug your Link Box in (USB, HDMI, Power), and re-launch SteamVR.

[/expand][expand type=title title="New USB PCI-Express Card"]  
  
If you've tried all of the above and continue to have issues, your USB chipset may be at fault.  
  
Our testing has shown that the Inateck 2-Port USB3.0 PCI-Express Card (Serial: KTU3FR-2O2I) works reliably with the HTC Vive and can overcome these kinds of USB issues.  
  
[/expand][expand type=title title="Error 208 (HMD detected over USB, but monitor not found)"]  
  
Error 208 is a generic HMD error message. This error can have a number of solutions, so please work from the list below to make sure you've attempted all available solutions:  
  

* Make sure that your Vive’s Link Box and the monitor or TV you use as a primary display are plugged into the same graphics card. If you are connected to your onboard display adapter, you will see an Intel HD Graphics device listed in your SteamVR system report. Onboard cards, such as those connected to a PC’s motherboard, will not be powerful enough to use the Vive. Reconnect your Vive to your PC’s dedicated graphics card.
* Check to make sure you are in Direct Display Mode by going to the menu in the upper left of the SteamVR window and then Developer > Developer Settings > Direct Display Mode. Click the button that says “Enable Direct Display Mode.” SteamVR will restart with this setting.
* If Direct Display Mode is not enabled, SteamVR will still work but will run in Extended Mode. For this to work correctly, make sure your displays are extended in Windows > Display Settings.
* Make sure all cables are connected firmly. The power cord on the HMD itself can become loose from usage. To check this, remove the cable panel on top of the HMD by pushing it forward.
* Make sure your Link Box is installed in the correct direction. The orange tipped cables from the Headset should be connected to the orange ports on the Link Box.
* Check to make sure you have the latest video drivers.

[/expand][expand type=title title="Headset not detected"]
* Make sure the headset is properly plugged in.
* The end of your Headset's tether has three orange tipped cords (USB, HDMI, and Power). Plug all three of these into the side of the Link Box with orange ports.
* If you have a first generation Vive Development Kit, do not mix and match the parts. They are not compatible.
* Plug the power cord into the Link Box, and plug it into a power outlet.
* Use the included USB cable to connect the Link Box to an available USB port on your PC. (Vive supports USB 2.0 or greater, but we have encountered issues with certain USB 3.0 ports. If you continue to have issues, try a USB 2.0 port.)
* Use the included HDMI cable to connect the Link Box to your PC. Make sure to plug it into your computer's graphics card.

  ![https://support.steampowered.com/images/faq/steam_vr/vive_install/SteamVR_Support_PreInstaller_Diagram_3b_ConnectLinkBoxtoComputer.png](https://support.steampowered.com/images/faq/steam_vr/vive_install/SteamVR_Support_PreInstaller_Diagram_3b_ConnectLinkBoxtoComputer.png)[/expand][expand type=title title="Headset LED States"]
* Green: Ready state for Vive
* White: Ready state [Vive Pre development kit only]
* Dim Green: Standby mode. Moving your headset or starting a VR application will wake it up.
* Red or blinking red: Cable or driver error. See the instructions for Error 108 above to fix.
* Off: Not plugged in

[/expand][expand type=title title="Camera does not work"]  
  
We’ve found that most users who are not able to use their cameras are running on preview builds of Windows 10 (Windows Insider program).  
  
We’re not able to guarantee SteamVR related features will function correctly on early release builds. If you are running on a Windows Insider preview version, please roll back to the current available consumer version.  
  
[/expand]  
    
  
  
## Controllers
  
If you are experiencing issues with the Controller, please see the topics below for troubleshooting suggestions:  
  
 [expand type=title title="Controller not connected"]  
  

* Make sure the controller is charged and on. Turn on the controller by pressing the system button (lowest button on the controller).
* Charge controllers by plugging them into an outlet with the included micro-USB cord and power adapter. While plugged in, orange indicates charging. While plugged in, the LED color when fully charged is different depending on if the controller is on:
* Green = fully charged and on
* White = fully charged and off
* If the light is solid blue, it is not successfully connecting. Re-pair your controllers by going to SteamVR > Devices > Pair Controller
* If the light is solid red and your controller is not responsive, you will need to reset your controller.
* Hold down the trigger, menu button, trackpad button, and grip buttons on the controller (everything except the system button).
* While holding the buttons, plug your controller into your computer with a micro USB cord.
* Wait for five seconds and release the buttons. Ignore the new storage device that appears and unplug the micro USB cord to reset.
* Your controller should function normally now.

  
  
[/expand][expand type=title title="Controller Trackpad Issues"]  
  
If your controller's trackpad is twitchy and/or oversensitive, it needs to be calibrated.  
  

* Make sure you have the latest Controller firmware. You can check by going to SteamVR > Devices > Update Device.
* Turn off the controller (Hold down the System button).
* While holding the Trigger and the Grip button, press the system button.
* The controller should turn on, and make a different noise than the standard power on noise.

[/expand][expand type=title title="Controller LED States"]
* Green: Ready state for Vive
* White: Ready state [Vive Pre development kit only]
* Blue: Connecting - if it stays in this state, you can pair your controller by going to SteamVR > Devices > Pair Controller
* Blinking Blue: Pairing mode
* Blinking Red: Low battery - charge your controllers by plugging them into an outlet with the included micro-USB cord and power adapter.
* Orange: Charging

  
  
[/expand]  
  
  
  
## Base Stations
  
If you are experiencing issues with the Base Stations, please see the topics below for troubleshooting suggestions:  
  
[expand type=title title="Base Station LED States"]  
  
If both base station LEDs don't turn green, something may be wrong.  
  

* If the LED is green, the base station is operating normally.
* If the LED is blue, it is still spinning up and waiting to stabilize. If it never changes from blue, check to make sure the base is mounted securely. Vibrations can cause it to be stuck in this state.
* If the LED is dim green, it's in standby mode. If unintentionally in this state, try unplugging and replugging the base station to fix this.
* If the LED is solid or blinking purple, the base stations are having trouble seeing each other. Make sure nothing is in the way.
* If the LED is off, it doesn't have power – make sure that the power cord is plugged in and your outlet isn't connected to a light switch.
* White: Ready state [Vive Pre development kit only]

  
  
[/expand][expand type=title title="Optical Sync"]  
  
If your base stations aren't working correctly, make sure they are properly set up for optical sync.  
  

* Check SteamVR to see if your base stations need a firmware update.
* Make sure your base stations have an unobstructed view of each other.
* Base stations shouldn't be further than 5m or 16ft apart.
* Push the mode buttons on the back of the base stations so that one base station is "**b**" and one base station shows "**c**".
* The base station lights should now turn solid green.

  
  
[/expand][expand type=title title="Cabled Sync"]  
  
If your room makes it impossible for the bases to see each other (and the LED is purple), there is another way to sync.  
  

* In the box you'll find a very long cable – this is the sync cable. Connect the base stations with the sync cable.
* Push the mode buttons on the back of the base stations so that one base station is "**A**" and one base station shows "**b**".
* The base station lights should now turn solid green.

  
  
[/expand]   
    
  
  
## Tracking Issues
  
Tracking issues commonly manifest as a drifting or floating movement. Open your Frame Timing graph (from the SteamVR menu, choose Developer > Advanced Frame Timing) and look for frame timing spikes. If you see spikes, the issue is most likely with CPU performance, and not with tracking.  
  
If a device's icon in SteamVR Status is pulsing green, it means it is not tracking. The in-headset displays go grey when your headset loses tracking. Check the following if you are having tracking issues:  
  

* Make sure your base stations are set up correctly. They should be above head height (at least 6.5 feet), angled down 30-45 degrees, and no further than 5 meters, or 16 feet, apart.
* Check to make sure your devices are in view of at least one base station, and your bases are powered and synced. Their LEDs should be green if everything is good. See the Base Stations section above for more information about syncing.
* Loose cable connections can also cause tracking issues. Make sure all connections at the headset, Link Box, and PC are secure.
* While most issues caused by reflective surfaces have been solved, in some situations they can still cause tracking issues. If you are losing tracking or motion controllers occasionally float away in VR, try covering reflective surfaces in your VR area.
* If your headset has a front-facing camera, enabling it can sometimes cause tracking issues. If you lose tracking every time you bring up your dashboard, your camera may be at fault. Try disabling the camera or adjusting camera settings to see whether tracking improves.

      
  
  
## SteamVR Issues (Error 301)
  
If you are experiencing problems with missing or corrupt files in SteamVR or you are encountering an Error 301, make sure the SteamVR tool is correctly installed by verifying the integrity of tool files.  
  

* Quit SteamVR and go to the Steam Client.
* Locate SteamVR in your Library (you may have to enable Tools in the drop-down).
* Right click on SteamVR and select Properties. Click on the Local Files tab.
* Click Verify integrity of tool files.

  
  
If that doesn't work, try deleting the local files. Right click SteamVR and select Manage > Uninstall. Double click SteamVR in the tools library to reinstall.  
  
 [expand type=title title="Remove or Disable Conflicting Software"]  
  
Some software has been found to conflict with SteamVR or SteamVR driver installations. If you have any of the following software installed, try uninstalling it and re-testing:  
  

* Asus AI Suite
* JDS Labs ODAC USB Audio device
* Older Apple Cinema displays with devices attached through USB
* TP-LINK 300Mbps Wireless N PCI Express Adapter TL-WN881ND

  
  
[/expand][expand type=title title="Run Steam as Admin"]  
  

* Exit Steam, then navigate to the Steam installation folder (...Program Files (x86)\Steam\).
* Right-click on Steam.exe, then select "Run as administrator" and re-test the issue.

  
  
[/expand]   
    
  
  
## Audio Issues
  
[expand type=title title="I can’t hear what my friend is hearing in VR"]  
  
It’s possible to duplicate the audio signal being sent to the Vive so you can listen in to what your friend is hearing in VR through another pair of headphones or speakers. You can also record audio being sent to the Vive.  
  
To do this, right click within SteamVR, select Settings, and then select Audio. Under "Audio mirroring" switch to On and choose the audio device from the drop down list where you want to send additional audio.  
  
[/expand][expand type=title title="No sound when using the Vive's headphone extension cable"]  
  

* Move the headset to wake it from standby mode.
* Make sure SteamVR is running.
* Check the SteamVR Audio Settings are sending audio to the Vive. Right click within SteamVR, select Settings, select Audio, switch "Audio output device" to Manual and select HTC-VIVE from the dropdown list or select the Speakers (USB-Audio Device).
* Make sure Windows is sending audio to the "HTC-VIVE-0" audio device: In windows, right click on Volume icon in task tray. Select "Playback devices". Select "HTC-VIVE-0". Right click "HTC-VIVE-0". Select "Set As Default Device". It may be also necessary to right-click on any audio device and select "Show Disabled Devices" and "Show Disconnected Devices."
* Check volume of "HTC-VIVE-0" Audio Device within Windows Volume Mixer. Click on Volume Icon in task tray, find volume slider for HTC-VIVE-0, set to 50%.
* Check volume of program playing audio within Windows Volume Mixer. Right-click on Volume Icon in task tray, Click on "Open Volume Mixer" under HTC-VIVE-0 volume slider. Find program that is playing sound. Make sure volume slider for the program (game/web browser/media player etc) is set to be at least 50%.
* Try swapping Windows audio device to "Speakers - 2-USB Audio Device". In Windows, click on Volume icon in the task tray, then click on the name of the current device, then select "Speakers 2-USB Audio Device". Select "Set As Default Device".
* Try USB Headphones plugged into the extra USB port on the Vive headset. Note: you may need to use the Vive’s USB extension cable for a snug fit within the cable HUB.
* Note: Sending audio via USB may add extra latency to sound playback. We recommend using HTC-VIVE-0 HDMI audio device instead.

  
  
[/expand][expand type=title title="No sound or mono sound while plugged into the Vive's headphone jack"]  
  

* Try checking the steps listed for "No sound when headphones are plugged into the Vive headphone extension cable."
* If the headphones are regular stereo headphones, it's possible they're not fully plugged in. The shape and position of the headphone jack inside the cable panel on the Vive Pre means that some headphones do not fit properly all the way even though it might seem like they're plugged in. Try applying more downward force when plugging in the headphones, or use the audio extension cable provided with the Vive.
* Test stereo positioning: In Windows, right click on Volume icon in task tray. Select playback devices. Highlight the current default audio device (HTC-VIVE-0, or 2-USB-Audio Device). Right-Click on highlighted device and select "Test". If headphones are connected properly there should be two sounds one after the other, one in the left ear and then one in the right ear.

  
  
[/expand][expand type=title title="No sound when using USB headphones with the Vive's extra USB port"]  
  

* Make sure SteamVR is sending audio to the correct playback device. Right click within SteamVR, select Settings, select Audio, in the Set Playback Device choose the USB headphones of your choice.
* Make sure Windows is sending audio to the USB headphone device plugged into the headset. In windows, right click on the volume icon in the task tray. Select Open Sound Settings > then select your desired output device.
* If you can't see the USB headphones in the Audio Devices list - it may be also necessary to right-click on any audio device and select "Show Disabled Devices" and "Show Disconnected Devices."

  
  
[/expand][expand type=title title="Sound stopped playing while plugged into the Vive headphone jack"]  
  

* Check SteamVR is still running.
* Check that the headset hasn't gone to sleep. Nudge or move the headset to wake.
* If you need audio to stay audible through the headset headphone jack even while the headset is asleep, try setting the windows default audio device to "Speakers 2-USB Audio Device".
* Alternatively, use USB headphones on the spare USB port on the headset.
* Note: Sending audio via USB may add extra latency to sound playback. We recommend using HTC-VIVE-0 HDMI audio device for highest quality audio.

  
  
[/expand][expand type=title title="Vive Pre specific issues"]  
  
#### Low quality sound/quiet high pitched ringing when headphones are plugged into the Vive Pre
  
Try turning off exclusive mode within Vive audio device properties:  

* In Windows, right click on Volume icon in task tray.
* Select playback devices. Select "HTC-VIVE-0". Right click "HTC-VIVE-0". Select "Properties". Select "Advanced" tab.
* Uncheck "Give exclusive mode applications priority" and uncheck "Allow applications to take exclusive control of this device." Press "Apply" button.
* Repeat this if you are using a USB headset or sending audio to "Speakers 2- USB Audio Device".

  
  
#### Sound intermittently cuts out or only plays from one ear while headphones are plugged into the Vive Pre’s headphone extension cable
  

* Can be caused by loose headphone jack at the end of the headphone extension cable on some Vive Pre headsets.
* Try plugging headphones directly into the headphone jack on the headset and remove the headphone jack cable. Be sure to press the headphones in firmly.
* Test stereo positioning: In Windows, right click on Volume icon in task tray. Select playback devices.
* Highlight the current default audio device (HTC-VIVE-0, or 2-USB-Audio Device). Right-Click on highlighted device and select "Test".
* If headphones are connected properly there should be two sounds one after the other, one in the left ear and then one in the right ear.

  
  
[/expand]   
    
  
  
## Wireless Receivers
  
There are two wireless receivers built into the Vive headset, used to communicate with the controllers. If you are experiencing issues with the wireless receivers, or if you are encountering "Wireless Receiver Not Detected" or "USB Device Not Recognized" errors, please see the topics below for troubleshooting suggestions:  
  
[expand type=title title="Resetting USB Devices"]  
  
As a last resort for headset detection issues, you can reset your SteamVR USB devices.  
  

* Unplug all Link Box cables from your PC.
* From the SteamVR window on your desktop, open the menu in the upper left and go to Developer > Developer Settings.
* Under Reset, click on Remove all SteamVR USB Devices. Make sure the Link Box's USB cable is not plugged in and click Yes.
* Once this is complete, quit SteamVR, plug your Link Box in (USB, HDMI, Power), and re-launch SteamVR.

  
  
[/expand][expand type=title title="USB Device Not Recognized"]  
  
If Windows is displaying a "USB Device Not Recognized" error after the Vive USB cable is plugged in, and one or both wireless receivers are missing from the USB page in SteamVR settings, the receiver may have been damaged. Contact [Steam Support](https://help.steampowered.com/wizard/HelpWithGameIssue/?appid=250820&issueid=374&nodeid=44&return_nodeid=109) and attach a copy of your System Report.  
  
[/expand]   
    
  
  
## Still Need Help?
  
If you can’t find a solution here, please visit the [SteamVR help site](https://help.steampowered.com/en/wizard/HelpWithGame/?appid=250820) for in-depth support.
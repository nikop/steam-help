# Index Base Station & Lighthouse Tracking
Updated 2021-07-26 22.06.18

![https://support.steampowered.com/steamvr/FitGuide/GuideHeader.png](https://support.steampowered.com/steamvr/FitGuide/GuideHeader.png) # General troubleshooting
Before reading further, be sure to:  
  

* Check power connections for all Base Stations
* Make sure your Base Stations are pointed at your play area and are visible to you.
* Restart SteamVR

  
---
# Trouble with tracking?
  
  
Tracking issues commonly manifest as drifting or floating movement of the controllers or game world when you are not in motion. To minimize potential tracking issues in your environment, start with these steps:  
  
#### Remove Film Sticker
Base Stations are packaged with a protective sticker on the front-facing surface. The sticker can interfere with tracking if it is not removed before use.  
  
#### Check Base Station positioning
Base Stations should be aimed and angled toward the center of the play area. In the ideal setup, Base Stations should be	above head height (at least 6.5 feet / 2 meters), angled down by 30-45 degrees, positioned no more than 16 feet / 5 meters apart, and place opposite one another in separate corners of the play area. Make sure your Base Stations are mounted or set on a solid surface that isn't prone to vibration or movements - bumps and vibrations can cause tracking problems.  
  
Many other setups are also perfectly functional. Remember that if you are placing a Base Station at head height or lower, you should take height into account when deciding how to angle it. A base station on a coffee table should be pointed slightly upward, while one between waist and shoulder height won't need to be angled at all.  
  
#### Remove or cover reflective surfaces in your play area
Objects such as windows, mirrors, televisions, and monitor screens can interfere with tracking. If you are losing tracking or motion controllers occasionally float away in VR, try covering or removing reflective surfaces in your play area.  
  
#### Rerun Room Setup
Performing a fresh room setup can help clear up any issues caused by changes to the environment or Base Station positioning.  
  
#### Performance issues can mimic tracking issues
Spikes in performance quality and "lagging" behavior are usually caused by computer configurations that don't meet our recommended requirements or aren't functioning optimally. Local issues like these are tough to troubleshoot, so we recommend checking with a local computer specialist to find out how to best improve your computer's performance.  
  
To check for spikes in performance, run SteamVR and navigate to menu > *Developer* > *Advanced frame timing*. For detailed information on how to use this feature, [check out this developer article](https://developer.valvesoftware.com/wiki/SteamVR/Frame_Timing).  
  

---
  
  
 # Base Station is not solid green in SteamVR status window
Check the LED in the top center of the Base Station's front (convex) surface:  
  
#### LED is flashing blue
This indicates that the Base Station is not stable or is encountering vibrations. This will prevent the laser from functioning. Make sure your Base Station is in a stable location and is not being subject to vibration or shaking. If the problem continues, consider moving the location of your Base Stations.  
  
#### LED is flashing red
The Base Station has encountered an error. Please click "Contact Steam Support" below to get help.  
  
#### No LED
The Base Station is not receiving power. Try swapping your other Base Station to the same power outlet to test whether the device or the outlet is at fault. If a Base Station will not power on and the outlet is not causing the problem, please click "Contact Steam Support" below to get help.  
  

---
# Channel conflicts
SteamVR will notify you if it detects a channel conflict in your Base Stations. Although Base Stations should arrive correctly configured, you can change their channel settings from the SteamVR status window if the *Base Station Setup Error* message appears. To do this:
* Navigate to the SteamVR status window.
* Select the menu, then *Devices* > *Base Station Settings* > *Configure Base Station Channels*
* Wait for SteamVR to identify nearby base stations, then either select *Automatic Configuration* or manually change each channel by clicking on it.

  
  
Base Stations packaged with VR Kits are configured to channels 1 and 2. Individually purchased Base Stations have their channels set between channels 3 and 16.   		If you're using a fourth Base Station or using VR in a place with more than one play area set up, you may need to update channel settings to avoid conflicts.  
  

---
# Power Management issues
SteamVR's Base Station Power Management  feature is turned OFF by default. Turning this feature ON ensures that your Base Stations power off when not in use to reduce power usage and extend their lifespan.  
  
Valve recommends turning this feature ON if you are not in a shared tracking space.  
  
You can turn this feature on/off at any time by navigating to SteamVR->Settings->Base Station->Power Management.  
  

* When this feature is OFF, your Base Stations will remain powered and emitting whenever they are plugged in.
* When this feature is ON, your Base Stations will go into standby when SteamVR is not in use and wake up when SteamVR starts.

  
  
If you're having problems with your Power Management settings, please click [Contact Steam Support](https://help.steampowered.com/en/wizard/HelpWithValveIndex) to get help.  
  
If you are using VR in a shared tracking space with multiple instances of SteamVR running, turn off Base Station Power Management to avoid power state conflicts.  
  

---
# Other questions
#### Base Station compatibility?

* 1.0 (HTC-branded) and 2.0 (Valve-branded) Base Stations will not work with each other in the same VR setup.
* Index will work with both 1.0 and 2.0 Base Stations.
* 2.0 Base Stations will not work with the original Vive headset or Wand controllers, but will work with the Vive Pro product family.

 #### How many Base Stations do I need?
We recommend two Base Stations for most room-scale play areas. If you're covering an area larger than 5 x 5 meters (~16 x 16 feet), you can add additional Base Stations for additional tracking and increased accuracy.  
  
For seated or standing-only play areas, one Base Station can be sufficient, but two are still recommended to ensure your Base Stations don't lose sight of your devices.
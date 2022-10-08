# Docking the Steam Deck
Updated 2022-10-06 16.30.15  
Version 1  

While Steam Deck is great in handheld mode, there may be times where you want to use different input devices, share your screen in a multiplayer game, or even get some work done - that's where docking comes in. Steam Deck works great with a variety of USB-C docks or hubs. Most users will be plugging in a USB-C charger for PD passthrough, as well as peripherals, controllers, and external displays. This article will cover basic operation and troubleshooting steps.   
  
## Getting started
  
First, just plug all the items into the dock that you would like to connect to your Steam Deck. The most common devices that we've seen users connect are external displays (monitor or TV), a keyboard/mouse or controllers, ethernet cables, and a power source.   
  
In general, connections to USB peripherals, displays, and your network should behave as expected -- the Steam Deck is a general-purpose PC and has built-in compatibility for many devices in these categories. However, Steam Deck's underlying operating system (Linux) maybe unfamiliar to some users or have unexpected device compatibility issues.   
  
If you're connecting to an external display and it has **a 'Gaming Mode' option** available, we recommend turning that on when connected to your Steam Deck. Also, try turning off any "motion smoothing" or other image processing features because they may add latency or cause other issues.  
  
## Troubleshooting
  
  
[h5]Compatibility notes for 3rd-party docks and hubs[/h5]  
* Most USB-C compliant hubs and docks will work without issue with Steam Deck. Thunderbolt and DisplayLink docks may work, but are not officially supported.
* In order to power the Steam Deck, a dock/hub with USB-C Power Delivery (PD) passthrough is required. Note that some docks may "reserve" part of the power contract for powering downstream peripherals, you may see a "slow charge" warning as a result.
  
[h5]Display setup[/h5]  
* Check that you have the correct display input selected on your TV or monitor. It should correspond to the HDMI or Display Port cable that's plugged in to your docking Station. TVs often have many HDMI inputs and you may need to cycle through them to find the right one.
* Some displays may have different features or capabilities per input. For example, many TVs have 4K/2K inputs with 60Hz limits on certain ports and 30Hz limits on others. Refer to the User Manual of your display to verify input requirements.
* Note that when plugging in a display + cable, your Deck’s screen will go black. This is expected behavior in Gaming Mode. Right now, the only way to enable both/multiple displays is by rebooting into Desktop mode. We may enable mirroring options in Gaming Mode in the future.
* If the Deck’s display does not go black when an external display is plugged in, perform a reset (see below). If there is still no display detected, unplug and replug the display cable, try a different display input port, check input selection, or try a new cable - they can sometimes be at fault.
* Try a different source and/or dock/dongle (laptop, desktop, phone/tablet - needs to have display out capabilities).
* Try multiple display cables - note that a "known good" cable on one set up may not work on another if the output datarate is different. Datarates may vary depending on color depth/HDR, compression, resolution, and refresh rate. This note applies especially to high resolution/high refreshrate modes. We recommend DP 1.4 and HDMI 2.0+ compliant cables for highest compatibility.
* The Steam Deck UI allows for overriding resolution and refresh rates via the Steam > Display menus. If a lower resolution and/or refresh rate displays correctly, your dock, cable, or display may not support the mode you are trying to set.
  
[h5]Resetting your dock[/h5]  
* If you believe you need to reset the dock itself, then just fully unplug the deck and dock, including the power supply and display cables, and then plug the cables back in. Note that even when the dock is unplugged from its own power supply, it will still receive power from the Steam Deck, so it's necessary to unplug both for a full reset.
  
[h5]Display output does not fit screen[/h5]  
* If your display output does not fit your display, the Gaming Mode UI has settings to help fine tune your experience. Under the Steam > Display menu, disable “Automatically Scale User Interface,” then tweak the slider to match display.
* Your display may also have settings to adjust how the output image is displayed. In your TV/display settings, check for “Overscan” options. Due to the sheer number of display peripherals, no official support is provided.
  
[h5]Graphics/Image quality[/h5]  
*  If you have issues with graphics/image quality or performance, you may require in-game tweaks to optimize performance.
*  Depending on the scenario, you may require a cable or input connector swap.
  
[h5]Other things to keep in mind[/h5]  
* In gaming mode, the Deck display is disabled. If mirroring or utilizing the display is necessary, launch the game title from Desktop mode (accessed under the Steam > Power menu).
* If you continue to experience issues with your external display, check the display's User Manual to see if there are limitations on the inputs (i.e. 4K30, Display Stream Compression(DSC), HDR modes, etc.)
  
  
### Bluetooth issues
  
Often wireless controllers or audio devices are used with the Steam Deck.  Below are a few things to try if you are having issues with a Bluetooth connection on the Steam Deck. 
* Ensure the Deck has a clear line of sight to where the controller is being used and is not behind a TV or inside a cabinet
* Using a wired ethernet connection (if applicable) through the dock can improve Bluetooth performance
* If you're using WiFi, please try to connect to a 5GHz access point, as Bluetooth is transmitted at 2.4GHz. 2.4GHz WiFi can cause interference.
* Try to position the Steam Deck away from your wireless router or other 2.4GHz devices to avoid interference.
* Check that any high bandwidth USB3 accessories such as hard drives, webcams, or capture cards are as far away from the Steam Deck body as possible - similarly to 2.4GHz devices, 5 Gbps USB3 can interfere with bluetooth and WiFi radios.
* Make sure that Steam is set to not download game updates during gameplay
* If you are having issues connecting or maintaining pairing with your controller, check for software/firmware updates. We have found that many Xbox controllers require a firmware update before they will function as expected with the Steam Deck, for example.
  
  
### Audio issues
    
* To enable 5.1/7.1 audio over HDMI/DP: While plugged into the display, go to Desktop mode, click on the speaker icon on the task bar, find the HDMI/DisplayPort  slider, click on the 3-line menu and select the number of channels that you want. This will then stay selected when switching back to Gaming Mode.
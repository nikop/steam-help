# Voice Chat Connection and Quality Issues
Updated 2021-08-12 21.09.32

Steam voice chat is designed to require minimal setup, provided your default Window's devices are already working properly. If you are experiencing a problem, try resolving it by following the troubleshooting steps outlined in this article.  We also encourage players to visit our official [Steam Chat Discussions](https://steamcommunity.com/groups/SteamClientBeta/discussions/3/). There may be other users experiencing your issue who have already discovered a fix or posted a workaround. Our development team actively monitors these discussions as well.   
  
  
# Steam voice chat won’t connect
  
Steam voice chat connects and communicates using WebRTC standard protocols. In order to connect to a voice chat, you will need to be able to send outbound UDP traffic to remote ports 27014 through 27020 and receive responses back. If you ever see your voice status stuck at “Connecting…”, it's likely that this traffic is being prevented.  
  
You can find detailed logs about your connection state and voice chat attempts by going to *Friends List > Settings (Gear Icon) > Voice > Show Advanced Settings > Copy Voice Logs To Clipboard*. If you are working with Steam Support on a voice chat issue, they may ask you to provide these logs.  
  
You'll want to investigate the following configurations on your machine and make sure that your voice chat traffic is not being interfered with. Because these issues are dependent on configurations unique to your specific setup, we recommend that you contact a PC support specialist in your area for detailed assistance.  

* ## Investigate router ports
  
Steam voice chat uses ports 27014 through 27020 for outbound communication and will automatically select an available port to receive UDP responses.  
  
Most routers and networks will automatically allow this traffic, but if you have changed your router configuration to be more restrictive, you will need to investigate and update that. You may consider reverting to a default configuration to further test the issue.
* ## Investigate firewall software
Certain firewall configurations may prevent voice chat from working correctly. If you have a third-party firewall other than Windows Firewall on your machine, it is possible that it's restricting traffic.  
  
You may consider temporarily disabling it for testing purposes. If that fixes it, you'll need to add rules/exceptions for Steam and steamwebhelper.exe
* ## Investigate anti-virus software
Certain Anti-Virus products (like versions of Kaspersky Total Security) are known to block WebRTC traffic via their AV component, even if you've fully disabled the included firewall. You may need to try disabling or fully uninstalling third-party security software to check if it is interfering with Steam voice traffic. If it is, you may need to upgrade the version of your security software or contact the third-party vendor for support.  
  
You might also try adding exceptions for Steam in your AV configuration (for example, excluding steamwebhelper.exe from live monitoring services).

   
  
  
# Voice chat sounds bad or has low quality
  
To achieve optimum sound quality, it is important that you spend some time configuring your audio settings, both for your operating system as well as through Steam Chat.  
  
Behavior that you may be attributing to a bug or bad performance, could simply be a setting or option that you haven't yet configured. You can access your chat settings via the gear icon in the upper right corner of your Steam Friends list.  

* ## Open your settings
  
**Steam voice settings:** Select the gear icon in the upper right corner of your Steam Friends list, then select to the *voice* tab.  
  
**Windows sound settings:** Right-clicking on the speaker icon in your system tray and select *Open Sound settings*. You can also access this panel from your Windows Control Panel by clicking on *Hardware and Sound -> Manage Audio Devices*.
* ## Check your devices
You'll first want to check that you have the correct voice Input/Output devices chosen in your Steam Chat voice settings. If set to Default, Steam chat will use the default recording and playback devices that you have set through Windows. This allows Steam to adjust automatically when Windows settings are changed.  
  
From your Windows manage audio devices panel, you can view what devices Windows recognizes, as well as which ones are currently selected as default. The default devices should display a green checkmark and have an associated green level meter that you can use to test input/output volumes. You can also right-click any of these devices to set them as default or open properties.
* ## Adjust input volume/gain
Input volume/gain within Steam voice settings is the first and most important setting you should configure. You should adjust this while in a voice chat with a friend, until they can hear you at a reasonable volume and vice-versa. Increase it if you are too quiet, and decrease if you are too loud.  
  
If you are too quiet even after raising this setting all the way, you may need to adjust your microphone's gain/boost setting or the Windows controlled recording level for your microphone device.  
  
From your Windows manage audio devices panel, you can view your default devices along with their associated green level meters to test input/output. You can also right click any of the devices and select the *properties* option for more advanced volume/gain options.  
  
Some audio hardware also has its own proprietary control panels and option menus. You would want to work with the manufacturer support team for advanced configuration help with these.
* ## Adjust voice transmission threshold
Once you are confident that your input volume/gain levels are set appropriately, you may want to adjust your voice transmission threshold accordingly. If the audio from your microphone is below the set threshold, Steam won’t transmit it at all.  
  
If others are hearing white noise/typing/background sounds then you can try raising the transmission threshold to High.  If others are saying parts of your words are cut off, or that you sound choppy or cut in and out, then you may have it set it lower or even turn it off completely.
* ## Adjust advanced options
Finally, there are more specific options under the Show Advanced Options section - most users will benefit from leaving all of these on. However, if friends are saying that you randomly become louder/quieter you may want to disable Automatic volume/gain control.  
  
If nothing else in this article has helped, you may try disabling echo or noise cancellation just in case they are causing quality issues with your hardware.
* ## Test other hardware
Check the inputs for your microphone, headphones, speakers and other audio devices. If you are having an issue, try swapping to another available USB or audio port. If you're using any converters, extensions or other intermediary devices, bypass them temporarily to make sure they aren't contributing to the issue.  
  
Finally, if you have extra hardware or an alternate PC, try swapping them out or testing on a different machine to eliminate the possibility that your current hardware is having an issue.

  
  
  
  
If you continue to experience issues, or encounter something that isn't covered here, you can always submit a detailed report to [Steam Support](https://help.steampowered.com).
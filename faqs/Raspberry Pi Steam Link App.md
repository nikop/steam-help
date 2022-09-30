# Raspberry Pi Steam Link App

![https://support.steampowered.com/images/faq/steam_universe/Hardware_SteamLogo_Banner.png](https://support.steampowered.com/images/faq/steam_universe/Hardware_SteamLogo_Banner.png)  # Steam Link App for Raspberry Pi
The Steam Link app extends Steam Link functionality to the Raspberry Pi 3B and 3B+, running Raspbian Stretch. The App uses the same streaming technology as Valve's Steam Link, allowing you to play your favorite games and even spectate VR games right from your Raspberry Pi.  
  
#### Required/Recommended Equipment

* A computer running Steam, Windows 7 or newer, Mac OS X 10.10 (Yosemite) or newer, SteamOS, or Linux Ubuntu 12.04 or newer.
* A wired network (5 GHz wireless may work, but is not recommended on the Raspberry Pi)
* A Raspberry Pi 3B or 3B+ running Raspbian Stretch

 #### Supported Input/Controllers

* [The Steam Controller](https://store.steampowered.com/app/353370/Steam_Controller/) (wired or using the included wireless dongle)
* The official Microsoft Xbox One Wired Controller
* The official Microsoft Xbox One S Controller (wired)
* The official Microsoft Xbox 360 Wired Controller
* The official Microsoft Xbox 360 Wireless Controller for Windows (with wireless receiver)
* Sony DualShock 4 (wired or wirelessly using Bluetooth)
* The official Nintendo Switch Pro Controller (wired)
* Razer Raiju, Sabertooth, Serval, and Wildcat controllers
* SteelSeries Stratus Duo
* Keyboard and mouse

  
*Please note: other input devices may work even if they aren’t officially supported.*  
  
#### Getting Started

* Turn on your home PC, launch Steam, and log in.
* Ensure your Pi is connected to the same network as your host PC.
* Run the following in a terminal window to install:  
`  
  
sudo apt update  
sudo apt install steamlink  
  
`
* You can launch Steam Link from the Games menu, or run `steamlink` from a terminal window.

  
  
If you have questions about the app or need help using it, just click the appropriate tab.  
  
[expand type=title title="Frequently Asked Questions"]#### The game is choppy and unresponsive. How can I improve the experience?
Using a wired network is strongly recommended with the Raspberry Pi.  
  
You can also try switching to the ‘Fast’ streaming quality option from the Streaming settings in the Steam Link. You can find out more information about improving wireless experience [here](https://help.steampowered.com/en/faqs/view/3E3D-BE6B-787D-A5D2).  
  
#### Can I use the Steam Controller in Bluetooth mode?
Bluetooth mode is not supported on the Raspberry Pi. The wireless dongle that came with your Steam Controller is lower latency and works well. Your Steam Controller can be paired with the dongle in the controller settings in the Steam Link app.  
  
#### Can I use an input device not listed on this page?
Steam Support is unable to provide assistance with unsupported devices, however, we do have an active community that may have found solutions to the issue you’ve encountered.  
  
Please visit the [Steam Link section of the Steam Discussion forums.](https://steamcommunity.com/app/353380/discussions/6/)  
  
#### Can I use surround sound?
Surround sound works using HDMI multi-channel PCM. If your sound system only supports encoded surround sound (AC3, Dolby DTS, etc.) you should use Stereo audio streaming settings.  
  
[/expand][expand type=title title="Troubleshooting"]#### Experiencing Performance Issues?
If you are experiencing performance issues please ensure that your [settings are optimized for Streaming.](https://help.steampowered.com/en/faqs/view/3E3D-BE6B-787D-A5D2)  
  
#### Xbox triggers reversed?
If the Xbox controller triggers are reversed, you are probably using the unsupported xboxdrv gamepad driver. You can go to the Steam Link app controller settings and remap your controller to work with this driver.  
  
#### Contacting Steam Support
If you have other issues or questions, contact [Steam Support](https://help.steampowered.com/en/wizard/HelpWithGameIssue/?appid=353380&issueid=354&nodeid=1&return_nodeid=9) and attach the **remote_connections.txt** and **streaming_log.txt** files to your ticket.  
  
The default location for these files is: ***C:\Program Files (x86)\Steam\logs***  
  
[/expand]  
  

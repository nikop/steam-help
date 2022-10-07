# Steam Link - Suggested Network Settings
Updated 2021-08-28 00.52.17  
Version 6  

![https://support.steampowered.com/images/faq/steam_link/SteamLink_Support_Header01.png](https://support.steampowered.com/images/faq/steam_link/SteamLink_Support_Header01.png)  
  
# Remote Play Streaming Suggested Network Settings
  
The Steam Link hardware and streaming app both leverage Steam Remote Play. See our [Steam Remote Play FAQ](https://help.steampowered.com/en/faqs/view/0689-74B8-92AC-10F2) for more details on this technology.  
  
If you haven't already, we also recommend checking out the [Troubleshooting Network Connectivity](https://help.steampowered.com/en/faqs/view/669A-2F68-D1D1-A5EC) and [How do I diagnose and report network problems?](https://help.steampowered.com/en/faqs/view/3E5A-CFB6-2269-D6C1) articles for more background information and suggestions regarding general network troubleshooting.  
  
**For specific information on how to accomplish these tasks, please see your modem/router’s documentation.**  
  
  
# Troubleshooting First Steps
 #### Connect your computer to a wired network
One of the main causes of performance issues is interference. If your PC is on the wireless network and trying to send data to your router while your router is sending that data to your device or your device is talking back, they'll interfere and you'll have a choppy experience. We highly recommend making sure your computer is directly connected to the router with Ethernet.  
  
#### Enable the Performance Overlay
The Remote Play Streaming Performance Overlay can help you determine if you are encountering a network-related problem. You can also use this feature to show the impact of the troubleshooting you perform.  
  
Go into the advanced streaming settings on your device and enable the performance graph. Then, while streaming, watch for large spikes in the cyan line. This indicates highly variable network time, which is the main indicator of streaming network issues. These will usually coincide with video stuttering or freezing.  
  
A detailed guide of the Performance Overlay and what the displayed information means can be found in the[ Steam Remote Play discussion forums.](http://steamcommunity.com/groups/homestream/discussions/0/540732889636623310/#c540732889652053359)  
  
#### Remove other sources of interference
Other applications using the wireless network can interfere with game streaming. Make sure no one else is streaming movies or audio (using BitTorrent, Chromecast, etc.).  
  
  
# Can't Locate Your Computer?
  
#### Network Ports
Remote Play uses the following ports:  

* UDP ports 27031 and 27036
* TCP ports 27036 and 27037

  
Please ensure that Steam is allowed to listen to these ports in your host computer firewall software. We suggest contacting your network administrator or firewall software developer for more information.  
  
See our [Required Ports for Steam FAQ](https://help.steampowered.com/en/faqs/view/2EA8-4D75-DA21-31EB) and our [Using a Firewall with Steam](https://help.steampowered.com/en/faqs/view/66C8-4FF1-8470-B666) FAQ for additional suggestions and more details on this process. Please note: If Steam or your game has updated recently, your firewall may be preventing network access even if it worked correctly before.  
  
#### Client Isolation
In order to use Steam Remote Play, please **ensure that Access Point/Client Isolation is disabled** in your router settings.  
  
Please note: Steam Remote Play is not supported on public networks, workplace or school/university networks, guest networks, networks with gateway portals or which require a log-in, or other networks with access point/client isolation enabled. These types of networks will prevent you from connecting in most cases. Please consult your network administrator for more details.  
  
#### WPS
The Steam Link is enabled to work with WPS security; however, if you encounter any issues connecting to a WPS access point, please disable WPS and use an alternative method of connecting to troubleshoot the issue.  
  
  
# Experiencing Poor Streaming Quality?
#### Connecting via a Wireless Router
Steam Remote Play is compatible with most home networks. A wired network will provide the best result, and we highly recommend using an Ethernet connection if your Remote Play streaming client supports it. Wireless and power line connections can cause intermittent failures due to interference. You can test your devices using a direct wired connection to determine if this is a problem.  
  
For best performance we recommend using a router that supports the 802.11ac protocol.  A router that supports the 802.11n via a 5GHz signal will be the next best choice.  
  
To optimize your network:  

* Choose the 5 GHz WiFi band over the highly congested 2.4 GHz band. The 5 GHz band has a shorter range, but there is less interference from your neighbors and other wireless devices.
* Choose a WiFi channel on the Access Point (AP) that isn't congested. One example of a program you can use see this is [NetSurveyor](http://nutsaboutnets.com/netsurveyor-wifi-scanner/). You lose over 50% of your data rate when there is channel interference with your neighbors.
* Set the AP to use a 5GHz channel near the top of the band; the top end starts at channel 149.
* Try to see if you can connect when the AP channel width is set to at 40 MHz, instead of a 20 MHz width for 11n and 11ac. If 40 MHz works, then try 80 MHz that is enabled with an 11ac capable router. Higher channel bandwidths can provide faster speeds but are more sensitive to distance and other sources of RF noise.

 #### Move your equipment for a better signal
The strength of the wireless signal is affected by interference from other wireless networks, distance, and walls, floors, metal, and electronic equipment between your wireless router and the Steam Link. Sometimes moving your router to a better location or moving your Steam Link out in front of your TV can help dramatically. Also make sure that your PC and router are in open, well-ventilated areas, as their performance will be reduced when they are overheating.  
  
#### Change the Link’s streaming quality
Setting the quality to “Balanced” or “Fast” will reduce the bandwidth used for streaming, reducing the visual quality and lowering the load on your network.  
  
#### Device Priority/Quality of Service (QOS)
Adjusting the designated bandwidth or device priority for your streaming client and host can improve the quality of your streaming experience.  
  
Most routers include this feature as **Quality of Service (QoS)** settings or **Bandwidth Priority** settings that can be accessed through the router administration panel, or in some cases an associated application provided by your equipment manufacturer. Make sure that your streaming client and host are prioritized in these settings.  
  
You can also enable network prioritization within Steam Remote Play settings. Go to **Steam > Settings > Remote Play > Advanced Host Options**, and check the **Prioritize Network Traffic** option at the bottom.  
  
#### Update your router firmware
Some wireless routers have bugs in handling the amount of UDP traffic sent in Remote Play. Please make sure your router has the latest firmware updates to resolve any known issues.  
  
#### Tune your streaming bandwidth
You can directly limit the resolution and amount of bandwidth used in the advanced streaming settings. If you want to tune things exactly right for your setup, you can start at 3 Mbit/s and slowly increase the bandwidth until you start getting hitches and then drop it back down. You can do this live while your game is running by bringing up the Steam overlay with the guide button or Shift+Tab and going to the streaming settings panel.
# Steam Deck - Network + WiFi Troubleshooting
Updated 2022-06-16 22:45:15  
Version 1  

* [General Troubleshooting](#trouble)
* [Required Ports for Steam](#ports)
* [Known Issues with Internet Service Providers (ISPs)](#isp)
  
### General Troubleshooting
  
Please see the sections below to help diagnose network issues on your Steam Deck:  
  
#### Network Connectivity
  
* **Authentication protocols** - We're aware of potential issues with connectivity on Steam Deck when using PEAP or WEP authentication. We recommend testing with a different protocol if possible.
* **WiFi frequency** - If you have both a 5GHz and 2.4GHz connection available on your network, we recommend trying both to see if the issue you're experiencing may be alleviated on a different band.
* **Router troubleshooting** - You can check our [Using a Router with Steam](https://help.steampowered.com/en/faqs/view/46D2-B5B1-F0B9-B867) article for tips on isolating problems with your router.
  
#### Steam Connectivity
  
* **Steam server status** - Please check the [Steam Server Status page](https://store.steampowered.com/stats/) to ensure the issue which you are encountering is **not** related to system-wide downtime. If you encounter any timeout errors when attempting to access Steam sites, it is very likely that there is a system-wide issue and Steam will not be accessible until the issue is resolved.
* **Local interference** - Wireless and powerline connections can cause intermittent failures due to interference. If possible, test Steam with a direct wired connection to determine if this is a problem (you'll need additional hardware to connect from USB-C to ethernet). An Internet speed test may also help you identify problems related to local link quality.
  
#### Download Speed
  
* **Router settings** - You may want to change your router's channel to a less congested one. Additionally, you may want to revert any changes you have made to your DNS settings. If you're not sure how to access your router to make these changes, you should be able to find the information you need on the website of your router's manufacturer.
* **Steam installations** - Steam installations tend to be CPU and disk intensive. The reported download speed isn't necessarily representative of your download capacity because the download can be throttled to match the speed at which Steam can perform the other tasks related to installing a game. If you're used to using Steam on a more powerful desktop, you may notice a difference in speed. If you're installing to an SD card, the media's write speed may also affect your total installation time.
  
  
### Required Ports for Steam
All required ports to run the Steam application are listed [here](https://help.steampowered.com/en/faqs/view/2EA8-4D75-DA21-31EB).  It is possible that other games available on Steam will require further ports to be available.  
  
  ### Note:
Many university networks and proxies block required ports for Steam operation - please consult your network administrator to ensure the required ports are open if you are using a university network or a proxy. **Ports required for Steam can not be re-mapped to HTTP or reconfigured to a custom port range.**  
  
### Known Issues with Internet Service Providers (ISPs)
  ### Important:
If you notice that your Steam connection only has issues during certain hours of the day (for example in the evenings between 5pm and 11pm), it is possible that your ISP is blocking or "shaping" your connection.  Please test your connection at other hours of the day and contact your ISP directly if you believe this is causing the connection issue.  
Some ISPs have been found to block ports required for the proper operation of Steam and Steam games:  
* **012.net** (Steam traffic blocked)
* **Bluewin** (Firewall blocks Steam from provider side - must be disabled through provider's service portal)
* **Dutch Telecom** (Steam traffic blocked)
* **ISPFree** (Steam traffic blocked)
* **Micronet Broadband** (Steam traffic blocked)
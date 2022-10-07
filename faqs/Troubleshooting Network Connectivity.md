# Troubleshooting Network Connectivity
Updated 2021-08-12 01.54.58  
Version 5  

* [Troubleshooting Network Connectivity Issues](#trouble)
* [Required Ports for Steam](#ports)
* [Known Issues with Internet Service Providers (ISPs)](#isp)

  
  
### Troubleshooting Network Connectivity Issues
Please follow the steps below to diagnose network connectivity issues within Steam:  
  

* **Check Steam Server Status**  
Please check the [Steam Server Status page](https://store.steampowered.com/stats/) to ensure the issue which you are encountering is **not** related to system-wide downtime. If you encounter any timeout errors when attempting to access Steam sites, it is very likely that there is a system-wide issue and Steam will not be accessible until the issue is resolved.
* **Test Your Router**  
The [Using a Router with Steam](https://help.steampowered.com/en/faqs/view/46D2-B5B1-F0B9-B867) topic includes steps to isolate problems if they occur at the router.  
  
Wireless and powerline connections can cause intermittent failures due to interference. If possible, test Steam with a direct wired connection to determine if this is a problem. An Internet speed test may also help you identify problems related to local link quality.
* **Troubleshoot all Firewalls**  
See the [Using a Firewall with Steam](https://help.steampowered.com/en/faqs/view/66C8-4FF1-8470-B666) topic for instructions to test and configure your firewall for Steam.  
  
**Note:** If you are installing Steam for the first time or Steam has recently been updated, a firewall may be preventing Steam from connecting to the Steam Network - even if Steam worked correctly before the update was applied.
* **Disable Background Applications**  
Review the [Programs Which May Interfere With Steam](https://help.steampowered.com/en/faqs/view/1F39-DCB4-FF28-5748) and reconfigure, disable or uninstall any programs which may be preventing Steam and Valve games from connecting.
* **Viruses, Trojans, Adware and Spyware**  
Scan your computer for [Spyware, Malware, Adware, or Virus Interfering with Steam](https://help.steampowered.com/en/faqs/view/70D4-67C8-784D-692A).

  
  
[](id=ports)  
### Required Ports for Steam
All required ports to run the Steam application are listed [here](https://help.steampowered.com/en/faqs/view/2EA8-4D75-DA21-31EB).  It is possible that other games available on Steam will require further ports to be available.  
  
  ### Note:
Many university networks and proxies block required ports for Steam operation - please consult your network administrator to ensure the required ports are open if you are using a university network or a proxy. **Ports required for Steam can not be re-mapped to HTTP or reconfigured to a custom port range.**  
  
[](id=isp)  
### Known Issues with Internet Service Providers (ISPs)
  ### Important:
If you notice that your Steam connection only has issues during certain hours of the day (for example in the evenings between 5pm and 11pm), it is possible that your ISP is blocking or "shaping" your connection.  Please test your connection at other hours of the day and contact your ISP directly if you believe this is causing the connection issue.  
Some ISPs have been found to block ports required for the proper operation of Steam and Steam games:  

* **012.net** (Steam traffic blocked)
* **Bluewin** (Firewall blocks Steam from provider side - must be disabled through provider's service portal)
* **Dutch Telecom** (Steam traffic blocked)
* **ISPFree** (Steam traffic blocked)
* **Micronet Broadband** (Steam traffic blocked)
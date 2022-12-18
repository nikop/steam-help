# Slow Downloads and Connection to Content Servers
Updated 2021-08-18 20:46:25  
Version 7  

How can I troubleshoot slow downloads or connections within Steam?  
  
## Is your download actually slow?
* **Comparing Steam download speeds to your Internet connection speed:**  
Internet and other network connection speeds are typically measured in multiples of **bits** per second. However, Steam downloads, like many other file downloads, are measured in multiples of **bytes** per second. A **byte** is a group of 8 bits.  
  
To compare your Steam download speed to your connection speed, you can either switch your Steam client to display download information in bits (see the how to below), or you can multiply your Steam download speed by 8. For example, if you are getting 768KB/s (kilo**bytes** per second) as your Steam download speed, you are getting 6144Kb/s (kilo**bits** per second) or 6 megabits per second download speed according to most Internet service providers.  
  
**Example download speed conversions**  
[expand][table]  		  			[tr]  				[th]**Advertised Connection Speed**[/th]  				[th]**Est. Max Steam Download Speed**[/th]  			[/tr]  			[tr]  				[td]**3 megabits/second**[/td]  				[td]**384 KB/S**[/td]  			[/tr]  			[tr]  				[td]**5 megabits/second**[/td]  				[td]**640 KB/S**[/td]  			[/tr]  			[tr]  				[td]**15 megabits/second**[/td]  				[td]**1.9 MB/S**[/td]  			[/tr]  			[tr]  				[td]**20 megabits/second**[/td]  				[td]**2.5 MB/S**[/td]  			[/tr]  			[tr]  				[td]**30 megabits/second**[/td]  				[td]**3.75 MB/S**[/td]  			[/tr]  			[tr]  				[td]**50 megabits/second**[/td]  				[td]**6.25 MB/S**[/td]  			[/tr]  		  	[/table] ****  [/expand]  
  
**How to switch Steam's download information from bytes to bits**  
[expand]  
* Go to **Steam** > **Settings** > **Downloads** tab
* On the Downloads tab check the **Display download rates in bits per second** box
[/expand]  
  
**What is your actual Internet connection speed?**  
The speed displayed in your System Tray or network connection properties is typically the speed you are connected to your local area network (LAN) and does not represent the speed you are connected to the Internet at. Please refer to the materials for your connection plan or contact your Internet service provider (ISP) for information on your connection speed. You can also use one of the numerous speed testing sites available online such as [Speedtest](https://www.speedtest.net/) or [DSLReports](http://www.dslreports.com/) to test your connection speed.
    
## Content Servers
Steam uses content servers that are located all over the world. Steam attempts to select the best content server based on your location.  If Steam downloads are going slower than expected, please double check your current download region:  
* Start Steam
* Go to **Steam** > **Settings** > **Downloads** tab
* Under **Download region**, select the region that you are in or that is closest to you.
* You can also try various regions near your location to see if a better connection is available.
  
## Third Party Applications
Some third-party applications can cause Steam to use incorrect content servers. Any sort of Internet security and/or packet filtering software may have a similar affect. This can also lead to connection issues. Please see the [Programs Which Interfere with Steam](https://help.steampowered.com/en/faqs/view/1F39-DCB4-FF28-5748) guide to test the issue.  
  
## Network Connectivity
Please follow these directions to make sure the correct ports are open and double check the list of ISP's that are known to have issues with Steam: [Troubleshooting Network Connectivity](https://help.steampowered.com/en/faqs/view/669A-2F68-D1D1-A5EC).  
  
## Connection Rate
Ensure that your Steam connection rate is set appropriately. For more information, please see [Setting Client Rates](https://help.steampowered.com/en/faqs/view/163C-7C89-406E-2F63).
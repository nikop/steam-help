# Secure connection failed, No Steam logon, or A connection to the VAC servers could not be made
Updated 2021-07-21 23.44.52  
Version 4  

I am trying to connect to a secure game server, but I received the error message 'SECURE CONNECTION FAILED'.  
  
## Common causes:
  

* [Connection Issues](#connection)
* [Security Software](#security)
* [Background Applications](#background)
* [Third-party Anti-Cheat Applications](#third)

This issue stems from four main sources: connection issues, security software, background applications and third-party anti-cheat applications.  
[](id=connection)  
## Connection Issues

* ## Firewalls and Routers
If your computer is behind a router with a firewall, you must open the ports that Steam uses to connect to the Internet. Most embedded firewalls require you to open ports manually (they do not automatically learn your used ports). Routers without firewalls rarely need to have ports opened for a game client, but usually do for game servers.  
  
If you can specify ports to open, please use the ports specified in the following article: [Required Ports for Steam](https://help.steampowered.com/en/faqs/view/2EA8-4D75-DA21-31EB)  
  
After making any changes to your router and firewall settings please **EXIT STEAM AND RESTART** before attempting to connect to a secure server.
* ## Router Problems
Routers can cause connectivity problems, especially Wireless routers. If you have a stand-alone router and you are having connection problems, you can always bypass the router and plug your computer directly into your modem to see if the router is the problem.  
  
If you determine that the router is the source of the issue, please follow the [Using a Router with Steam](https://help.steampowered.com/en/faqs/view/46D2-B5B1-F0B9-B867) guide.  
  
Dual WAN Routers are not compatible with Steam.
* ## Internet Connectivity Issues
Check the stability and reliability of your Internet connection. An unstable connection can cause Steam to download improperly and connections to game servers time out.  
  
There are many online tools that help you to check for problems with your connection, here are two of the most popular ones:  
  
[http://www.dslreports.com/tools](http://www.dslreports.com/tools)  
  
[http://www.speedguide.net/analyzer.php](http://www.speedguide.net/analyzer.php)  
  
If you suspect that you are having a problem related to your Internet Connection, please contact your Internet Service Provider (ISP).

  
[](id=security)## Security Software

* ## Security, Firewall, and Anti-Virus Software
If you're using Internet security, firewall or anti-virus software, make sure they are set to recognize Steam.exe and all instances of HL.exe and HL2.exe as trusted programs. Please consult your security program manuals for instructions.  
  
[h5]Problems Directly After a Steam Update[/h5]If you have a connection problem immediately after a Steam update, it is most likely being caused by a firewall.  
  
The best solution is to go to the firewall permissions and remove all references to Steam.exe, HL.exe and HL2.exe and let them be relearned again. Just because there are existing permissions does NOT mean they are correct permissions. Every time the Steam client is updated, your firewall permissions need to be reset.  
  
[h5]Multiple Firewalls[/h5]Never run more than one firewall program at a time while using Steam. They can conflict with each other and cause many different connection problems. Examples of running multiple firewalls include:  
  

* Running the Windows firewall with your router's firewall simultaneously
* Running the Windows firewall with Zone Alarm, Tiny Personal Firewall or some other third-party firewall application
* Running the Windows firewall with your motherboard's built-in firewall (mainly an issue with nForce motherboards)

  
After making any changes to your firewall, anti-virus or security software settings please **EXIT STEAM AND RESTART** before attempting to connect to a secure server. Once you have restarted you should be able to connect to VAC servers.
* ## PeerGuardian
PeerGuardian is not compatible with Steam. Please disable PeerGuardian before launching Steam to avoid connection issues.

  
[](id=background)## Background Applications

* ## P2P, FTP and Web Server Applications
Do not run Peer-to-Peer (P2P) programs like BitTorrent, Kazaa, eMule, LimeWire or Exeem in the background. These programs can consume large portions of your bandwidth. The same is true for FTP and Webserver applications such as Apache, MySQL servers and Microsoft's IIS services.  
  
After exiting your Peer to Peer software please **EXIT STEAM AND RESTART** before attempting to connect to a secure server. Once you have restarted you should be able to connect to VAC servers.
* ## Viruses, spyware and malware, netlimiting, anonymous IP masking programs
Connection problems can also arise if your system is infected with a virus or spyware. We strongly recommend running virus checks while you are not using Steam if you suspect there is a virus or trojan on your system. For more information, please follow the [Spyware, Malware, Adware, and Viruses Interfering with Steam](https://help.steampowered.com/en/faqs/view/70D4-67C8-784D-692A) topic.  
  
Programs like Cybersitter, Netlimiter, X-Fire and Steganos Anonymous Internet can also interfere with normal Steam operations. Please disable these programs before launching Steam.

  
[](id=third)  
## Third-party Anti-Cheat Applications
Using third-party anti-cheat applications, both server and client-side, is not necessary and may result in the errors outlined above. Do not use third-party anti-cheat applications while playing on a VAC secured server.
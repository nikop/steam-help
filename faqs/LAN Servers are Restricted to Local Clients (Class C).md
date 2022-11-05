# LAN Servers are Restricted to Local Clients (Class C)
Updated 2021-10-28 00:58:52  
Version 4  

### I get this error: *'LAN servers are restricted to local clients (class C)'* when I try to connect to a server or my friends get this error when they try to connect to my Server. What's wrong?
  
  
Game Servers can be LAN Servers or they can be Internet Servers.  
  
In order for Internet players to connect to your Server, you must enable your Server to be an Internet Server.  You do this by entering `sv_lan 0`in the Server console, in the **server.cfg** or in the **listenserver.cfg** file.  
  
Typically, only Listenservers (where the Server is also a Client) are LAN Servers by default.  
  
If you are behind the same router as the Server, then you must connect to your Server using the internal IP address of the Server and and not the external IP address.
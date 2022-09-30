# Configuring a Router for use with a Half-Life or Source Dedicated Server
Updated 2021-12-02 23.30.26

How do I configure my Router for use with my Half-Life or Source dedicated Server?  
  
#### Server Setup
Instructions on setting up a specific type of dedicated server can be found here:  

* [Setting up a Steam Source Dedicated Server](https://help.steampowered.com/en/faqs/view/0E82-09BC-324C-CB12)
* [Setting up a Steam Half-Life Dedicated Server](https://help.steampowered.com/en/faqs/view/081A-106F-B906-1A7A)

    
#### Setting up a Static IP Address
Your server should use a static IP address. This will allow other computers to reliably find your server when connecting to the router.  
  
The only way to get an external static IP is to pay for one through your internet service provider. A static IP is important if you plan on having your server run all of the time. Using a static IP makes it easy for return players to find your server.   
  
An internal IP address behaves just like an external IP address with the notable exception of only being visible from behind your router. You must use a static IP internally. Your router will forward ports for incoming connections to a specific IP address. If you have your IP setup dynamically, it will not necessarily forward the ports to your server.  
  
#### Setting Up a Static IP in Windows

* Press the **Windows Key + R** and type in: `cmd` to open a command prompt.
* Type into the command prompt: `ipconfig /all`  
You will see something similar to this:  
  
Windows IP Configuration  
  
Host Name . . . . . . . . . . . . : MYCOMP  
  
Primary Dns Suffix . . . . . . . :  
  
Node Type . . . . . . . . . . . . : Unknown  
  
IP Routing Enabled. . . . . . . . : No  
  
WINS Proxy Enabled. . . . . . . . : No  
  
Ethernet adapter Local Area Connection:  
  
Connection-specific DNS Suffix . :  
  
Description . . . . . . . . . . . : Realtek RTL8139/810x Family Fast Ethernet NIC  
  
Physical Address. . . . . . . . . : 00-80-F6-6A-21-E0  
  
Dhcp Enabled. . . . . . . . . . . : Yes  
  
IP Address. . . . . . . . . . . . : 192.168.1.100  
  
Subnet Mask . . . . . . . . . . . : 255.255.255.0  
  
Default Gateway . . . . . . . . . : 192.168.1.1  
  
DNS Servers . . . . . . . . . . . : 192.168.1.1  
  
  
NetBIOS over TCP/IP. . . . . . . . : Disabled
* Copy down: 
* IP address
* Subnet mask
* Default gateway
* DNS Servers
* Click on **Start > Settings (gear icon) > Network & Internet > Change Adapter Options**.
* Right-click on **Local Area Connection** you are using and go to **Properties**.
* Select **Internet Protocol Version 4 (TCP/IPv4)** and click on the **Properties** button.
* Select the "Use the following IP address" option and fill in the fields with the respective information you copied out of your IPConfig.
* Click **OK** and exit the network connection page.

  
Test your internet connection to ensure that you are still able to access the internet. If not, you probably mistyped one of the fields from the IPconfig. Double-check their values. If you need to get back to the internet immediately, you can do so by going back to your TCP/IPv4 properties and selecting **Obtain an IP address automatically**.  
  
#### Setting up the Router
Go to your router manufacturer's website and ensure that you are running the most current Firmware available for the router.   
  

* Follow the instructions that came with your router to login to it. Typically, this is done by going to either [192.168.0.1](http://192.168.0.1) or [192.168.1.1](http://192.168.1.1) and entering a username and password you have either already specified or can be found in your router's manual. The IP address and login information are different for different routers.
* Go to port range forwarding or the equivalent for your router and setup the port forwarding for port 27015. As each router manufacturer has their own software, you will want to follow the instructions they have provided in their manuals or support articles. If port 27015 does not work, try another port between 27016-27019 or 27021-27032.

  
  
#### Editing the server.cfg
Next, you must edit your server.cfg file to properly reflect your server's IP address.  

* Open your server.cfg. (Typically **C:\hlserver\valve\server.cfg**)
* Add to the top of the file:  
  
`IP < your IP address >  
  
port 27015` [section style=note] ### Note:
If you have a Dynamic IP, from time to time your external IP address will change, especially if you reboot or cycle the power on your modem.  
  
Each time this happens you must change the IP in your server.cfg to match your new external IP in order for your server to continue working properly.[/section]  
  
Note: When you start your server it will report your internal IP address, not your external IP address.  
  
To access the server from behind the same router, at the top of the Steam client select: **View** > **Servers** > **Favorites** and click on **Add a Server**.  
  
Enter your internal IP address and port setting in this format: `192.168.1.100:27015`  
  
Then you can connect to your server from your **Favorites** menu.

 [section style=important] ### Important:
If you have a server and a client behind the same router, the client cannot connect to the server through the server browser. In fact the server may not be visible in the server browser of the client.  
  
The client must connect to the server using the server's internal IP address.[/section]  
  

# Hosting a Local (Listen) Server for Valve Games
Updated 2021-08-12 17.36.59

I want to host a server on my computer to play with my friends over the Internet. What do I need to do to allow my friends to connect to me?  
  
In order for users outside your local network to connect to a server hosted on your computer, you must properly configure your network, security software, and the game so that connection requests can reach your computer.  
  
[section style=important] ### Important
You must have administrative access to your network hardware (e.g. router) and on the computer in order to make some of the required changes. If you are not the owner of the network or computer, you will need to contact your network or computer administrator to request these changes.[/section] #### Setting Up Your Connection
Some of the following steps may not apply to you, for example if you do not have a router and your computer is connected directly to your modem—if the step does not apply, skip the step and continue with the next one.  
  
You will need your public Internet IP address. This can be viewed quickly by visiting a site like [whatismyip.com](http://www.whatismyip.com/). This address identifies your connection to the Internet, similar to how a street address identifies your house.  
  

* **Configure your firewall**  
You will need to set your firewall to allow unsolicited incoming connections for the game you intend to host. If you are unsure how to do this, please refer to the manual or contact the support provider for your firewall software, or temporarily disable your firewall for the duration that you host the server.
* **Configure your router**  
Forward port **27015** on both TCP and UDP protocols. If you specify an alternate port when creating the server, forward that port *instead* of port **27015**.  
  
For guided instructions on forwarding a port for a large selection of home routers, please visit [portforward.com](http://www.portforward.com/) and select the router model you have, or that best matches the one you have. Select "Half-Life 2 Steam Server" when you reach the list of applications.
* **Start the game and create a local server**  
*NOTE: some of the following steps require that you enter commands into the console. If you require assistance with enabling and/or using the console, please see the* [*Console*](https://help.steampowered.com/en/faqs/view/4700-D10E-26BE-DDDD) *article.*  
  

* Open the game and click the menu option to create a local server (typically "**Create Server**") 
* **Note:**  **Left 4 Dead** and **Left 4 Dead 2** do not feature a menu option to create a local server. Instead, you need to use the [Console ](https://help.steampowered.com/en/faqs/view/4700-D10E-26BE-DDDD)for the game and enter the *map mapname* command, where **mapname** is the name of the map file you want to start on. To get a list of map files, type the *maps ** command.
* Configure the server as you prefer, then start the game.
* Type the following commands into your console:  
  

* *sv_lan 0*
* *ip [your IP address]* (replace **[your IP address]** with the public IP address you recorded initially, so you have a command that looks like *ip 255.255.255.255*)
* You may need to enter the *heartbeat* command after entering these commands in order to update your IP address with the Steam master servers. If people viewing your server still see **Server is not responding**, then please enter the *map mapname* command, where **mapname** is the name of the map file you want to start on. To get a list of map files, type the *maps ** command.

  
  
Once you have completed these steps, users should be able to join your currently running game. You will need to repeat the in-game steps if you exit the game.
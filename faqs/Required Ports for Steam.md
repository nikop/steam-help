# Required Ports for Steam

The following are ports you need to have open on your router or firewall for Steam to operate normally.  
  
  
[section style=section]  [h5]To log into Steam and download content:[/h5]
* HTTP (TCP remote port 80) and HTTPS (443)
* UDP remote port 27015-27050
* TCP remote port 27015-27050

 [/section]  
[section id=kb_ports]    	[section style=section]  		[h5]Steam Client[/h5]
* UDP remote port 27000-27100: Game traffic
* UDP local port 27031-27036: Remote Play
* TCP local port 27036: Remote Play
* UDP remote port 4380

 [/section]      	  		[h5]Dedicated or Listen Servers[/h5]
* TCP local port 27015 (default): SRCDS Rcon port
* UDP local port 27015 (default): gameplay traffic

 [/section]    	[section style=section]  		[h5]Steamworks P2P Networking and Steam Voice Chat[/h5]
* UDP remote port 3478
* UDP remote port 4379
* UDP remote port 4380
* UDP remote ports: 27014-27030

 [/section]        		[section style=important]### Note:
Many university and business networks and proxies block required ports for Steam operation - please consult your network administrator to ensure the required ports are open if you are using a university/business network or a proxy. **Ports required for Steam can not be re-mapped to HTTP or reconfigured to a custom port range.**[/section]        [section id=kb_advanced]#### Advanced
For generic Steam HTTP/HTTPS requests, your proxy should allow the following domains:  

* steampowered.com
* steamcommunity.com
* steamgames.com
* steamusercontent.com
* steamcontent.com
* steamstatic.com
* akamaihd.net

  
  
Most of the non-web traffic is usually UDP but can be TCP as well. For that, the IPs will all be from the Valve network (AS32590), and a list of those IP blocks can be found here:  

* [IPv4](http://bgp.he.net/AS32590#_prefixes)
* [IPv6](http://bgp.he.net/AS32590#_prefixes6)

 [/section]
# Peer-to-Peer Networking and Sharing Your IP Address

When is my IP Address shared with other players?  What are the downsides?  How can I control when this happens?  
  
[section id=intro][/section] #### What is Peer-to-Peer Networking?
Peer-to-peer networking is when messages are sent directly from one player to another.  Contrast this with dedicated server networking, where players do not talk to each other directly, but instead all players talk to a game server.  
  
#### Peer-to-Peer Connections Using Your Public IP Address
Most games that use peer-to-peer networking attempt to establish a direct connection between the players, meaning the players share their public IP addresses with each other, and communicate directly using those IP addresses.  Most players' computers connect to the Internet through a router, and the public IP address is the address of the router.  The router serves as a firewall, only allowing certain traffic from the outside world in to your computer.  In order for peer-to-peer networking to connect players using their public IP addresses, a process called NAT traversal is used to negotiate firewalls and obtain the IP addresses.  
  
#### What's the Risk of Sharing My Public IP Address?
If another player has your public IP address, they can send packets directly to you.  If they are friendly, this is great, because this is often the fastest path of communication.  But if a malicious user obtains your public IP address, they can flood your Internet connection with packets.  This is often called a DoS (denial of service) attack.  Many consumer Internet connections can be easily overwhelmed by a relatively low volume DoS attack.  
  
#### Peer-to-Peer Connections Using Relays
NAT traversal does not always succeed in establishing a direct connection, depending on the firewall configuration.  When this happens, the players require the assistance of a relay to talk to each other.  Each player's firewall will accept packets from the relay.  ([Here](https://tailscale.com/blog/how-nat-traversal-works/) is a good article that describes the process in detail.)  A benefit with using relays is it's not necessary to share you IP address with the other player.  Often, relays are used as a last resort, only if a direct connection cannot be made, since relaying packets is relatively costly service.  In this case, IP addresses have already been exchanged and a DoS attack is still possible, even though a direct connection was not possible.  If one or both peers chooses not to share their IP address, then a direct connection is not possible and NAT traversal will require the use of the relay.  In order for a direct connection to be made, both peers must share their IP address.  
  
#### How can I Prevent Games From Sharing My IP Address?
The only reliable way to prevent any game from sharing your IP address is to use a VPN.  In this situation, your public IP will be the address of the VPN provider's computer, and your IP will stay private.  
  
#### Does Steam Ever Share My IP Address?
Steam doesn't share your IP address with other players.  Whenever peer-to-peer networking is needed, for example in a voice chat, that communication is always relayed.  However, we don't control what games using peer-to-peer connectivity do.  
  
#### What about games that use Steam Networking APIs?
If a game uses our newest networking APIs (ISteamNetworkingSockets and ISteamNetworkingMessages), the traffic can be relayed using Steam Datagram Relay (SDR), Valve's worldwide backbone and network of relays, and you can decide when to allow an app to share your IP address.  Under Steam / Settings / In-Game / Steam Networking, there is an option that controls when your IP address is revealed:  
  

* **Never**.  Never share your IP with any player.  Always relay peer-to-peer traffic.
* **Always**.  Always allow the app to share your IP with any player.  If the other player also shares their IP address, a direct connection may be established.  If not, it will be relayed.
* **Default**.  This will not share your IP address, unless it appears necessary to avoid excessive ping times.
* **Friends Only**. Share your IP only with users in your Friends List.

  
  
We recommend that most players leave the setting on default.  If you experience high ping times and would prefer to risk sharing your IP address to attempt to get a faster connection, you might try changing the value to "Always".  Remember that just because you share your IP address does not mean a direct connection will be made.  The other player must share their IP address, and NAT traversal must succeed in negotiating the firewalls.  
  
Please note that the game may choose to force the use of a relay for certain connections, such as in a high-stakes competitive mode where DoS attacks are more likely.  
  
#### Steam's Peer-to-Peer Networking Goals
Steam is working towards a world where no one needs to share their IP address to have a good connection.  Unfortunately, we're not there yet.  Until then, we will try to hide IP addresses for as many players as possible while still delivering a good networking experience and giving players who care about their privacy a way to protect it.  
  

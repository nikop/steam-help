# Steam Local Network Game Transfers
Updated 2023-03-28 23:53:14  
Version 6  

Local network game transfers allow for Steam users to copy existing Steam game installation and update files from one PC to another over a local area network, without having to download and install from a Steam content server on the internet. This helps you stay below your ISP monthly transfer limits and can speed up installs or updates.  
  
A common use case would be a home setup with multiple PCs or Steam Decks on the same local network. Once a game is installed on one PC, all other PCs or the Steam Deck can install or update that game by transferring files directly from that one PC. A modern PC can easily transfer game content with 100MB/sec over a wired network connection. During the transfer the hosting Steam client sending content will generate disk and CPU load (ie, you probably wouldn't want to be doing any intensive tasks on this PC during the transfer).  
  
Active local network game transfers will be called out on the Download page:  
![{STEAM_CLAN_IMAGE}/39983882/0e303acc898999ce024c3954abe6af7ec9dd9671.png]({STEAM_CLAN_IMAGE}/39983882/0e303acc898999ce024c3954abe6af7ec9dd9671.png)  
  
This is how it looks from the recipient side:  
![{STEAM_CLAN_IMAGE}/39983882/650e5e745b11ea888335529b3c55851b20c10487.png]({STEAM_CLAN_IMAGE}/39983882/650e5e745b11ea888335529b3c55851b20c10487.png)  
    
# How it works
  
  
Before you start to download or update a game on Steam, Steam will first check if there are other PCs running Steam on your LAN (local area network) that could transfer the needed game content to you directly.   
  
If a potential PC is found, your client will ask the Steam backend server to contact that other PC’s Steam client and start a game file transfer if local network transfers are enabled and possible. If the game file transfer is accepted, your PC will try to download as much content as possible from the other PC. If the connection is lost or no more content is available, Steam will fall back to use public Steam content servers to download the remainder.  
  
  
# Settings
  
  
There are four settings to specify what other PCs + Steam clients can be used for game file transfer. These settings are bi-directional, and to allow local transfers in, local transfers out are automatically enabled. The default setting is "Only my own devices", meaning you can only transfer in and out of PCs where your own account is logged into Steam.  
  
* **Off** - this client will not look for or allow local game file transfers. It will not download from or transfer to any other PC connected to your LAN.
* **Only my own devices** - allow transfers to/from another device you are currently logged in with the same Steam account on your LAN (this is the default)
* **Only my friends** - allow transfers to/from devices your Steam friends are logged into, connected to your LAN
* **Any user** - allow transfers to/from any device that has Steam running and is connected to your LAN
  
  
# Requirements
  
  
Any Steam client or Steam Deck can receive game content from another client on their LAN, but there are a few conditions that have to be met before the local transfer can take place.   
  
*  Both Steam clients must be online and see each other directly on the same LAN (no downloads while either Steam client is in offline-mode)
*  Game File Transfer settings on both devices must allow a transfer (e.g. if both have "Friends only" set, they must be Steam friends)
*  Game content can only be transferred out if the transferring Steam client is idle, e.g. no downloads or games running.
*  The game needs to be released to the public and playable by both Steam users (no preloads)
*  The game needs to be up-to-date on the PC sending the game files
*  Only a PC running in Steam desktop mode can host a network transfer. Steam Decks, PCs in Big Picture mode, and custom launchers can't transfer their files out over the local network.
*  The network transfer happens on TCP port 24070 and it needs to be allowed by local firewall software.
  
  
  
# Privacy & Security
  
  
A few additional notes about how this feature works from a privacy and security standpoint:  
  
*  Only file content part of the original game is transferred, no local save games or configuration files are sent. It also excludes Steam Workshop, Steam Cloud or Steam Shader files.
*  If you set your Steam client to allow friends or any user, others users on your LAN can find out what games you have installed.
*  The transferred game content is compressed but not encrypted since all sent data is assumed public knowledge.
*  All data received from another Steam client is verified and must match the expected content. Any invalid or corrupt data is ignored will not be installed.
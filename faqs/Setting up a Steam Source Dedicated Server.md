# Setting up a Steam Source Dedicated Server
Updated 2021-12-02 22.55.41  
Version 9  

How do I set up a Source Dedicated Server?  
  
* [Setting up a Steam Dedicated Server Account](#account)
* [Starting the Steam Source Dedicated Server](#start)
* [Steam Source Dedicated Server Options](#options)
* [Steam Source Dedicated Server Configuration](#config)
* [Viewing Steam Dedicated Server Statistics](#stats)
* [Kicking or Banning Players from the Server](#kick)
* [Managing Steam Source Dedicated Server Bans](#manageban)
* [Steam Source Dedicated Server Console](#console)
  
  
#### Setting up a Steam Dedicated Server Account
To run the Steam Source Dedicated Server you will first need to install Steam. You may download and install Steam from: [Download Steam](http://steampowered.com/v/index.php?area=getsteamnow)  
  
After installing Steam, you must create a Steam account to run your dedicated server. This is separate from the Steam account you normally use to play games. If you attempt to run a dedicated server from your normal Steam account, you will not be able to join your server using the same account.  
  
  ### Note:
You do not need to register any games to your server account in order to host games.  
#### Starting the Steam Source Dedicated Server
(Counter-Strike: Source, Day of Defeat: Source, Half-Life 2:Deathmatch)  
  
![{STEAM_CLAN_IMAGE}/1976/f06626a6fac861ed7eeffc6b630549fdfc3328a1.jpg]({STEAM_CLAN_IMAGE}/1976/f06626a6fac861ed7eeffc6b630549fdfc3328a1.jpg)  
  
[h5]Menu Options[/h5]
* Game: The source game the server is for (example: Counter-Strike: Source, Half-Life 2: Deathmatch, Day of Defeat: Source).
* Server Name: This is the title of your server. By default it is the name of the game you are hosting.
* Map: This option is grayed out until you start the server.
* Network: Specify **Internet** or **LAN**. Select **Internet** if you wish for people to be able to join your game from another location.
* Max Players: Specifies the maximum number of people that can play on your server. **Range: 1-32**
* UDP Port: Specifies the port you would like your server to use. **Default: 27015**
* RCON Password: Set a password for remote access to the server.
* Secure (Valve Anti-Cheat) **Checked** : VAC enabled on the server **Unchecked** : VAC disabled on the server
After adjusting the server to your liking, press the **Start Server** button.  
  
#### Steam Source Dedicated Server Options
  
![{STEAM_CLAN_IMAGE}/1976/17dd8eaf66978360cfc8143ecb22bccb6ae06a59.jpg]({STEAM_CLAN_IMAGE}/1976/17dd8eaf66978360cfc8143ecb22bccb6ae06a59.jpg)  
  
You can change all of the following values without restarting the server (To edit a value, double-click on its name):  
* Server Name
* Map
* Network
* RCON Password
* Player Password: Specifies a password players must enter in order to play on your server. This is a good option to implement if you wish to play only with your friends.
* Map Cycle: Specifies the maps you wish to play and the order in which they appear. The maps will cycle according to either your **Map time limit** or **Max win** settings available from the **Configure** tab.
  
  
#### Steam Source Dedicated Server Configuration
  
![{STEAM_CLAN_IMAGE}/1976/db4e42c42351102a0ae3115061327d09df611f06.jpg]({STEAM_CLAN_IMAGE}/1976/db4e42c42351102a0ae3115061327d09df611f06.jpg)  
  
From the **Configure** tab, you may specify how your server runs and implement various server rules.  
  
[h5]Menu Settings[/h5]  
* Time limit: Specifies a time limit on each map. **Default** no limit
* Win limit(rounds): Specifies a limit on wins one team can have before a map change. **Default** no limit
* Round limit(rounds): Specifies a limit for the number of rounds you play on each map. **Default** no limit
* Time per round(minutes): Specifies the amount of time each round lasts. **Default** 5 minutes
* Freeze time(seconds): Specifies the amount of time before a round starts. **Default** 6 seconds
* Buy Time(minutes): Specifies the amount of time a buy zone is active. **Default** 1.5 minutes
* Starting Money: Specifies the amount of money each player starts with. **Default** $800
* Footsteps: Specifies whether players can hear footsteps of other players. **Default** enabled
* Death camera type: Specifies players’ Camera view after dying.  
Values:  
* Spectate Anyone: A player can watch any other player in the game.
* Spectate team only: A player can watch only his own team players in the game.
* Only First Person: A player can only move the camera to look in different locations while bound to where the player died. The player cannot follow other players, or move about the map freely.
* **Default** Spectate anyone
* Disable chase/death cam (fade to black): Death cam will fade to black. **Default** disabled
* Friendly fire: Players can injure players on their own team. **Default** disabled
* Kill Team killers round after TK: Specifies whether a player who kills a teammate will be killed at spawn time on the next round. **Default** disabled
* Kick idle and team killing (3TKs) players: Players who have not moved for a set amount of time will be kicked from the server, Players who have killed 3 or more teammates will be kicked from the server. **Default** enabled
* Kick players who team kill at this early in the round (seconds): Specifies the amount of time that the server will kick a player for killing a team member at the beginning of a round. **Default** 5
* Kick hostage killers (kills allowed, 0 is off): Specifies the number of hostages a player can kill before being kicked from the server. **Default** 13
* Allow Flashlight: Flashlight can be used by players. **Default** disabled
  
#### Viewing Steam Dedicated Server Statistics
  
![{STEAM_CLAN_IMAGE}/1976/280dee9ded38e7328f24750e0acc2c1a1e8c2769.jpg]({STEAM_CLAN_IMAGE}/1976/280dee9ded38e7328f24750e0acc2c1a1e8c2769.jpg)  
  
The Steam Dedicated Server offers a variety of viewable statistics. You can view statistics from the most recent minute, hour, or day. To add a stat to the view, check its box on the right-hand side of the dialog box.  
  
You can change the **Vertical Units** to display the range of any one of these stats.  
  
[h5]Display Options[/h5]Checkboxes:  
* Players Display player number statistics
* Ping Display server ping
* In Display ping in
* Out Display ping out
* CPU Display CPU usage
* FPS Display frames per second
  
  
#### Kicking or Banning Players from the Server
  
![{STEAM_CLAN_IMAGE}/1976/4e3ff76218bc9bcf4758b654d653234940a7ec06.jpg]({STEAM_CLAN_IMAGE}/1976/4e3ff76218bc9bcf4758b654d653234940a7ec06.jpg)  
  
The Players tab displays all players currently on your server. In addition to viewing players, you can also kick them from your server or ban them from your server.  
  
Kick Kicking a player will drop the player from your server. Ban You have the option to temporarily, or permanently ban players from your server. You can manually enter an IP address or use the players’ Steam ID to ban them from your server.   
  
#### Managing Steam Source Dedicated Server Bans
  
![{STEAM_CLAN_IMAGE}/1976/b9a9e232207edec721f7bca14778c3d93d0659c9.jpg]({STEAM_CLAN_IMAGE}/1976/b9a9e232207edec721f7bca14778c3d93d0659c9.jpg)  
  
The **Bans** tab allows you to manage those bans that are in place on your server. You can remove a ban or edit the ban’s time limit. To remove a ban, set the time value to `0.00 `by double clicking the ID you would like to unban. The ban will no longer be visible after the server is restarted.  
  
#### Steam Source Dedicated Server Console
  
![{STEAM_CLAN_IMAGE}/1976/29f54de38a88ba8c779a34d84090aa75848a0241.jpg]({STEAM_CLAN_IMAGE}/1976/29f54de38a88ba8c779a34d84090aa75848a0241.jpg)  
  
The console will print activity on the server, such as players joining or leaving the server, players being kicked, banned, etc…  
  
You can also enter server console commands:  
  
*addip (minutes) (IP)* Bans a player by IP address for a specified number of minutes. Entering 0 for minutes is a permanent ban.   
  
*banid (minutes) (SteamID)* Bans a player by SteamID for a specified number of minutes. Entering 0 for minutes is a permanent ban.   
  
*banid (minutes) (SteamID) kick* Bans a player by SteamID for a specified number of minutes and kicks them from the server. Entering 0 for minutes is a permanent ban.   
  
*changelevel (map)* Changes the server to the specified map. For a full list of maps, type: *maps* in the console.   
  
*dropclient (UserID)* Kicks a client by their UserID. To find a full list of UserID’s on the server, type: *users* in the console.   
  
*heartbeat* Manually sends a heartbeat to the master server.   
  
*info (SteamID)* Displays user information about the requested client based on SteamID.   
  
*kick (Player) or (UserID)* Kicks a user by Player name, or UserID. To find a full list of UserID’s on the server, type: *users* in the console.   
  
*listid* Lists all SteamIDs in your server ban list.   
  
*listip* Lists all IP addresses in your server ban list.   
  
*maps (partial name)* Lists all maps containing a partial name, for example: *maps de_* would list all maps with **de_** in their name.
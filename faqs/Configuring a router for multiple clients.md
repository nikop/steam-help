# Configuring a router for multiple clients
Updated 2021-08-10 23:04:24  
Version 7  

To configure multiple clients to play from behind the same router, you may need to change one of the clients to use a different clientport number.  

* Each machine must have a unique Steam account with different game licenses registered to the account.
* Each machine must have a different clientport setting.
* Each machine must have a unique Mac address.
* The router must be up-to-date.
* Your Firewall and router must have the [required ports for Steam open](https://help.steampowered.com/en/faqs/view/669A-2F68-D1D1-A5EC).

  
The default clientport is **27005** and you can only have one game with that port active on the same lan.  
  
  
# Specifying a Clientport as a Launch Option
  
To specify a client port, please perform the following steps for each computer on the LAN  

* Go to Steam's **Library** menu
* Right-click on the game you wish to play
* Go to **Properties...**
* From the **General** tab, under **Launch Options** you enter the launch option
* Add a different client port number on each machine between 27005 and 27032 in the following format:  
`+clientport 270XX`  
**Note:** Do not use 27020
* Leave the menu and launch the game

  
**NOTE:** This solution only works if you launch the game through the Steam client.  
  
If you have already set other launch options, leave a space between the last character of your previous launch option and the **+** of your clientport setting.  
  
  
# Specifying a Clientport in the userconfig.cfg
  
The benefit of this method is that the clientport will remain set whether you are launching the game from the **My games** menu or from a shortcut to the game.  

* Navigate to the folder that holds the **config.cfg** for your game  
**Example:** The config.cfg for Counter-Strike: Source can be found here:  
**..\Steam\steamapps\common\Counter-Strike Source\cstrike\cfg**
* If you have a **userconfig.cfg** in that directory, open it. If you do not already have a userconfig.cfg: 
* Right-click in the folder
* Go to: **New** > **Text Document**
* Rename the file `userconfig.cfg`
* Open the file with Notepad
* Type into the document `clientport 270XX` where **XX** are the last two digits of the clientport number. Acceptable values include 05 - 19 and 21 - 32
* Save your **userconfig.cfg**
* Launch your game
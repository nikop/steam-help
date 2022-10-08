# Moving a Steam Installation and Games
Updated 2021-10-27 22.55.30  
Version 10  

* [How do I change the default installation path for my games?](#default)
* [How do I move a game's installation folder?](#move)
* [How do I move my existing Steam Installation?](#exist)
  
#### How do I change the default installation path for my games?
Games are installed to the following folder by default:  
  
`C:\Program Files (x86)\Steam\steamapps\common`  
  
You can create an alternate location on any drive, which you can choose in the future when installing games.  
  
* Navigate to your Steam client 'Settings' menu.
* Select 'Steam Library Folders' from the 'Downloads' tab.![https://support.steampowered.com/images/faq/client/add_library1.jpg](https://support.steampowered.com/images/faq/client/add_library1.jpg)
* From here, you can view your default installation path, as well as creating a new path by selecting '+' button.![https://support.steampowered.com/images/faq/client/add_library2.jpg](https://support.steampowered.com/images/faq/client/add_library2.jpg)
* Once you have created the new path, all future installations can be installed there.
* You can click the '...' button and select 'Make Default' to set it as a default.
* If you wish to move existing games without having to uninstall them, please see the instructions below.
  
#### How do I move a game's installation folder?
To move a game's installation folder on your computer to a different location on that same computer you can use Steam's "Move install folder..." feature. To use this option do the following:  
* Make sure you have a different Steam Library folder created to move to (see the instructions in [how to add a Steam Library folder](#default) above)
* Go to your Steam Library
* Find the game in your Library you want to move
* Right click the game's title and select "Properties..."
* Select the "Local Files" tab and then select "Move install folder..."  
![{STEAM_CLAN_IMAGE}/1976/389503c9e4ebfeeaf15f4ae9ec7b5e3ba14eb36b.png]({STEAM_CLAN_IMAGE}/1976/389503c9e4ebfeeaf15f4ae9ec7b5e3ba14eb36b.png)
* From the drop down menu you can then select the Steam Library folder location you want to move the game's installation to.
  
#### How do I move my existing Steam Installation?
  ### Important:
Please ensure that you have your Steam login name and password before following this procedure. Also ensure that your account is linked to your current email address, so that you can reset your password if necessary.  
  
It is **not** recommended that you install Steam to an external hard drive, due to potential performance issues.    ### Warning:
It is **highly** recommended that you create a backup of your steamapps folder before attempting this process. If there is a problem in this process and you do not have a backup of your games or the steamapps folder, it will be necessary to reinstall the games individually. Please see the [Using the Steam Backup Feature](https://help.steampowered.com/en/faqs/view/4593-5CB7-DC3C-64F0) topic.  
  
The following instructions are a simple way to move your Steam installation along with your games:  
  
* Exit the Steam client application.
* Navigate to the Steam installation folder. The default installation location is: `C:\Program Files (x86)\Steam`
* Delete all of the files and folders except the *steamapps* and *userdata* folders and *steam.exe*
* Cut and paste the whole Steam folder to the new location, for example: `D:\Games\Steam\ `
* Launch Steam and log into your account.
  
  
Steam will briefly update and then you will be logged into your account. For installed games, [verify integrity of game files](https://help.steampowered.com/en/faqs/view/0C48-FCBD-DA71-93EB) and you will be ready to play. All future game content will be downloaded to the new folder (D:\Games\Steam\steamapps\ in this example)  
  
If you encounter any errors during the move process or when Steam is launched from the new location, it may be necessary to perform a more thorough process:  
  
* Exit the Steam client application.
* Navigate to the new Steam installation folder. Continuing from the last section's example, the new location would be: `D:\Games\Steam\ `
* Move the *steamapps* folder from the Steam installation folder to your desktop.
* Review the [Uninstalling Steam](https://help.steampowered.com/en/faqs/view/3C73-90F9-F600-0266) topic for instructions to uninstall Steam (this must be done to remove your old Steam installation settings from the Windows Registry).
* Review the [Installing Steam](https://help.steampowered.com/en/faqs/view/099E-F5D1-8780-4778) topic for instructions to re-install Steam to the desired location.
* Move the *steamapps* folder into the new Steam installation folder to copy downloaded game content, settings, and any saved games that might be stored there to the new location.  ### Important Note about Save Games
If you are moving your Steam installation to a new hard drive and want to keep game saves/profiles for third party games that are not saved on Steam Cloud most of these can be found in your Documents folder: C:\Users\*[Windows user name]*\Documents\My Games\. Moving this folder to the same location on your new hard drive will maintain your saves/profiles. If you do not find them in that location for the game you may have to reach out to developer/publisher of the game to determine where the save file location is. Each game developer is able to decide how and where to store save files.
* Start Steam and log in to your existing Steam account to confirm that the move was successful.
* For installed games, [verify integrity of game files](https://help.steampowered.com/en/faqs/view/0C48-FCBD-DA71-93EB) and you will be ready to play.
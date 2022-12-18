# Using the Steam Backup Feature
Updated 2021-08-10 17:11:35  
Version 6  

How do I use the Steam backup feature to save copies of my game files and restore my game files from backup copies?  
  
  ### Note:
Many games that use third party installers or downloaders will not work with Steam's backup feature. This includes many MMO style or third party free to play titles. Only games that completely download, install, and patch through Steam are compatible with this tool.    ### Important:
Backups for **Valve** created games will not include saved games, custom multiplayer maps or configuration files. To backup your entire installation (including custom content), ensure that copies of all custom files are in the following folders in the path: [exclude_realm=china]**C:\Program Files (x86)\Steam\steamapps\common\<game name>\**[/exclude_realm][exclude_realm=global]**C:\Program Files (x86)\SteamChina\steamapps\common\<game name>\**[/exclude_realm] :  
* **\cfg\** - Custom configurations and configuration scripts
* **\downloads\** - Custom content for multiplayer games
* **\maps\** - Custom maps which have been installed or downloaded during multiplayer games
* **\materials\** - Custom textures and skins
* **\SAVE\** - Single-player saved games
  
For **third party** created games; the location of game saves can vary by game as the location is determined by the game's developer. To find the location you can: check the game's Community forum on Steam to see if other users know it and have posted the information already, visit their website for specific file location information for their game, or reach out to the developer to ask.  
  
These files will need to be copied to the corresponding folders after restoring with the Steam backup feature.  
  
#### Backing up all of your games
It is recommended that you use the method outlined in [**Moving a Steam Installation**](https://help.steampowered.com/en/faqs/view/4BD4-4528-6B2E-8327) as this will save time and simplify the backup and restore process.  
  
#### Creating Backup Files
* Open your Steam Library
* Right click the game's title and select **Properties...**.
* From the **Local Files tab** select **Backup game files...**
* Check the boxes for games to backup at this time
* Click **Next >**
* Browse to the folder where you wish to create the backup files (the files will be stored in [exclude_realm=china]**c:\Program Files (x86)\Steam\Backups**[/exclude_realm][exclude_realm=global]**c:\Program Files (x86)\SteamChina\Backups**[/exclude_realm] by default) and click **Next >**
* Select the **Backup file name** and set the **File size** for the media you plan to use.
* Click **Next >** to begin the backup process.
* Once complete, choose **Open backup folder** to move or burn copies of the backup files
    ### Important:
We recommend testing the backup discs after their creation to ensure the integrity of the files for future reinstallation.  
  
#### Restoring from Backup Files
* Install Steam and **log in** to the correct Steam account (see [Installing Steam](https://help.steampowered.com/en/faqs/view/099E-F5D1-8780-4778) for further instructions)
* Launch Steam
* Click on "Steam" in the upper left corner of the Steam application
* Select "Backup and restore games..."
* Select "Restore a previous backup"
* Browse to the location of the game's backup files
* Continue through the Steam windows to install the necessary games.
    ### Important:
If the path to your Steam installation contains **special characters**, such as **C:\Steam安装路径\Steam**, the restore process may not complete successfully. If this issue occurs, you may need to re-install Steam to a location without special characters, such as **C:\Steam**.  
  
### Testing
To avoid problems in the future, make sure to test any backups that you create. If other applications interfere with the backup process or the backup process is interrupted, the backup may not be created successfully. Testing your backup will ensure that will not need to re-download the game at a later time.
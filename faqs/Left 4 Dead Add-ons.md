# Left 4 Dead Add-ons
Updated 2021-08-10 17.32.19

How can I utilize the Add-on system in Left 4 Dead?  
  
#### What are Left 4 Dead Add-ons?
Left 4 Dead uses an add-on system to allow user-created maps and other content to run in-game. Content authors can package their creations as a Valve Package File( .VPK file) and upload it to the web.  Steam users can then download the .VPK and install it to play online.  
  
#### Where do I get Add-ons?
When connecting to a lobby running user-created content, you will see a **DOWNLOAD ADD-ON** link.  This link will launch your web browser and allow you to install the new add-on.  
  
Additionally, add-ons are available for download on various websites.  
  
#### How do I install Add-ons?
Once the .VPK file is downloaded, simply double click it to begin automatically installing the files. It will copy itself to the appropriate Steam folder.  
  
If there is any issue with this process, you can manually install the add-on by moving or copying the .VPK to the Left 4 Dead Add-ons folder.  
  
This folder is typically located here:  
*C:\Program Files (x86)\Steam\steamapps\common\left 4 dead\left4dead\addons*  
  
#### I have two folders: "addons" and "add-ons". Which one should I use?
The correct one is "addons", without a hyphen. If you want, you may delete the hyphenated folder: "add-ons".  
  
#### How can I make my own Left 4 Dead Add-on?
The [Valve Developer Community](http://developer.valvesoftware.com/wiki/L4D_Campaign_Add-on_Tutorial) is the best place to start along with the game's [Modding/Mapping Help and Tips](https://steamcommunity.com/app/550/discussions/3/) discussion forum.  
  
#### I'm receiving an error when double clicking VPK files. 
The file association between .VPK files and addoninstaller.exe might not be functioning correctly.  
  
Browse to the following location within your Steam install folder:  
*\steam\steamapps\common\left 4 dead\bin\*  
  
Create a shortcut for addoninstaller.exe by right clicking on the file and choose **Create shortcut**.  
  
Then, right click on the shortcut and choose **Properties**.  
  
Change the target to include "/register" as in the following example:  
*"C:\Program Files (x86)\Steam\steamapps\common\left 4 dead\bin\addoninstaller.exe" /register*  
  
After clicking OK, double click on the shortcut to run it.  
  
Restart your computer re-test the issue.  
  

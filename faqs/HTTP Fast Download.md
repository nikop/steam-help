# HTTP Fast Download
Updated 2021-10-27 20.57.27  
Version 5  

How do I Get HTTP Fast Download working for my Server?  
  
Source supports the download of custom content (maps, skins, sounds, and so on) from a HTTP server (ie: webserver) when connecting, instead of downloading directly from the game server itself.  
  
HTTP downloading has three major benefits:  

* There is no impact on the game server when downloading custom content, as a completely separate HTTP content server does the transfer.
* Players will download custom content at their maximum transfer rate, resulting in much faster downloads.
* Players downloading custom content do not take up a player slot on the server while waiting.

  #### Server with Custom Content: User Experience
When a player connects to a server utilizing custom content, one of two things will occur:  

* If the server is not configured for HTTP download, the game server will use the normal **trickle** download mechanism.
* If the server is configured for HTTP downloading, the player will see an enhanced download dialog and much faster downloads. While this content is downloading, they are not connected to the game server. Once the download finishes, they are automatically reconnected to the game server and ready to play.

    ### Note:
If any of the custom content is not present on the HTTP content server or the case of the file name does not match then the player will disconnect from the HTTP and fall back and download any remaining content via trickle download from the server.  #### Configuring your server to use fast HTTP Downloading

* Make a list of all the custom files (bsp, wav, mdl, etc) used on your server.
* Put those files on a HTTP server (ie: webserver), keeping the folder layout intact.
* **Optional:** To display a **banner image** to players that download content, place a **340x56** pixel image in the **file (custom content directory)/gfx/banner.gif**.
* Set the *sv_downloadurl* cvar to **http://yourserver/custom_content_directory/**.  
  
**Example:**  
[expand style=details]Your server uses the non-standard map **de_generic**, which requires the following files:  
  

* C:\Program Files (x86)\Steam\steamapps\common\Counter-Strike\cstrike\maps\de_generic.map
* C:\Program Files (x86)\Steam\steamapps\common\Counter-Strike\cstrike\de_generic.wad
* C:\Program Files (x86)\Steam\steamapps\common\Counter-Strike\cstrike\sound\ambience\de_generic_a.wav
* C:\Program Files (x86)\Steam\steamapps\common\Counter-Strike\cstrike\sound\ambience\de_generic_b.wav
* C:\Program Files (x86)\Steam\steamapps\common\Counter-Strike\cstrike\sound\ambience\de_generic_c.wav

[/expand]  
You have web space (perhaps through your ISP) with the URL **http://www.turtlerockstudios.com/~matt** that you will use to host your custom content.
* Copy the files needed for **de_generic** to your webspace, placing them in a folder called **my_cstrike**; in your webspace top-level directory, keeping their directory layout intact.
* You now have the following files in your webspace:     [expand style=details] 
* http://www.turtlerockstudios.com/~matt/my_cstrike/maps/de_generic.map
* http://www.turtlerockstudios.com/~matt/my_cstrike/de_generic.wad
* http://www.turtlerockstudios.com/~matt/my_cstrike/sound/ambience/de_generic_a.wav
* http://www.turtlerockstudios.com/~matt/my_cstrike/sound/ambience/de_generic_b.wav
* http://www.turtlerockstudios.com/~matt/my_cstrike/sound/ambience/de_generic_c.wav

 [/expand]
* You now set the **sv_downloadurl** cvar on your game server to *http://www.turtlerockstudios.com/~matt/my_cstrike/*
* Players who then connect to your server will automatically download the map **de_generic** and its required files from your webspace when they connect, unless they already have it.

  
  
#### Technical Details

* The maximum length of the **sv_downloadurl** is 127 characters.
* A username and password can be specified for the HTTP server by embedding them in the **sv_downloadurl** like so:  
  
**http://username:password@www.somewhere.com/**
* If a connecting player has an existing file of the same name, it will not be overwritten. The download file will be skipped.
* Certain game-crtical and/or dangerous files cannot be downloaded (ie: *.exe, *.vbs, etc)

  
  
#### Summary
The command you enter into the server is:  
`sv_downloadurl "http://(your URL)/valve/"`  
use quotemarks on either side of the string and include the final "**/**".  
  
(valve = hldm, cstrike = counterstrike, etc.)  
  
Then you create folders for gfx/env, maps, overviews, sound, sprites and models and populate them with the respective resource and in the "valve" directory exactly the way you would populate your server normally, including the WAD files.  
  
If the client has ANY of the files already (including the WAD) it will not be overwritten, there is no way to do that, the client must delete the out of date or offending resource themself.  
  
  ### Note:
**You must make .res files for all the maps** and make sure all resource names listed (and placed at the http) are spelled exactly the same.  
  
If the bsp has all lower-case letters for the entity then the .res file must be all lower-case and the file name itself must be all lower-case.
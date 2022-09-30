# Intel Video Cards with Source games
Updated 2021-08-05 18.15.46

Whenever I try to play any recent Source games from Valve, I experience a crash or a hard freeze. I am using an Intel based video card. What can I do?  
  
#### Intel Compatibility Issue
If you are playing any Source games on a laptop or a system with an integrated Intel video card such as the 945 GM, chances are your video card has a compatibility issue with these games  
  
You may be able to run these games by using the following launch option:  
`+mat_bumpmap 0 +mat_picmip 2`  
  
If you're not sure how to set game launch options, please see [this guide](https://help.steampowered.com/en/faqs/view/7D01-D2DD-D75E-2955).  
  
If that doesn't seem to help, you can try using the following console command:  
`mat_max_worldmesh_vertices 1024`  
  
If you're not sure how to use console commands, please see [this guide](https://help.steampowered.com/en/faqs/view/4700-D10E-26BE-DDDD).  
  
If that command allows the game to run without crashing, then please add it to your game config files. Your config file is located in the steamapps folder, under the folder for the game you would like to play. For example:  
`C:\Program Files (x86)\Steam\steamapps\common\Team Fortress 2\tf\cfg`  
  
Please contact [Intel Support](https://www.intel.com/content/www/us/en/support.html) for more information.
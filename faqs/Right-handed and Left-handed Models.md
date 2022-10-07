# Right-handed and Left-handed Models
Updated 2021-08-12 20.57.25  
Version 4  

How do I switch my weapon from one hand to the other?  
  
#### Team Fortress 2
To switch to left-handed models in Team Fortress 2, please use this process: 
* Launch Team Fortress 2.
* Go to Options and then to the Multiplayer tab
* Click Advanced
* Check the box next to "Flip viewmodels"

  ####   
#### Gold Source games (Counter-Strike, Half-Life)
If you cannot switch your weapon to the right-hand, please go to your advanced video options and change the renderer to either **OpenGL** or **Direct3D**. The software renderer does not support right-handed models.  
  
You can select left or right-handed models by typing the following command into the [Console](https://help.steampowered.com/en/faqs/view/4700-D10E-26BE-DDDD):  
  

* To use your left-hand: `cl_righthand 0`
* To use your right-hand: `cl_righthand 1`

  
  
To permanently use left-handed models, you may create a **userconfig.cfg** file with the `cl_righthand 0` command. Please follow these instructions to create a userconfig.cfg file:  
  

* Locate the subfolder in your game folder that holds the **config.cfg** file  
  
For example, you can find the config.cfg file for Counter-Strike at [Steam installation directory]\steamapps\common\Counter-Strike\cstrike\config.cfg
* Create a new text file in that directory called **userconfig.cfg**
* Open the file with Notepad and enter `cl_righthand 1` (to use the right-handed model) or `cl_righthand 0` (to use the left-handed model)
* Save the file
* Launch the game to test the userconfig.cfg settings
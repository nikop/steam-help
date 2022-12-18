# Setting Game Launch Options
Updated 2021-08-24 20:05:54  
Version 6  

How can I set game launch options?  
  
Game launch options can be used to change game settings before running the game. Launch options allow the user to supersede internal settings of the game. This is an effective means to recover from incompatible video settings as well as troubleshooting a wide range of issues.  
  
This topic covers setting game launch options from Steam's **Library**. Launch options may also be set by creating a game shortcut and [Setting Steam Launch Options](https://help.steampowered.com/en/faqs/view/0188-6BB7-D467-08E1) for the shortcut.  
  
#### Set Launch Options
  
* Open your Steam Library
* Right click the game's title and select **Properties**.
* On the **General** tab you'll find **Launch Options** section.
* Enter the launch options you wish to apply (be sure to separate each code with a space).
* Close the game's **Properties** window and launch the game.
  
  
#### Common Launch Options
These launch options apply to GoldSrc and Source engine games only. They do not apply to most third party games.  
  
Please refer to [this list of Valve titles](https://store.steampowered.com/search/?category1=998&developer=Valve) for titles that support these launch options  
  
Many [Console Commands](http://developer.valvesoftware.com/wiki/Console_Command_List) can function as a launch option by adding a "+" in front of the console command, but some cannot be used in this fashion. The most common launch options are listed below.  
  
* -autoconfig - Restores video and performance settings to default for the current hardware detected. Ignores settings inside any .cfg files until this parameter is removed.
* -dev - Enables developer mode. Also disables the automatic loading of menu background maps and stops the quit dialog from appearing on exit.
* -condebug - Logs all console output into the console.log text file.
* -console - Starts the game with the developer console enabled.
* -toconsole - Starts the engine directly in the console, unless a map is specified with +map.
* -dxlevel [level] - Forces a specific DirectX version when launching the game. This is useful if your graphics hardware is older, and gets significantly better performance in an earlier version of DirectX. Below are the most common modes used:  
  
* -dxlevel 80
* -dxlevel 81
* -dxlevel 90
* -dxlevel 95
* -dxlevel 98   ### Warning:
Our games no longer support DirectX 7 as a launch option. Using this can cause crashes. If you are using -dxlevel 70 make sure to remove it from your launch options.
* -fullscreen - Forces the engine to start in fullscreen mode.
* -windowed or -sw - Forces the engine to start in windowed mode.
* -16bpp or -32bpp - Forces the selected color mode (bit depth). **GoldSource only**
* -w [width] - Forces the engine to start with resolution set to [width].
* -h [height] - Forces the engine to start with resolution set to [height]. This launch option does not need to be set in the presence of -w. The width value will determine the height automatically.
* -refresh [rate] - Force a specific refresh rate.
* -heapsize [kilobytes] - Specifies the heapsize (in kilobytes) which the game will use.
* -nocrashdialog - Suppresses some **memory could not be read** unhandled errors.
* -novid or -novideo - When loading a game with this parameter, the intro Valve video will not play.
* -lv - Enables some low violence options in Left 4 Dead.
* -sillygibs - Enables low violence for Team Fortress 2.
  #### Launch Options to Adjust Detail Levels and Graphic Rendering
* +r_rootlod # - Adjusts Model Detail where # is 0 for high, 1 is medium, and 2 for low
* +mat_picmip # - Adjusts Texture Detail where # is 0 for high, 1 is medium, and 2 for low
* +mat_reducefillrate # - Adjusts Shader Detail where # is 0 for high and 1 for low
* +r_waterforceexpensive # - Adjusts Water Detail where # is 0 for low and 1 for high
* +r_waterforcereflectentities # - Adjusts Water Reflectiveness where # is 0 for low and 1 for high
* +r_shadowrendertotexture # - Adjusts Shadow Detail where # is 0 for low and 1 for high
* +mat_colorcorrection # - Adjusts Color Correction where # is 0 for low and 1 for high
* Filtering Modes: 
* +mat_trilinear 0 - Use Bilinear Mode (least system-intensive)
* +mat_trilinear 1 - Use Trilinear Mode (more system-intensive)
* +mat_forceaniso # - Use Trilinear Mode (where # is 2, 4, 8, or 16 - higher levels of filtering require more system resources)
* +mat_hdr_level # - Adjusts High Dynamic Range lighting effects where # is 0 for "off" (requires least resources) and 2 for "full"
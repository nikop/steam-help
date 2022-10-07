# Surround Sound does not Function in Source Games
Updated 2021-07-10 19.49.55  
Version 2  

Source games rely on the operating system to identify the audio device for them. If your surround setup is not properly configured in Windows or is configured through a proprietary control panel, it may not be properly recognized by Source games.  
  

* Ensure that your audio device is setup appropriately in your Windows Control Panel.
* Launch the game and adjust your settings in the **Options > Audio** menu.

  
If the issue persists, close any proprietary audio control applications and repeat the process.  
  
You can also use one of the following launch options to test the issue:  
  
`+snd_legacy_surround 1`  
`+snd_digital_surround 1`
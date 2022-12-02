# Portal 2 Perpetual Testing Initiative
Updated 2021-12-17 18:31:37  
Version 6  

Are you having issues with your Portal 2 Puzzle? Read on for some steps to fix it!  
  
#### Do you have the Portal 2 Authoring Tools installed?
If so, verify your game cache files for Portal 2 by doing the following [here](https://help.steampowered.com/en/faqs/view/0C48-FCBD-DA71-93EB).  
  
#### Do you have too many items?
If you receive the error below, you created a puzzle with too many items. Please delete a few items and check that your puzzle rebuilds properly.  
  
![{STEAM_CLAN_IMAGE}/39983882/69f20b238877ba5cbd6ea46355898172e934b392.png]({STEAM_CLAN_IMAGE}/39983882/69f20b238877ba5cbd6ea46355898172e934b392.png)  
  
#### Build Error: There was an error building the puzzle
If you are having the following error message, you may have one of several issues listed below.  
  
![{STEAM_CLAN_IMAGE}/39983882/1320073a10d732a72e7a535c21cf2d6bbbf45c0f.jpg]({STEAM_CLAN_IMAGE}/39983882/1320073a10d732a72e7a535c21cf2d6bbbf45c0f.jpg)  
  
[h5]Incorrect Error Message on Mac[/h5]The game may incorrectly show Mac users the generic "Build Error" message, instead of the more specific "too many items" error message. To determine if this is happening, first enable the Developer Console (this is in the main menu, under *Options* and *Keyboard/Mouse*) and open it using the ~ (tilde) key at the top-left of your keyboard (this key will toggle the Developer Console open/closed). Once your puzzle has failed to build, look at the red text which appears in the Developer Console. If you have too many items in your puzzle, you will see some text like this:  
`VBSP: ERROR!  '-entity_limit' exceeded (**1924** out of 1750)`  
  
[h5]Huge Maps Error[/h5] Very large puzzles may fail to rebuild. If you can shrink your chamber slightly or split it into multiple parts and work on them as multiple separate puzzles (the Save As menu option will help with this) that should allow you to continue with your work until we fix the bug. Here is an example of a puzzle that had this issue:  
  
![{STEAM_CLAN_IMAGE}/39983882/aad09441830f3f1320fab24c66986faca6571fc7.jpg]({STEAM_CLAN_IMAGE}/39983882/aad09441830f3f1320fab24c66986faca6571fc7.jpg)  
  
[h5]Programs that interfere with building[/h5]If you are getting a build error message make sure that you aren't running any programs that interfere with Steam as listed [here](https://help.steampowered.com/en/faqs/view/1F39-DCB4-FF28-5748). Specifically, we have reports that running **Comodo** Anti-virus or **Threatfire** anti-virus will cause this to occur. Switching Comodo to "Game Mode" should correct the issue, as will temporarily disabling Threatfire.  
  
#### If all else fails...

* [Verify integrity of game files](https://help.steampowered.com/en/faqs/view/0C48-FCBD-DA71-93EB) for Portal 2.
* If the files were fixed on your machine, test your compile again.
* Find the error.p2c file in: `...Steam\steamapps\common\Portal 2\portal2\puzzles\[randomly generated number]\error.p2c`
* E-mail the file to puzzle_error@valvesoftware.com
# Using custom subtitles in Source games
Updated 2021-08-24 22:43:25  
Version 5  

How do I install custom subtitles for any Source game?  
  
## Compiled (.DAT) Files
If you already have a compiled *closecaption_<language>*.dat file, simply copy the file to the following location:  
  
***NOTE:*** *The \Steam\* folder is located in *C:\Program Files\* or *C:\Program Files (x86)\* by default.  
* *\Steam\steamapps\common\[game name]\[modname]\resource\*
  
For example, for Half-Life 2, the path would be:  
* *\Steam\steamapps\common\Half-Life 2\hl2\resource\*
  
Then, start the game and ensure closed captioning is enabled in the Options > Audio menu.  
  
To change to the custom language, open the [console](https://help.steampowered.com/en/faqs/view/4700-D10E-26BE-DDDD) and enter the following command:  
*  cc_lang *<language>*
  
Where *<language>* is the same as the language in the closed caption file name.  
  
## Uncompiled (.TXT) Files
Text files must be compiled before they will work with Source games. If you have a closecaption_*<language>*.txt file, then you will need to do the following to compile it:  
*  Install the [Source SDK](https://help.steampowered.com/en/faqs/view/1C0A-1DEA-CF8A-72F2) from the Tools section of the Steam Library.
*  Open the Source SDK launcher and ensure you have the correct game selected.
*  Navigate to the Source SDK *\bin\* folder:
* *\Steam\steamapps\common\\SourceSDK\bin\*
*  Determine which version of the Source engine the game uses, then open that folder. In most cases this will be *\orangebox\*
*  Open the *\bin\* subfolder of the engine folder. Inside this folder should be a program named *captioncompiler.exe*
*  Take your closecaption_*<language>*.txt file, then drag it onto the *captioncompiler.exe* program. A file called *closecaption_<language>*.dat should appear — this is your compiled caption file.
*  Follow the instructions under ***Compiled (.DAT) Files*** using this file.
  ## Creating Translations
If you would like to translate closed captions into your own language, please see the following Valve Developer Wiki article on this topic:  
  
[**Closed Captions**](http://developer.valvesoftware.com/wiki/Closed_Captions)
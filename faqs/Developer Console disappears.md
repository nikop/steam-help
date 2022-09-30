# Developer Console disappears
Updated 2021-10-27 21.35.30

Every time I bring down the developer console and start typing, the console disappears. How can I fix this?  
  
In many cases this problem is caused by the language setting of your operating system (OS). Users with non-English keyboard layouts are affected by this for the most part.  
  
For general information on the developer console see the page [developer console](https://help.steampowered.com/en/faqs/view/4700-D10E-26BE-DDDD).  
  
#### Fix 1:
Set your keyboard to 'English'. For detailed instructions, you will need to research your OS manufacturer's instructions specific to your OS version. These can often be found on by searching their support website.  
  
#### Fix 2:
Whenever you pop-up the console, simply press the A, E, I, O or U and hit (backspace). After that, you can enter your command.  
  
#### Fix 3:
Bind another key to the "toggleconsole" command. Not all keys will bind to console; avoid any normal typing characters or numbers.  
  
Function Keys work well for this (F1 - F12).  
  
You may need to edit your config.cfg or userconfig.cfg files to add the bind (use notepad).  
  
[h5]For example:[/h5]`bind "F12" "toggleconsole"`  
  
The usual default is:  
`bind "~" "toggleconsole"`  
  

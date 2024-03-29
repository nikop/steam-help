# Steam Deck Desktop: FAQ
Updated 2022-03-02 23:43:46  
Version 6  

Steam Deck is designed to be a complete Steam gaming experience out of the box – players can browse, download and play games from Steam, text or voice-chat their friends with Steam Chat, get game and system updates, adjust Steam Deck settings and more all within the default Deck user experience. That said, Steam Deck is a PC and you can easily get to the desktop and do even more. Here are answers to a few common questions we’ve received about using the desktop on Steam Deck.  
  
#### How do I get to the desktop?
  
  
From the STEAM menu, select Power, then Switch to Desktop  
  
#### How do I get back to Deck UI from the desktop?
  
  
On the desktop, there's a link to 'Return to Gaming Mode'. Select that to get back to standard Steam Deck UI. You can also go through the system menus to Log Off to get back.  
  
#### Can I use the desktop without a keyboard and mouse?
  
  
You can use the trackpad as a mouse. Clicking the right trackpad is primary click, clicking left trackpad is secondary click. While Steam is running, if you press STEAM + X, you can bring up an on-screen keyboard. We are still working on improving this, and you may find yourself in situations where you’ll need to plug in a physical keyboard and mouse.   
  
#### Do the Steam Deck controls work in Desktop mode?
  
  
Yes, if you're running Steam, apps and games in SteamOS desktop mode have access to the inputs on Steam Deck.  
  
#### How do I install apps?
  
  
Currently, this is a stock KDE Plasma experience in terms of installing software. You can use the Discover Software Center (on the taskbar) to install apps. The Discover Software Center installs applications using flatpak technology (more on this below) onto the writeable portion of your drive. If you know your way around a Linux command line you can directly use flatpak commands to install applications. Common browsers, music players, and other kinds of applications are already available via these methods, and we expect that many more will be updated, fixed, and available after launch.  
  
#### What is flatpak?
  
  
Flatpak is a software deployment and package management utility for Linux. We like it because it offers a way to install and run applications on Steam Deck on the writable part of the disk, with all the rest of your games and content – ensuring it won’t be broken by future Steam Deck system updates.  
  
#### What if I want to do more than what’s available by flatpak?
  
  
Totally fine, though it comes with several caveats. Make sure you know what you’re doing and be careful about running random commands / scripts you find on the internet - you may get your Steam Deck into a bad state or compromise your data. In addition, anything you install outside of flatpak (via pacman for instance) may be wiped with the next SteamOS update.  
  
With that out of the way, if you are going outside flatpak and need to edit the read-only image, you can enable that with the following command:   
  
`sudo steamos-readonly disable`  
See below for instructions on using sudo with Steam Deck. One more warning to complete the warning sandwich – don’t do the above unless you know what you’re doing.  
  
#### How do I run sudo commands?
  
  
The default  deck user is shipped with no password. This is a secure setting that prevents access via ssh, and can't be used to run commands via **sudo**.   
  
If you’d like to set a password in order to run sudo commands, open a terminal window and set a  secure password using the **passwd** command. At that point you will be able to use **sudo** anywhere elevation is required.  
  
#### I messed up my Steam Deck and it’s acting weird now. How to I get back to a good state?
  
  
You can find recovery instructions for Steam Deck at [this article](https://help.steampowered.com/faqs/view/1B71-EDF2-EB6D-2BB3).  
  
#### Can I run apps I install on the desktop in Deck mode?
  
  
Yes you can. On the desktop, go to the Steam client, and click the “add a game” button in the lower left corner, click ‘add a Non-Steam game’, then find the application you installed in the list. This app will now show up in the Deck UI library under the ‘non-steam’ tab.  
  
#### Can I run desktop apps at the same time as Steam games in Deck mode?
  
  
Yep! When running a game or app, just hit the steam button and go to your Home / Library to launch another application. It will show up in the left-hand menu, which you can use to switch back and forth. This is great for listening to music, chatting with friends, or playing an idle game while you’re playing a game.
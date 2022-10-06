# Sound Troubleshooting
Updated 2021-10-28 00.08.55

Sounds are not being played or are being played on only one speaker when I play Source games - what should I do?  
  
#### Disable Onboard Sound Card
If you have installed a sound card on a system which has already has an onboard sound card built in to the motherboard you will want to uninstall the onboard sound card drivers and disable the onboard sound card to ensure it does not interfere with sound playback if you want to use your sound card instead of the onboard sound. How to do this will vary by operating system so you will want to research on the internet how to do so.  
  
#### Update Sound Card Drivers
See your sound card manufacturer's support page for more information on available updates.  
  
#### Remove USB sound devices
If sound issues persist after you have disabled your onboard sound card and updated your sound card drivers, please check your system for any USB-enabled audio devices which may be causing interference. (This includes any USB headphones, microphones, or other audio playback or recording devices)  
  
#### Windows Users

* Launch the game and type the following into your [console](https://help.steampowered.com/en/faqs/view/4700-D10E-26BE-DDDD): `snd_legacy_surround 1`.
* Check the Windows Volume Mixer to ensure that the individual game has not been muted. If your Volume Mixer is not display in the System Tray, right-click the Taskbar, click Properties, and ensure that the Volume checkbox is marked.

  
#### Surround Sound not working in Source games
  
Please see the article [Surround Sound does not Function in Source Games](https://help.steampowered.com/en/faqs/view/3DBF-E1FB-ECBF-C448) for further instructions.
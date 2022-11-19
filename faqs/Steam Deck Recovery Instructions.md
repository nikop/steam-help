# Steam Deck Recovery Instructions
Updated 2022-06-27 21:11:58  
Version 7  

These are instructions to recover, repair, or re-image your Steam Deck. You might need to do this if you are unable to boot, have installed another OS and would like to get back to standard Deck SteamOS, or are experiencing other breaking issues.  
  
For all the tinkerers out there, please note that this system image is not quite SteamOS 3 yet. Depending on what you try to install it on (desktop, another handheld, refrigerator, toaster), it may not work properly. SteamOS 3 proper will come out sometime after launch (and even then it may not work on your toaster).  
  
  
## Steam Deck Recovery Instructions
  

*  Download the recovery image [here (click)](https://store.steampowered.com/steamos/download/?ver=steamdeck).
*  Prepare a USB key (8GB minimum) with the recovery image:  

*  On **Windows** we recommend using the [Rufus utility](https://rufus.ie/en/). Select the recovery file and write it to your USB drive (this will format the contents of your USB drive). When it's done, select 'Close' and eject the drive.
*  On **MacOS** you can use [Balena Etcher](https://www.balena.io/etcher/) to write the recovery file to your USB drive.
*  On **Linux** you can also use [Balena Etcher](https://www.balena.io/etcher/) to write the recovery file to your USB drive - or if you prefer you can do this directly from the command line:  
`bzcat steamdeck-recovery-4.img.bz2 | dd if=/dev/stdin of=/dev/sdX oflag=sync status=progress bs=128M` (set /dev/sdX to the USB device you inserted)
*  Use a USB-C adapter or hub to plug the boot disk in.
*  Shut down your Steam Deck if it isn't already off. Hold 'Volume Down' and click the Power Button - when you hear the chime, let go of the Volume Down button, and you'll be booted into the Boot Manager.
*  In the Boot Manager, boot from the 'EFI USB Device' (your USB key)
*  The screen will go dark while it's booting - give it a minute.
*  Once booted you will be in a desktop environment, you can navigate using the trackpad and trigger.

  
## Recovery options
  
In the recovery environment, there are four different options to choose from.  

* **Re-image Steam Deck** - This performs a full factory reset - all user info, installed games, applications, or operating systems will be wiped and replaced with stock SteamOS.
* **Clear local user data** - This reformats the home partitions on your Steam Deck, which will remove downloaded games and all personal content stored on this Deck, including system configuration.
* **Reinstall Steam OS** - This will reinstall SteamOS on the Steam Deck, while attempting to preserve your games and personal content.
* **Recovery tools** - This opens a prompt with the ability to make changes to the Steam Deck boot partition.
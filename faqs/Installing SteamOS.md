# Installing SteamOS
Updated 2021-08-10 16:39:18  
Version 4  

### What are the hardware requirements for SteamOS?
* Intel or AMD 64-bit capable processor
* 4GB or more memory
* 500GB or larger disk
* NVIDIA, AMD (RADEON 8500 and later), or Intel graphics card
* UEFI boot support
* USB port for installation
    
### How do I install SteamOS?
  
  
  ### Warning:
Both of the following methods will erase everything on the target machine. Please ensure you are prepared to remove all content before proceeding.  
Currently, there are two different install methods for SteamOS.   
  
### Method 1:
The easiest method is an image-based install using CloneZilla. You will need to create a SteamOS System Restore USB stick to perform this install. The image provided here requires at least a 1TB disk.  
  
* Format a 4GB or larger USB stick. Use SYSRESTORE as the partition name
* Unzip the contents of SYSRESTORE.zip to this USB stick to create the System Restore USB stick
* Put the System Restore USB stick in your target machine. Boot your machine and tell the BIOS to boot off the stick. (usually something like F8, F11 or F12 will bring up the BIOS boot menu).
* Make sure you select the UEFI entry, it may look something like UEFI: Patriot Memory PMAP
* Select Restore Entire Disk from the GRUB menu.
* System Restore will proceed automatically. When it is complete it will reboot into your freshly re-imaged SteamOS
  
  
### Method 2:
The second method is based on the Debian Installer. It requires multiple configuration steps:  
  
* Unzip the SteamOSInstaller.zip file to a blank, FAT32-formatted USB stick.
* Put the USB stick in your target machine. Boot your machine and tell the BIOS to boot off the stick. (usually something like F8, F11, or F12 will bring up the BIOS boot menu).
* Make sure you select the UEFI entry, it may look something like UEFI: Patriot Memory PMAP
* Pick Automated Install from the next menu.
* The rest of the installation is unattended and will repartition the drive and install SteamOS.
* After installation is complete, log onto the resulting system (using the Gnome session) with the predefined Steam account. The password is steam. Run steam, accept the EULA, and let it bootstrap. Logoff the Steam account
* Log on with the desktop account. The password is desktop
* From a terminal window, run ~/post_logon.sh. This will prompt for a password - enter desktop. This script will perform the post-install customizations, delete itself, then reboot into the recovery partition capture utility.
* Confirm y to continue and the recovery partition will be created. When it is finished, reboot into your freshly installed SteamOS
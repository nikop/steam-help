# Disconnected by VAC: You cannot play on secure servers
Updated 2021-08-12 19.49.00  
Version 6  

Modifying game files and/or in-game textures may cause this error.  
  
Please remove any custom textures, skin changers, or software that modifies game files and restart your computer. We also recommend [ verifying your game files](https://help.steampowered.com/en/faqs/view/0C48-FCBD-DA71-93EB) after making these changes.    
## Frequently asked questions:
  
* [What does this error mean?](#explanation)
* [What typically causes this error?](#software)
    
## How can I fix this error?
  
* [Restart your computer](#restart)
* [Repair the Steam Service](#repair)
* [Restore boot settings to default](#default)
* [Repair system files](#files)
  
## What does this error mean?
  
This error is caused by third party software interfering with your game or Steam. To resolve the issue, you'll need to disable or remove the problem software from your machine.  
  
## What typically causes this error?
  
There are a number of common software conflicts that can cause this error. If you are running any of the following software, please disable it while playing:  
* CCleaner
* Powershell
* Cheat Engine
* IObit Start Menu 8
* DLL Injectors
* Hypervisors
* Steam Idlers
  
## Restart your computer
  
If the error persists on all servers it may be resolved by exiting Steam and restarting your computer.  
## Repair the Steam Service
The error may also indicate a Steam service failure. Please try repairing the Steam service:  
* Exit Steam.
* Click Start > Run (Windows Key + R).
* Type the following command: **"C:\Program Files (x86)\Steam\bin\SteamService.exe" /repair**
* Launch Steam and test the issue again.
**Note:** This command requires administrator privileges and may take a few minutes. If you have installed Steam to another path, please replace **C:\Program Files (x86)\Steam** with the correct path.  
## Restore boot settings to default
**Note:** If you are running Windows 8 or later you will need to open the "Command Prompt" as administrator.    
Kernel integrity checks, kernel debugging, and Data Execution Prevention (DEP) must be set to default to play on VAC secured servers. If you receive the following error when entering any of the commands below, that means they are already set to default:  
* *The value is protected by Secure Boot policy and cannot be modified or deleted.*
To change boot settings to default please follow the steps below:  
* Exit Steam.
* Search for the Command Prompt application in Windows and right-click it and select *Run as administrator*.
* In the command prompt, type the following commands and press Enter after each command:  
* bcdedit /deletevalue nointegritychecks
* bcdedit /deletevalue loadoptions
* bcdedit /debug off
* bcdedit /deletevalue nx
* Restart your computer.
* Launch Steam and test the issue again.
      
## Repair system files
**Note:** If you are running Windows 8 you will need to press Windows Key + X and select Command Prompt (Admin).  
There may be corrupt system files that are causing this issue. The following instructions will run a critical system file check on your Windows installation, replacing any missing or damaged files:  
* Exit Steam.
* Search for the Command Prompt application in Windows and right-click it and select *Run as administrator*.
* In the command prompt, type the following command and press Enter:
* sfc /scannow
Once the operation has completed please restart your computer, then launch Steam and test the issue again.
# This game is currently unavailable
Updated 2021-10-28 00.18.13  
Version 10  

I see the error "**This game is currently unavailable"** when launching a game through Steam.  What can I do?  
  
# Windows Troubleshooting Steps
  
After each step, please re-test the issue:  
*  Exit and restart Steam
* [Update All Drivers](https://help.steampowered.com/en/faqs/view/5799-495F-1F25-D15B)
*  Exit Steam and delete everything under the Steam installation directory except **steam.exe** and the **steamapps** folder - this will force Steam to update when you log in
*  Complete the [Verify Integrity of Game Files](https://help.steampowered.com/en/faqs/view/0C48-FCBD-DA71-93EB) process to repair your game cache files.
* This error may be caused by having certain Steam files set to Read Only.  To resolve this:   
*  Exit Steam.
*  Navigate to the directory where you have installed Steam.
*  Right-click on the Steam folder and select **Properties**.
*  Click the **General** tab.
*  Check the **Read-Only** checkbox and press **Apply**.
*  Uncheck the **Read-Only** checkbox and press **Apply**.
*  If this issue is only happening on a third party non-Valve game, please try launching the game's .exe directly from its installation folder: **C:\Program Files (x86)\Steam\SteamApps\Common\<Game Title>**.  You may also try other .exe's such as Launcher.exe in the game folder to see if a different error message is found.
*  If the issue persists, it may be caused by a network configuration issue.  Please complete the [Troubleshooting Network Connectivity](https://help.steampowered.com/en/faqs/view/669A-2F68-D1D1-A5EC) guide to further assess the problem.
  
  
  
# Data Execution Prevention
    
* Go to **Start > Control Panel > System > Advanced system settings > Settings in the Performance section > Data Execution Prevention tab**.
* Select "*Turn on DEP for all programs and services except those I select:*".
* Select "*Add*", navigate to C:\Program Files (x86)\Steam (or your default Steam directory), and add steam.exe to the exception list.
* Additionally, you will want to add any .exe's for the game you are seeing issues with.  These files will be in **Steam\steamapps\common\<Game Title>**.
  
[exclude_realm=china]  
# macOS Troubleshooting Steps
  
After each step, please re-test the issue.  
* Exit Steam.
* Make sure your Mac is [fully updated](https://help.steampowered.com/en/faqs/view/6073-E74C-A033-48A4).
* Delete everything except steamapps under the Steam installation directory, **~/Users/[username]/Library/Application Support/Steam**, this will force Steam to update when you log in.
* Complete the [Verify Integrity of Game Files](https://help.steampowered.com/en/faqs/view/0C48-FCBD-DA71-93EB) process to repair your game cache files.
* If the issue persists, it may be caused by a network configuration issue.  Please complete the [Troubleshooting Network Connectivity](https://help.steampowered.com/en/faqs/view/669A-2F68-D1D1-A5EC) guide to further assess the problem.
  
[/exclude_realm]  
# Secondary Installers
  
Many Steam games include installers for features and services required by the game. These include installers for DirectX, PhysX, Games for Windows Live, C++ components, or Windows updates required by the game.  
  
Steam is designed to run these installers when the game is first launched. If an installer is canceled by a user or prevented from running by another application on your system, the game may not launch correctly.  If this occurs, these installers will need to be launched manually.  
  
These installers are found in the game's installation folder, or a subfolder, found in the following location by default: **C:\Program Files (x86)\Steam\steamapps\common\<Game Title>\**.  
  
Note: Your installation path may differ from the above location.
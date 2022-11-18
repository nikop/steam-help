# Setting Steam Launch Options
Updated 2021-08-04 17:44:31  
Version 5  

How do I set Steam launch options?  
  
  # Warning:
To ensure the security of your account, do not use the -login launch option on shared computers or any machines which may be accessed by other users.  
Steam launch options can be used to change game settings, enable features, and even create a shortcut to bypass the Steam login window.  
  
Please see the [Setting Game Launch Options](https://help.steampowered.com/en/faqs/view/7D01-D2DD-D75E-2955) topic if you would like information on using launch options for specific games.  
  
## Set Steam Launch Options
* Navigate to your Steam installation (by default this is located at C:\Program Files (x86)\Steam)
* Right-click on steam.exe (this file is listed as an application and features the black and white Steam logo) and select **Create Shortcut**
* Right-click on the new shortcut and go to **Properties**
* Select the **Shortcut** tab
* In the **Target:** field add the launch options which you would like to use after the steam.exe location (make sure to separate all launch options with a space - For example, " -launchoption1 -launchoption2")
* Click **Apply** and then **OK** to close the Properties window
  
  
## Options to Use
Here are some of the more useful launch options:  
* -login      - Bypass the Steam login window by entering your login information
* -tcp - Launches Steam with the TCP protocol rather than the UDP protocol
* -clearbeta - If you have opted into a Steam client public beta, opts out and returns Steam to the current official release.
* -silent - Launches Steam to the system tray only. Normal Steam windows will only appear after clicking the system tray icon. If a password is not stored, the normal login window will still be displayed.
  
Please be sure to take adequate precautions to ensure that no one else has access to view your password when it is saved in a shortcut.  
  
## Example
Log in automatically:  
`"C:\Program Files (x86)\Steam\steam.exe" -login username password`
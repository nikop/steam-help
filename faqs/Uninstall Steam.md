# Uninstall Steam
Updated 2021-08-16 19.57.14

How should I uninstall Steam?  
  
[section style=important] ### Important:
This process will remove Steam and any installed game content from your machine. If reinstalling Steam and Steam games in the near future, please move the steamapps folder (C:\Program Files (x86)\Steam\steamapps) outside of the Steam directory to prevent your games from being deleted.  Additionally, [backups](https://help.steampowered.com/en/faqs/view/4593-5CB7-DC3C-64F0) of all game content can be created for reinstallation.[/section]   
[section style=warning] ### Warning:
The uninstallation process deletes the folder Steam was installed to to ensure it is fully uninstalled. If you accidentally installed Steam to a folder containing other data, for example **C:\Program Files (x86)\** instead of **C:\Program Files (x86)\Steam\**    
  
**STOP!** Do not run the uninstaller and instead carefully follow the instructions below for Manually Removing Steam, except only delete Steam-related files in step 3.[/section]  
Please observe the following procedure to uninstall Steam and any game content from your machine:  
  
**Note:** The following instructions are for Windows 10. For older versions of Windows please see Microsoft's support site for instructions on how to remove an application for your specific version.  

* Exit Steam
* To keep game installations, move the steamapps folder out of C:\Program Files (x86)\Steam
* Click the Windows **Start** button and select the **gear icon** for the **Settings**
* Select **Apps** from the Settings window
* Search and click the **Steam** entry from the list and then click the **Uninstall** button that appears
* Select the **Automatic** option and click **Next**
* Click **Finish** to uninstall Steam

  
  
If the normal process to uninstall Steam does not work, you may have inadvertently damaged your Steam installation. To uninstall Steam, you may first be required to re-install Steam to repair the installation before it may be removed.  
  
The latest Steam installer can be found on the [Get Steam Now](https://store.steampowered.com/about/) page.  
  
If all of the above options fail to assist you in uninstalling Steam, you can still remove your Steam files and registry entries manually.  
  
[section style=important]For Mac OS uninstall instructions, please see the [Removing and Reinstalling Steam on a Mac](https://help.steampowered.com/en/faqs/view/30EB-87BF-531F-512D) page.[/section]  
  
#### Manually Removing Steam
[section style=warning] ### Warning:
Dealing with your registry requires extreme care. Do not delete anything in your Windows registry that you are unsure about. For this reason, we suggest you only use this option as a last resort.[/section] 
* Exit Steam.
* Navigate to your Steam directory. (Typically **C:\Program Files (x86)\Steam**) 
* If you wish to save your game files for a future installation of Steam, copy your **steamapps** folder outside of your Steam directory.
* Delete all of the contents of your Steam directory.
* Go to **Start** > **Windows System** folder > **Run** (or press the Windows key + 'r') and type in `regedit`
* Click the **OK** button. This will open your registry editor
* **For 32-bit operating systems:**  
In the left-hand column of your registry editor, navigate to: `HKEY_LOCAL_MACHINE\SOFTWARE\Valve\`Right-click on **Steam** and select **Delete**.  
  
**For 64-bit operating systems:**  
In the left-hand column of your registry editor, navigate to: `HKEY_LOCAL_MACHINE\SOFTWARE\Wow6432Node\Valve\` Right-click on **Steam** and select **Delete**.
* In the left-hand column of your registry editor, navigate to: `HKEY_CURRENT_USER\Software\Valve\`
* Right-click on **Steam** and select **Delete**.
* Right-click on **SteamService** and select **Delete**.
* Close your Registry Editor.
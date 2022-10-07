# Manually Updating the Steam Link
Updated 2022-07-14 00.25.27  
Version 7  

![https://support.steampowered.com/images/faq/steam_link/SteamLink_Support_Header01.png](https://support.steampowered.com/images/faq/steam_link/SteamLink_Support_Header01.png)  
  
# Updating the Steam Link
Need to update your Steam Link or load a specific build on it? Click on the scenario that best describes your setup for detailed instructions.  
  
[expand type=title title="Loading Specific Steam Link Builds"]  
You may need to load specific Steam Link builds to better troubleshoot issues. To do this, follow the steps below:  

* From the Steam Link’s base page, check your system settings to ensure that you are using ***build 449 or newer.*** If your Steam Link is not using this build, you may need to switch to click the ***Switch to Public Build*** button from the Steam Link System Setting Page.
* If you are still unable to update to the required build version, please try updating after performing a factory reset.
* Determine [which build](https://help.steampowered.com/en/faqs/view/600B-953F-F577-762D) you would like to load. Create a text file called ***update_branch.txt*** containing the number of the build you wish to use. Place this file on a USB drive using the file path ***/steamlink/config/system/update_branch.txt***
* Insert the USB drive into the Steam Link
* Unplug your Steam Link, wait 3 seconds, then plug it back in
* The correct build will automatically be downloaded and installed
* After the update, navigate to the System Settings page to ensure that both the Release and Build version have been updated.

  
## Additional Notes
If you do not see the correct build number after performing this process please do the following:  

* Check to make sure the file on your USB drive does not have a hidden extension (update_branch.txt.txt)
* Try another USB drive

[/expand][expand type=title title="Manually Updating the Steam Link"]  
If your Steam Link is not connected to the internet, you can update it manually using the steps for setup and installation below:  

* [Download](https://media.steampowered.com/steamlink/06_2015/SystemUpdate.zip) the installation file for the current Steam Link Build. **- SystemUpdate.zip**
* Using a USB drive, create a folder called **steamlink** in the root directory, or top-level. When you open the drive, you should see the steamlink folder
* Move the **SystemUpdate.zip** file you just downloaded into the steamlink folder. Your file path should look like **/steamlink/SystemUpdate.zip**
* In the steamlink folder, create a new folder called **config**
* Open the config folder and create a new folder called **system**
* Inside the system folder, create an empty text file (.txt) called **update_branch.** Your file path should be **/steamlink/config/system/update_branch.txt**
* Follow the **Installation** steps below to update the Steam Link to the latest build

[/expand][expand type=title title="Loading Builds while Link is not Connected to the Internet"]  
If you would like to load a specific Steam Link build while the Link is not connected to the internet, please follow the steps below:  

* Determine [which build](https://help.steampowered.com/en/faqs/view/600B-953F-F577-762D) you would like to load. Create a text file called **update_branch.txt**, open the file, and type in the number of the build you wish to use.
* Place this file on a USB drive using the file path **/steamlink/config/system/update_branch.txt**
* Copy this URL into a web browser and replace the **‘XXX’** with the desired build number
* https://media.steampowered.com/steamlink/06_2015/SystemUpdate_full_XXX.zip
* Press **Enter** and download the .zip file to the **/steamlink/** folder you just created on the USB drive
* Edit the file name to **SystemUpdate.zip**

  
The file paths should look like this:  

* **/steamlink/SystemUpdate.zip**
* **/steamlink/config/system/update_branch.txt**

    
## Installation
  

* Power on the Steam Link, connect to your local network, and verify that you can navigate to the Settings > System menu
* Use a wired Ethernet connection if possible
* Remove all input devices except a mouse and keyboard
* Remove the power cord and wait 3 seconds
* Insert the prepared USB drive into the port closest to the power cord
* Power on the Steam Link by plugging the cord back in
* The update should start after a longer than usual delay on the splash screen

After the update finishes, test the build by navigating to **System > Settings.**  
  
## Additional Notes
If the update does not start automatically:  

* Verify that the Steam Link was connected to your local area network before attempting to update.
* Check to make sure the file on your USB drive does not have a hidden extension (update_branch.txt.txt)
* Perform a quick format on the USB drive (using default values) and repeat the steps in the Setup section

[/expand]
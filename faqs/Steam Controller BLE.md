# Steam Controller BLE
Updated 2021-07-26 21:59:50  
Version 4  

![https://support.steampowered.com/images/faq/steam_controller/SteamController_Support_Header01.png](https://support.steampowered.com/images/faq/steam_controller/SteamController_Support_Header01.png)  
  
# Bluetooth Low Energy Firmware FAQ
You can now add Bluetooth Low Energy (BLE) functionality to your Steam Controller. This feature is required to enjoy the [Steam Link app](https://store.steampowered.com/steamlink/about), but may provide benefit in other use cases as well. This FAQ describes what this BLE connection can and cannot do compared to the original wireless solution, steps to update your controller to add BLE support, and how to switch between wireless modes once the update is installed.  
  
* ### [When to use Bluetooth?](#use)
* ### [How do I install this Firmware?](#how)
* ### [How do I switch modes?](#switch)
* ### [Troubleshooting](#recover)
  
  
 #### When is it a good idea to use Bluetooth?
You'll want to use BLE mode when:  
* Streaming games to your iOS and Android devices with the Steam Link app.
* Connecting your Steam Controller to a tablet or laptop without a USB port.
* You just can't find your Steam Controller Wireless Receiver.
  
Otherwise we suggesting sticking with the original protocol. It provides the fastest connection, with low-latency support for up to four controllers per receiver, and works across all major operating systems. The BLE connection is excellent, but the native wireless protocol was designed from the ground up to provide the best experience for a Steam Controller.  #### How do I install this firmware?
Be aware that the original wireless mode will still be available after adding Bluetooth support. However, the update process will clear all pairings, so you will need to reconnect your wireless receiver to your controller. The steps below guide you through the update and pairing process.  
  
* [Opt into the latest Steam Client Beta](https://help.steampowered.com/en/faqs/view/276C-85A0-C531-AFA3)
* Plug in your Steam Controller.
* [Click here to start the firmware update flow](steam://UpdateFirmware), or follow the directions below
* Navigate to the Controller Settings page, find the Steam Controller you would like to update in the Detect Controllers list, and select the **Bluetooth FW** button.
* ![https://support.steampowered.com/images/faq/steam_link/_0000_1---landing.png](https://support.steampowered.com/images/faq/steam_link/_0000_1---landing.png)
* Click **Start** and be patient. The update may take several minutes. Interrupting the process is a bad idea.
* ![https://support.steampowered.com/images/faq/steam_link/_0001_2---start.png](https://support.steampowered.com/images/faq/steam_link/_0001_2---start.png)
* Once the firmware is installed, select **Learn More** on the dialog - you will be taken to this knowledgebase article to learn more about the new firmware.
* ![https://support.steampowered.com/images/faq/steam_link/_0003_4---success.png](https://support.steampowered.com/images/faq/steam_link/_0003_4---success.png)
* When you’re ready to move on, exit the page and return to Controller settings.
* Unplug your controller.
* Select the **Add a Steam Controller** button on the Controller Settings page. This option only appears if a Wireless Receiver is currently plugged in.
* Press **X + Steam Button** on your controller and **enter the 4 character Validation Code** that appears on the screen.
  
  
Congrats! You have reconnected your controller to the Wireless Receiver. Next, connect over BLE by navigating to the **Add Bluetooth** option of your device. When prompted, press **Y + Steam Button** on your Steam Controller to make it discoverable.   #### How do I switch between modes?
If you have already followed the instructions above, you are paired via the Steam Controller Wireless Receiver and BLE. Use the commands below to start your controller in the mode of your choice.  
  
[tr]  		[td]![https://support.steampowered.com/images/faq/steam_link/y_steam.png](https://support.steampowered.com/images/faq/steam_link/y_steam.png) [/td]	  			  		[td]### Bluetooth LE Pairing Mode
You’ll need to do this in order to use the Steam Link app  
  
[/td]	  	[/tr]		  	  	[tr]  		[td]![https://support.steampowered.com/images/faq/steam_link/b_steam.png](https://support.steampowered.com/images/faq/steam_link/b_steam.png) [/td]	  			  		[td]### Switch to Bluetooth LE mode
Launches controller in BLE mode  
  
[/td]	  	[/tr]			  				  		[tr]  		[td]![https://support.steampowered.com/images/faq/steam_link/x_steam.png](https://support.steampowered.com/images/faq/steam_link/x_steam.png) [/td]	  			  		[td]### Receiver Pairing Mode
Pair your controller to a new receiver  
  
[/td]	  	[/tr]		  	  [tr]  		[td]![https://support.steampowered.com/images/faq/steam_link/a_steam.png](https://support.steampowered.com/images/faq/steam_link/a_steam.png) [/td]	  			  		[td]### Switch to dongle mode
Use your controller in Original Receiver Mode  
  
[/td]	  [/tr]  
  
### Pairing to Multiple Devices
The Steam Controller BLE firmware can store two Bluetooth connections. Connect to the most recently used Bluetooth device by pressing **Steam+B**. Connect to the second stored Bluetooth connection by pressing **Steam+Start.**  
  
The firmware can also store multiple wireless receiver connections. Connect to the most recently used wireless receiver by pressing **Steam+A**. Connect to a different stored wireless receiver by pressing **Steam+Back.**  
  
Powering up with the Steam button only will connect you to the most recently used device and pairing mode  
  
### **Supported Operating Systems**
Bluetooth connectivity is supported in:  
  
* Windows 10
* macOS
* Ubuntu
* SteamOS
    
  
 #### Troubleshooting
If something isn't working quite right, you can revert back to the previous firmware. Navigate to the same spot in the Controller Settings page where you found the **Bluetooth FW** button. Now you will see a **Rollback FW** button in its place. Click that, wait a few minutes, and you should be running the previous version.  
  
A more detailed version of this process is as follows:  
  
* Plug in your Steam Controller.
* Navigate to the Controller Settings page. The **Bluetooth FW** button now appears as a **Rollback FW** button. Click it.
* ![https://support.steampowered.com/images/faq/steam_link/_0004_5---rollback-landing.png](https://support.steampowered.com/images/faq/steam_link/_0004_5---rollback-landing.png)
* Click **Start** to initiate the process.
* ![https://support.steampowered.com/images/faq/steam_link/_0005_6---rollback-dialog.png](https://support.steampowered.com/images/faq/steam_link/_0005_6---rollback-dialog.png)
* Again, be patient.
* ![https://support.steampowered.com/images/faq/steam_link/_0006_7---rollback-in-progress.png](https://support.steampowered.com/images/faq/steam_link/_0006_7---rollback-in-progress.png)
* Click **Done**
* ![https://support.steampowered.com/images/faq/steam_link/_0007_8---rollback-success.png](https://support.steampowered.com/images/faq/steam_link/_0007_8---rollback-success.png)
* Reconnect your Wireless Receiver by following steps 8-10 in the section above. You have successfully restored the firmware.
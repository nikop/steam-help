# USBDeview
Updated 2021-08-10 19.10.20

![https://support.steampowered.com/images/faq/steam_universe/Hardware_SteamLogo_Banner.png](https://support.steampowered.com/images/faq/steam_universe/Hardware_SteamLogo_Banner.png)  
  
    
  
 # USBDeview
[USBDeview](http://www.nirsoft.net/utils/usb_devices_view.html) is a tool that removes old USB device records from Windows. Removing these records can help with corrupt or incorrectly installed USB drivers.  
  
Please note: USBDeview is a third-party application. This app was not developed by Valve and we cannot provide support for it. Please do not attempt these steps unless you have exhausted our other troubleshooting options.  
  
Get started:  
  

* Download [USBDeview](http://www.nirsoft.net/utils/usb_devices_view.html) and unzip the archive
* Unplug the HMD from your Link Box and PC. Make sure your controllers are not connected via USB
* Launch USBDeview
* From the Options menu, turn on "Display disconnected devices"
* Sort the list by the VendorID column
* Find the items marked VendorID 28de and OBB4 then select them all
* Right-click and select "Uninstall selected devices." If prompted, say "yes" to each dialog box
* Reboot your PC and reconnect the Vive hardware. Wait for Windows to install the devices—this may take a few minutes
* Run SteamVR and make sure HMD is recognized in VR Monitor
* Turn on your controllers. Wait for Windows to install the devices, then make sure the VR Monitor shows them
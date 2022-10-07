# Steam Deck - Windows Resources
Updated 2022-06-17 00.08.24  
Version 10  

#### Windows Resources
  
Steam Deck is a PC, and other applications and OSes can be installed. If you're installing Windows, you will need a few additional drivers to have the best experience. Links to these, along with notes for installing Windows on Steam Deck can be found below.  
  
We are providing these resources as is and are unfortunately unable to offer 'Windows on Deck' support. If you get stuck and need a way back to the default Steam Deck OS, please follow [these recovery instructions](https://help.steampowered.com/en/faqs/view/1B71-EDF2-EB6D-2BB3).  
  

---
  
#### Windows Drivers
  

* **APU driver** - [download here](https://steamdeck-packages.steamos.cloud/misc/windows/drivers/APU_220520a-377788E-2206021014.zip), run setup.exe to install.  

*  *This driver is updated as of June 16, 2022.*
* **Wi-Fi driver** - [download here](https://steamdeck-packages.steamos.cloud/misc/windows/drivers/RTLWlanE_WindowsDriver_2024.0.10.137_Drv_3.00.0039_Win11.L.zip), run install.bat to install.
* **Bluetooth driver** - [download here](https://steamdeck-packages.steamos.cloud/misc/windows/drivers/RTBlueR_FilterDriver_1041.3005_1201.2021_new_L.zip), run installdriver.cmd to install.
* **SD Card reader driver** - [download here](https://steamdeck-packages.steamos.cloud/misc/windows/drivers/BayHub_SD_STOR_installV3.4.01.89_W10W11_logoed_20220228.zip), run setup.exe to install.
* **Audio drivers**    

* [Download driver 1/2](https://steamdeck-packages.steamos.cloud/misc/windows/drivers/cs35l41_062022.zip), right click **cs35l41.inf** and select Install. *(last updated June 13, 2022)*
* [Download driver 2/2](https://steamdeck-packages.steamos.cloud/misc/windows/drivers/NAU88L21_x64_1.0.6.0_WHQL%20-%20DUA_BIQ_WHQL.zip), right click **NAU88L21.inf** and select Install.
*  These INF files will show up as 'Setup Information' type files in File Explorer.
*  On Windows 11, right click and select 'Show More Options' to see the 'Install' option.
*  Don't forget to get the updated APU driver above for audio support.

  

---
  
#### Dual-Boot with SteamOS not yet available
  

* Installing Windows requires you to wipe your Steam Deck, and dual-boot with SteamOS is not currently available.
* While Steam Deck is fully capable of dual-boot, the SteamOS installer that provides a dual-boot wizard isn't ready yet. This will ship alongside SteamOS 3 once it's complete.

  

---
  
#### Notes for installing Windows
  

* To get to the boot menu, power down. Then, while holding Volume Down, press the power button.
* Installation will be in portrait orientation (sideways) on the Steam Deck screen. You can switch this to landscape once Windows is installed.
* To enter your product key during installation, you'll need internet. Because there are no Wi-Fi drivers at this point, you'll need a USB-C hub with an Ethernet port for internet.
* Both Windows 10 and Windows 11 are supported. For Windows 11, make sure you have the latest OS update (in order to get the latest BIOS with fTPM support) before installing.
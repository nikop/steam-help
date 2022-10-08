# SteamVR Developers
Updated 2021-09-21 23.59.38  
Version 7  

![https://support.steampowered.com/images/faq/steam_vr/vive_install/SteamVR_Support_Header_Main.png](https://support.steampowered.com/images/faq/steam_vr/vive_install/SteamVR_Support_Header_Main.png)  # SteamVR Developers
Are you a developer with questions about VR development on the Steam Platform? Click one of the links or scroll down for answers to some of the most commonly asked questions:  
  
* [Distribute your product on Steam](#distribute)
* [Access the OpenVR SDK](#sdk)
* [Join the developer conversation](#conversation)
* [Share your VR project with others for feedback](#share)
* [How do I get my game to show up as Rift of or Vive compatible in the Steam store?](#compat)
* [Where can I define my title’s VR-specific settings?](#settings)
  
  
 #### Distribute your product on Steam
To share your VR experience on Steam, you’ll need to first enroll as a Steamworks developer. To kick off that process, please [create your partner profile](https://partner.steamgames.com) and gain access to our SDK.  
  
You can then use [Steam Direct]("http://steamcommunity.com/games/593110/announcements/detail/1265922321514182595") to purchase an appID* and prepare your title for launch on the Steam Store.  
  
***The $100 appID purchase fee is recoupable**  
  
 #### Access the OpenVR SDK
[Use the OpenVR SDK](https://github.com/ValveSoftware/openvr/wiki/API-Documentation) to target SteamVR. The OpenVR SDK provides greater integration to the SteamVR platform and its tools for the HTC Vive, Oculus Rift, and other OpenVR headsets. In addition, you can [use the Steamworks SDK](https://partner.steamgames.com/?goto=%2Fhome%2Fsteamworks) to integrate Steam features such as matchmaking, Steam wallet, achievements and many other Steam features.  
  
 #### Join developer conversations
Grab your headset and [join the SteamVR Developer Hardware discussions](https://steamcommunity.com/app/358720/discussions/).  
  
Once you’ve joined us as a Steamworks developer, [join the Steamworks Development discussions](http://steamcommunity.com/groups/steamworks/discussions) to talk shop about Steam distribution and the Steamworks SDK.  
  
 #### Share your VR project with others for feedback
As a Steamworks developer, you can also [make Steam keys to share your content](https://partner.steamgames.com/documentation/keys) with other developers via the Steamworks partner site.  
  
In addition, our team would love to check out what you are working on! [Email us](mailto:steamvrbiz@valvesoftware.com) your Steamworks AppID with any other necessary build information and we’ll have a look and provide feedback.  
  
 #### How do I get my game to show up as Rift or Vive compatible in the Steam store?
To configure an app with VR support, go to your app landing page and select **Edit Steamworks Settings** then navigate to the **Installation tab** and then select **General Installation**.  
  
You will need to change your **Launch Options** to one of the three types below:  
* **Launch SteamVR App** - Use this for VR apps that use SteamVR.
* **Launch SteamVR Overlay** - Use this for apps that supply a SteamVR dashboard overlay.
* **Launch in Other VR** - Use this for apps that provide a VR mode other than SteamVR, for example those implemented using the Oculus SDK.
  
Picking one of these three options will either present the launch option to the user or it will be applied automatically at the appropriate times when the user launches the app from their Library.  
 #### Where can I define my title’s VR-specific settings?
Please read our documentation page [Application Settings for Virtual Reality](https://partner.steamgames.com/doc/features/steamvr/settings) for more information.
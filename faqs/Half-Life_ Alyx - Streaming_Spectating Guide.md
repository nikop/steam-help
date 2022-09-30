# Half-Life: Alyx - Streaming/Spectating Guide
Updated 2021-08-17 18.01.44

![https://support.steampowered.com/steamvr/Alyx/AlyxBanner.png](https://support.steampowered.com/steamvr/Alyx/AlyxBanner.png)    
  
# Streaming and Spectating Guide
The best way to experience Half-Life: Alyx is to play it yourself. But we know that watching someone play a game in VR is an entertaining experience on its own, and many of you will want to share the game with others — whether in the same room or over a livestream. Half-Life: Alyx has a number of settings dedicated to improving the experience of watching the game being played on a TV or monitor. They can be found in the game's menu under **Options > Spectator.**  
  
![https://support.steampowered.com/images/faq/steam_vr/spectator.png](https://support.steampowered.com/images/faq/steam_vr/spectator.png)#### Spectator HUD: Off, Small, Medium, Large
  
  
Choose whether to enable the spectator-specific HUD, and its relative size. Half-Life: Alyx comes with a HUD just for the people watching on the secondary monitor. It shows the player's health, ammo, resin count, and what items they're carrying. We've found this makes watching someone play Half-Life: Alyx more comprehensible and fun, because it ensures spectators have full view of information about the player's state, which in some circumstances may otherwise only be visible to the player. For example, players often check their health by raising their hand a little bit and looking down with their eyes instead of raising their hand up to their face or looking directly down at it. If you're watching on a monitor you wouldn't see that health check because it's so far out of view.  
  
#### Spectator Camera Smoothing: Off, Low, Medium, High
  
  
Choose how much you'd like to smooth out or remove the rotational jitter that come from playing a game in VR. Enabling smoothing makes the experience of spectating the game far cleaner. It is a realtime effect that is only applied to the spectator view (not inside the headset) and has minimal to no impact on graphical performance. We recommend setting it to low or medium, but if you find you prefer how the spectator view looks with no camera roll at all, you can set it to high. Try the different settings and see what you prefer.  
  
#### Spectator Eye: Left, Right
  
  
Choose whether the spectator view displays the output from your left or right eye. We recommend setting it to whichever eye you usually aim down, so people watching you play will be able to look down weapon sights with you.  
  
# Spectator Subtitles
As an alternative to the in-game subtitles designed for VR players, you may find it useful to enable subtitles in the Spectator Window only. In this case, the subtitles will be displayed only in the Spectator Window and not in the VR view.  The toggle for this setting can be found in the game's menu under **Options > Subtitles.**  
  
![https://support.steampowered.com/images/faq/steam_vr/spectatorsubtitle.png](https://support.steampowered.com/images/faq/steam_vr/spectatorsubtitle.png)  
  
# Advanced Settings
There are some advanced tools available for more specialized purposes. You might find these useful if you want to capture a series of short and specific shots for a video, or if you want to fine-tune the way the HUD appears in a stream. Accessing these settings requires enabling the development console (go to Half-Life: Alyx's game properties in Steam, and add **-console -vconsole** to the Launch Options). For a typical playthrough, you won't need to adjust these settings at all.  
  
#### Full In-Camera Smoothing
  
  
Full in-camera smoothing is a combination of effects applied to all three axes of camera rotation, to create a very cinematic look for your VR camera. This tool is perfect for capturing small moments that you want to look just right — but because it lags the game camera inside your headset, it can be disorienting and is not meant to be used while playing normally. This is the tool we used to capture most of the Half-Life: Alyx gameplay videos we released. While it is uncomfortable to play the game in this mode, it is great for capturing footage that *feels* like it does when you're playing normally. (Note that this tool is different to Spectator Camera Smoothing, which filters out roll rotation only as a post-processing effect, and has no impact on what you see in the headset.)  
  
To enable full in-camera smoothing, press the tilde key **(~)** to open the developer console, and type **vr_camera_decay_roll_halflife 0.5**, then **vr_camera_decay_yaw_pitch_halflife 0.09**. Those are the values we used for our gameplay videos, but you are free to tune them however you'd like. Using these values, for example, your camera roll will take 0.5 seconds to get halfway between the currently-displayed amount of camera roll and your actual head position, and the yaw and pitch will take 0.09 seconds to do the same. The higher the values, the more fine rotation you will filter out, and the laggier your vision will become in the headset.  
  
To disable in-camera smoothing, set both **vr_camera_decay_roll_halflife 0** and **vr_camera_decay_yaw_pitch_halflife 0**.  
  
#### Fine Tune Spectator HUD Size
  
  
If you would prefer a different spectator HUD size than the default options, you can fine-tune the size in the developer console. Press the tilde key **(~)** to open the console and type **hlvr_spectator_hud_size 100** to set the HUD to its default size of Medium. Instead of 100, you can use any value between 50 and 150. Use a value of 0 to hide the spectator HUD entirely.  
  
If you are having issues with tracking stability or other VR issues, check out the [SteamVR base station and tracking articles.](https://help.steampowered.com/en/faqs/view/1AF1-670B-FF5C-3323)
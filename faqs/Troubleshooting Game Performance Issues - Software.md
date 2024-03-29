# Troubleshooting Game Performance Issues - Software
Updated 2022-02-24 18:33:09  
Version 7  

### How can I improve my game's FPS and reduce choppiness and lag while playing?
 Poor or reduced FPS can be caused by any number of factors, all of which are hard to diagnose without physically looking at your machine. Due to the number of unique hardware and software configurations, it's nearly impossible to provide detailed analysis and recommendations for each user.  
  
The information in this article is written as a general guide for improving a game's performance. If the information does not help, we recommend reaching out to a local PC technician or online discussions for help with improving your individual machine's performance.  
# Check the game's system requirements
  
The system requirements for all games are listed on the game's Store page. Simply meeting the system requirements does not mean you'll have high FPS or strong in-game performance. If your system does not meet the game's requirements, you may need to upgrade to the appropriate hardware. Upgrading your video card and memory can have an immediate effect on gameplay performance.  
  
As games update, new features may be added along with improvements to graphical fidelity and sound. This may cause games to no longer run as well as they used to on older hardware. In these situations, we can only recommend modifying your video settings or upgrading your hardware for improved performance.   
  
  
# Manage your system's resources
  
The amount of memory available (RAM) for model loading and graphics rendering has a direct effect on the rate at which frames are displayed in games, and whether or not lag is apparent while playing.  
  
Below are some instructions to reduce the hard drive read times for loading game levels and content, prevent video display conflicts, and increase the available processor time and memory for games on your system. We have ordered these from most to least effective for increasing or maintaining your FPS:  
* ## Disable background applications
 Running fewer processes in the background while playing a game may have an immediate impact on in-game performance. If you're noticing poor performance, we recommend removing unnecessary startup programs and manually stopping any unnecessary applications through your task manager (in Windows: CTRL+Shift+Esc, on a Mac: Command+Option+Esc).
* ## Free up memory
 Be sure to have plenty of available RAM when running games. When a machine has insufficient RAM for game resources you will experience disk swapping, which will have a noticeable effect on FPS. Model detail, water detail, HDR, and other video options enabled or increased will require a significantly greater amount of RAM to maintain a high FPS rate.
* ## Video card software
 Any video card software for forcing particular video modes should be disabled. Please see the [Refresh rate and VSYNC](https://help.steampowered.com/en/faqs/view/2C7C-E420-87D5-977C) article for more information on managing your screen refresh rate.
  
  
# Update your various drivers
  
Outdated drivers (CPU, GPU, and audio) may fail to make full use of your machine's capabilities, resulting in significantly reduced FPS. A good first step for improving game performance is to ensure you have the latest drivers for your various components. Please see the [Updating drivers](https://help.steampowered.com/en/faqs/view/5799-495F-1F25-D15B) article for information.  
  
  
# Use an optimal resolution
  
Increasing resolution, or any video option beyond your recommended settings will have an immediate negative impact on your FPS.  
* [h5]For games developed by Valve[/h5]  
If you have changed or modified your video settings (and do not remember the original settings) you can reset them with the instructions provided in the [Using Launch Settings for Video and Display Problems](https://help.steampowered.com/en/faqs/view/2542-790F-14F8-D66A) article.  
  
Valve games have support for auto-detecting your hardware and setting reasonable graphics settings. Please try using *-autoconfig* as a launch option as an initial troubleshooting step when trying to improve FPS. If the game launches and you have improved FPS, we recommend slowly modifying your video settings to find acceptable FPS. If you continue to make changes and notice a drop in FPS, you'll know you've set your video settings too high for your hardware.
* [h5]For games not developed by Valve (third-party games)[/h5]  
As the settings and configuration options for these games can be very different depending on the game developer, you will want to contact that game's support team if you are encountering resolution issues that you are unable to solve.  
[h5]Contacting third-party support[/h5]  
You can find the third-party game's support contact information by selecting the game in your Steam Library and then on the right hand side select "Support" from the tabs available above the "Activity" section.
  
  
# Modify your video settings
  
Manually modifying your game's video options can increase your FPS, however, we do not provide support for this process at Steam Support. Each user's machine has unique capabilities and will run games differently; even at the same resolution.  
  
It is recommended that you use the factory default settings for your video card if you encounter random freezes (but not crashes) while playing or loading maps.  
  
For Valve developed games, please see the [Using Launch Settings for Video and Display Problems](https://help.steampowered.com/en/faqs/view/2542-790F-14F8-D66A) article for help if you are experiencing inadequate performance and would like to lower your video resolution and DirectX level (this may help with older video cards and integrated video cards) to improve game performance.  
  
  
# Using an integrated graphics card
  
Many notebooks use integrated graphics cards for video processing. Integrated graphics cards are not as strong as dedicated graphics cards, and as a result players may experience lower in-game performance.  
  
When running a system with an integrated graphics card, you should run the game with shader detail set to low and in windowed mode in order for the game to function properly. Please note, Source games do not support anything below DirectX 8.1. Left 4 Dead, Left 4 Dead 2, Portal 2, and CS:GO do not support anything below DirectX 9.0c. If you can not run the game in these minimum modes, your video card does not meet the minimum system requirements to run the game(s).  
  
  
# Use launch options for Valve games
  
Valve Source and GoldSrc games can make use of launch options to adjust detail levels and graphic rendering. Launch options are easily set parameters that can change the behavior of Steam applications when they are run. Please see the [Setting Game Launch Options](https://help.steampowered.com/en/faqs/view/7D01-D2DD-D75E-2955) article for more information.
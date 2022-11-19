# CS:GO - Trusted Mode
Updated 2021-07-10 19:49:55  
Version 3  

* [What is Trusted mode?](#trust)
* [How does Trusted mode help fight against cheaters?](#how)
* [Does Trusted mode prevent cheats from working?](#prevent)
* [Would I get banned for injecting into CS:GO if I run in normal (not Trusted) mode?](#banned)
* [Is there a whitelist of software that can be safely injected into CS:GO?](#whitelist)
* [Does normal (not Trusted) mode guarantee a penalty to the Trust score or segregation from Trust mode players?](#penalty)
* [Why are some players noticing performance issues in Trusted mode?](#perf)
* [Why are some players crashing when launching CS:GO in Trusted mode?](#crash)
* [What happens if I start incompatible software after the game has launched in Trusted mode?](#loaded)

  
  ## What is Trusted mode?
Trusted mode in CS:GO blocks third-party files from interacting with the game and is enabled by default for all CS:GO players.    
  ## How does Trusted mode help fight against cheaters? 
Some applications interact with CS:GO by injecting directly into the game process. This method is used by common applications as well as cheats.  
  
We can vastly improve cheat prevention by restricting injections altogether — as opposed to determining whether an injection is a cheat or not. The solution is to:  

* Provide a way to play without foreign application injections and then...
* Update our policy to include VAC banning for any targeted process tampering.

Trusted mode gives players a way to launch CS:GO and ensure that they do not accidentally run software that injects into the game. While in Trusted mode, software that normally would inject into the CS:GO process is rejected. Because CS:GO has protected itself, any injections that occur are not accidental and therefore subject to a VAC ban.    
  ## Does Trusted mode prevent cheats from working?
No. Trusted mode is a minimal barrier to cheat development, however, we expect that cheats will be detected more quickly. The goal of Trusted mode is to create a barrier that can’t accidentally be crossed, and to be able to easily identify any application that does.    
  ## Would I get banned for injecting into CS:GO if I run in normal (not Trusted) mode?
No. However, over time the Trust Factor system will learn whether certain patterns of software injection are more likely to lead to cheating. So, your Trust Factor may be negatively affected by running CS:GO outside of Trusted mode.  
  
We expect that some cheaters will simply run in normal mode and avoid a ban for injecting software into the game. But over time, we also expect that they will experience significantly reduced Trust because their pattern of software injection will be associated with cheating.    
  ## Is there a whitelist of software that can be safely injected into CS:GO?
No. Unfortunately, even benign applications are often a vector for cheats that hijack them in order to cheat in CS:GO. So in Trusted mode, all foreign software is blocked.  
  
Note that in normal mode, some application injections may also be blocked. To inject into CS:GO in normal mode, the software DLLs must be signed. Injections by unsigned DLLs will result in CS:GO launching in insecure mode, which prohibits playing on VAC-secure servers.  
  
If you would like to play CS:GO with software that is normally blocked you will need to [add the launch option](https://help.steampowered.com/en/faqs/view/7D01-D2DD-D75E-2955) "*-allow_third_party_software*".    
  ## Does normal (not Trusted) mode guarantee a penalty to the Trust score or segregation from Trust mode players?
No. Playing in normal (not Trusted) mode does not guarantee a Trust score penalty and Players in both modes are not excluded from playing with each other. However, the Trust learner will eventually incorporate all of the new information in calculating Trust scores.    
  ## Why are some players noticing performance issues in Trusted mode?
CS:GO refuses injections in Trusted mode, but sometimes applications keep trying. When applications try to inject into CS:GO at very high rates (some as frequently as 1kHz), players may notice performance issues.  
  
Sometimes applications attempt to inject during low level Windows mouse events, which results in noticeable performance degradation when the mouse is moved. We are internally testing a mechanism that has virtually zero overhead, even for the most zealous of injecting software. Once this new approach ships, players should no longer notice a performance impact from running in Trusted mode, even when moving the mouse.    
  ## Why are some players crashing when launching CS:GO in Trusted mode?
Earlier versions of CS:GO’s Trusted Mode would refuse foreign software injection in a variety of ways, but all countermeasures take place inside the CS:GO process. As a result, if those countermeasures violated expectations of the software being injected, a crash would occur inside CS:GO.  
  
By capturing the vast variety of software the CS:GO community is injecting (both on purpose and by accident), we’ve identified a technique that defeats injection in a manner that is both safe and high performance. Once this solution ships, users should no longer experience crashes.    
  ## What happens if I start incompatible software after the game has launched in Trusted mode?
If you start incompatible software after the game has launched in Trusted mode you may be disconnected from your match until you re-launch in Trusted mode.  
  
Like other Competitive cooldowns, any cooldowns received for this reason cannot be removed from your account.
# TF2 Mann vs Machine Server Overview
Updated 2021-10-27 22:48:17  
Version 3  

How do I setup a Mann vs Machine server?  
  
#### MvM General Server Requirements:

* Your server hardware must be able to run at least a single 32 slot TF2 server.
* Your server must be set to 32 players. Include "**+maxplayers 32**" in the server command line.
* You cannot have any non-mvm maps in the MvM mission cycle file found in *tf/tf_mvm_missioncycle.res*
* You must start your server on any MvM map. Include "**+map mvm_decoy**" for example in your command line or "**map mvm_decoy**" in your autoexec.cfg.

  #### MvM Matchmaking Server Requirements:
To include your MvM server in the TF2 matchmaking system which will send players who choose Boot Camp in the Co-Op screen to your server you must do the following:  
  

* Set **tf_mm_servermode 1** 
* A value of 0 will opt your server out of all matchmaking (Default).
* A value of 1 (or higher) will opt your server into matchmaking. The lobby system will control the current map on the server.  Currently, community servers can only participate in MvM matchmaking.
* Clear or remove any **sv_password** value that you may have set. You server cannot be passworded.

  
  
### What does **tf_mm_strict** do and how do I set it?
**tf_mm_strict** can be used to limit the visibility of your server and who can join it and can be set anytime. Setting this convar to 1 requires **tf_mm_servermode** be set.  
  

* **tf_mm_strict "#"**  
* A value of 0 will disable this feature and allow your server to accept both quickplay beta, matchmaking and server browser traffic (Default)
* A value of 1 will hide your server from the server browser and only allow players to connect from the matchmaking system. Note: If a player has favorited your server, it will still appear in their favorites however they will not be able to connect.
* A value of 2 will hide your server from the server browser and only accept direct connections to the server from a user's favorites, friends game or connect command.
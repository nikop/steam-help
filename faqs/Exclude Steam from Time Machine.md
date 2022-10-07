# Exclude Steam from Time Machine
Updated 2021-07-10 19.49.55  
Version 3  

## I'm using Time Machine and each time a game gets updated it backs up the entire game again. How can I stop this?
  
  
When setting up Time Machine on your computer make sure that you exclude the /Users/[username]/Library/Application Support/Steam/SteamApps/:  
  

* From the macOS Apple menu, select System Preferences, then Time Machine
* Click Options, then click the "+" to add items to the exclusion list
* Add your **/Users/[username]/Library/Application Support/Steam/SteamApps/** folder to the exclusion list

  
Time Machine will no longer backup your SteamApps folder each time a game is updated. This will avoid large amounts of data being backed up with only minor updates.
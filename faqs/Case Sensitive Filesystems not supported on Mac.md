# Case Sensitive Filesystems not supported on Mac
Updated 2021-12-03 19.44.18  
Version 5  

Steam gives me the error, "Steam requires that ~/Library/Application Support/Steam be created on a case insensitive filesystem." or "Steam requires that ~/Documents/Steam Content be created on a case insensitive filesystem."  
  

---
  
  
Steam does not currently support case sensitive filesystems or partitions.  
  
If you wish to use Steam please make sure of the following:  
  

* Steam is installed on a case-insensitive partition or hard drive
* Your User folder is installed on a case-insensitive partition or hard drive

  
  
To check whether you have a case-sensitive partition:  
  

* Open the program Terminal
* Type in: diskutil info /
* Hit enter
* Scroll down until you see the line "File System Personality."

  
If it shows "Case-sensitive Journaled HFS", "APFS (Case-sensitive)" or "APFS (Case-sensitive, Encrypted)" the hard drive IS case-sensitive.  
  
If it shows "Journaled HFS", "APFS", "APFS (Encrypted)" the hard drive is NOT case-sensitive.  
  
  
For advanced users familiar with Unix and Terminal, you may be able to get your case-sensitive system to work by using symbolic links.  
  
Otherwise, you will need to install Steam to a different partition on this computer, or a different harddrive completely.
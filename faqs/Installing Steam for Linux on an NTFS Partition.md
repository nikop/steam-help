# Installing Steam for Linux on an NTFS Partition

Commonly, drives are mounted automatically using **/etc/fstab**. In order to install Steam for Linux onto an NTFS partition, it must be explicitly mounted using the **ntfs-3g** driver. The following information lists the steps for properly modifying your **/etc/fstab** file:  
  
From a command-line, determine the UUID of the drive containing the NTFS partition:  
  
`sudo blkid`  
  
Add a line to your **/etc/fstab** file that mounts that drive with **ntfs-3g:**  
  
`UUID=*yourUUID* /data  ntfs-3g  defaults,locale=en_US.utf8  0 0`  
  
Save your changes and reboot your machine.  
  
For more information on mounting NTFS partitions using **/etc/fstab**, see this [article](https://help.ubuntu.com/community/MountingWindowsPartitions#NTFS).  
  

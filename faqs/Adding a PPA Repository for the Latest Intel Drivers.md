# Adding a PPA Repository for the Latest Intel Drivers
Updated 2021-10-27 23:24:56  
Version 4  

If your machine is running an Intel graphics card, we recommend running the latest graphics drivers. These drivers, developed and approved by Intel, are distributed using the x-updates PPA (personal package archive). By default, this PPA is not added to the Ubuntu 12.04 repository list.   
  
To add the x-updates PPA to the Ubuntu 12.04 repository list, do the following:  
  
* Open **Ubuntu Software Center**.
* From the top-level menu, select **Edit** | **Software Sources ...** .
* Select the **Other Software** tab.
* Click the **Add ...** button.
* Enter the following: deb http://ppa.launchpad.net/ubuntu-x-swat/x-updates/ubuntu precise main
* Click the **+Add Source** button.
* Provide your user password when requested.
* Click the **Close** button.
* Open **Update Manager** (click the Unity icon on the launch bar and enter "update manager") and click the **Check** button to refresh the package cache.
  
  
For more information related to video drivers, see [https://wiki.ubuntu.com/Valve](https://wiki.ubuntu.com/Valve).
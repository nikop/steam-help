# Using a Firewall with Steam
Updated 2021-08-04 22.23.14

How should I configure my firewall to work with Steam?  
  
[section style=important] ### Important:
If you are installing Steam for the first time or if there has been a recent Steam update, a firewall may be preventing Steam from connecting to the Steam Network.  
  
You may be asked to re-authorize Steam after a client update. Some Steam games may also prompt for firewall authorization after a game update.[/section] #### Troubleshooting Steps

* Close the Steam client application.
* Open the configuration view for your firewall program, and remove any instances of the following executables from the permissions:  

* steaminstall.exe
*  [exclude_realm=china]
* steam.exe
* [/exclude_realm]  		[exclude_realm=global]
* steamchina.exe
* [/exclude_realm]
* hl.exe
* hl2.exe
* steamTmp.exe
* Start Steam. Your firewall should prompt you to set new permissions for steam.exe. If it does not, the security settings may be too strict - you will need to change these settings so you will be prompted to set permissions.  
  
Give the Steam executables permission for all TCP and UDP ports when prompted.
* Restart your computer and start Steam.

  ####   
If you are still having connectivity problems, you may try the following test:  

* Exit the Steam client.
* Temporarily disable your firewall.
* Restart Steam and test connectivity.
* Re-enable your firewall.

  
If Steam operates normally only when your firewall is disabled, please recheck your firewall configuration. You may wish to contact the provider of your firewall for configuration help. **We do not recommend leaving your firewall disabled.**  
  
If you still experience problems with the firewall disabled, please see the [Troubleshooting Network Connectivity](https://help.steampowered.com/en/faqs/view/669A-2F68-D1D1-A5EC) topic for further troubleshooting recommendations.  
  

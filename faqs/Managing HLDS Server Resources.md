# Managing HLDS Server Resources
Updated 2021-07-10 19.49.55

How can I control how my HLDS server resources are managed?  
  
In all below descriptions, 1 = enabled, 0 = disabled  
  
#### Client side:

* *cl_allowdownload 1/0*  
Allow/Prevent any download from the server to the client.
* *cl_allowupload 1/0*  
Allow/Prevent any content (including sprays) from being sent from the client to the server.

  #### Server side:

* *sv_allowupload 1/0*  
Allows/Prevents clients sending custom sprays to the server.  
  
NOTE: sv_allowupload 0 will cause the message:  
  
"ignoring custom decal from xxxxxx" on the server console.
* *sv_send_logos 1/0*  
Enables/Prevents the server from sending custom sprays to the clients.
* *sv_send_logos 1*  
requires sv_allowdownload 1 to work.
* *sv_allowdownload 1/0*  
Enables/Prevents the server from downloading any content to the client (maps, sprays and related).
* *sv_send_resources 1/0*  
Enable/Disable all secure resources from being sent to the client.
* *sv_filetransfercompression 1/0*  
Enables/Disables the server from compressing & sending compressed content to the client.
* *sv_downloadurl <url>*  
Setting this CVAR will allow Clients to download Custom Content via HTTP instead of sourcing the content from the game server, much faster.
* *hpk_maxsize 0/(variable number, set to 0.1 to minimize)*  
No limit/100k limit to the size of the custom.hpk file on the server that stores all the sprays from the client.

  
  

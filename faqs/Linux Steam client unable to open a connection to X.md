# Linux Steam client unable to open a connection to X
Updated 2021-07-10 19:49:55  
Version 2  

How do I fix problems with the Steam client connecting to X?  
  
When the Steam client is unable to open a connection to the X Window System it will not be able to run at all.  Here are some possible causes of this problem:  
  
* Your DISPLAY environment variable is set incorrectly, for example it is set to an empty string.  You can check the setting by running 'echo $DISPLAY' in a terminal window.  Unless you have specifically changed it, it should normally be ':0'.  If it isn't and you haven't changed it you can try and run Steam with the default by running 'DISPLAY=:0 steam' in a terminal window.  You can also try running simple X programs like xclock to see if they work.
* You are running through a remote connection, such as ssh, but you have not enabled X remoting.  In the case of ssh you need to use ssh -X to enable X forwarding so that X programs can run over the remote connection.
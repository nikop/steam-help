# Submitting A Network Activity Report

When encountering issues using Steam web services, it may be helpful to record the behavior and submit a diagnostic report to Steam Support. Some common issues that can be better understood with a report:  

* Purchase failures
* Community errors
* Page load issues

  
  
# What type of report is needed?
  
Tools included with your browser can organize and record network operations. This information can be used to determine the underlying cause(s) of specific issues encountered while using Steam.   
  
These tools capture all network operations respective to the browser session that they are recording. These operations result from interaction between the browser and web pages, including all data being sent and received during the recorded session.  
  
None of this information is automatically sent to Valve. If you are working with Steam Support on a customer support issue, you can choose to send the report. Valve will use the information you recorded to assist with your customer support issue, and will protect the information in accordance with [Valve's privacy policy](http://store.steampowered.com/privacy_agreement/).  
  
[section style=warning] ### Unencrypted Data Warning
All information being sent and received will be recorded by the tool in its unencrypted state. This can include billing information, sensitive payment details, and other form data that you enter during the recording process. We ask that you remove any of this information prior to submitting. Instructions on doing so can be found at the bottom of this article.[/section]   
# How to create and submit a report
  
Depending on which browser you are using, you can follow the steps below to reproduce the issue and capture the associated activity log. Make sure that if you are reproducing a purchasing issue, you read the note at the bottom of this article and remove any sensitive information you have entered on the web page, such as credit card related information.  
  
#### Google Chrome, Microsoft Edge, and Mozilla Firefox:
  

* Open your web browser's developer tool using the default shortcut (F12 on Windows, Ctrl + Shift + i on Linux, and Cmd + Opt + i on macOS). Alternatively, the developer tool can be opened by navigating to the menu at the top-right of your browser window, then select:  

* Chrome: More tools > Developer Tools.
* Edge: More tools > Developer Tools.
* Firefox: More Tools > Web Developer Tools.
* Select the Network tab at the top-left of the developer tool. From here, ensure that the red light is on, indicating that network traffic is being recorded.
* Now, you will need to refresh the webpage and reproduce the steps that led to your issue. You should see a number of entries being created in the Network table.
* Finally, right-click anywhere within the table and select 'Copy' then 'Copy all as HAR'. This will copy the contents of the log to your system clipboard, allowing you to paste the contents into a notepad .txt file, which can be submitted to Steam Support.

    
#### Internet Explorer 11:
  

* Open the IE developer tool using the default shortcut (F12 on Windows, Ctrl + Shift + i on Linux, and Cmd + Opt + i on macOS). Alternatively, the developer tool can be opened by selecting 'F12 Developer Tools' from the Tools dropdown in the IE browser toolbar.
* Select the Network tab at the top-left of the developer tool. There should be a green play icon in the developer toolbar, indicating that network traffic is not yet being recorded.
* Now, you will need to refresh the webpage, press the green play icon, and reproduce the steps that led to your issue. You should see a number of entries being created in the Network table.
* After stopping the recording by pressing the red stop icon, export the data as a .har file by selecting the 'save' (Export as HAR) icon in the toolbar. You will then need to open the .har file in notepad and then save as a .txt file. The .txt file can then be attached to your Steam Support ticket.

    
  
  
[section style=important]   
# Removing sensitive information from your report
  
If there is any sensitive data in your log, you can edit the .txt, .xml, or .har file and remove that data.  

* Open the .txt, .xml, or .har file that you generated using the developer tool.
* Use your operating system's 'find' function to search the document for any instances of sensitive data.
* Delete this information and save the document as a .txt file so it can be attached to your Steam Support ticket.

 [/section]
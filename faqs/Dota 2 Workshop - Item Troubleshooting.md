# Dota 2 Workshop - Item Troubleshooting
Updated 2021-10-28 01:50:11  
Version 4  

![http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/workshop_banner.jpg](http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/workshop_banner.jpg)  
  
Below are some technical problems artists have encountered while authoring or submitting items.   
  
* [I'm getting a compile error that says my model is 516 triangles and is not weighted to bones, but this does not apply to my model.](#compileerror)
* [I imported a Valve FBX reference file into my modeling software but some joints have the incorrect orientation](#fbx)
* [My model mesh has broken skinning, is the wrong scale, or is completely detached from the skeleton when I preview it in the workshop tool.](#refmodel)
* [My submission has failed to complete](#submitfail)
* [My item submission shows an "Invalid Zip File" error.](#invalidzip)
* [I looked for my item on the workshop but the link goes to a page that says "That item does not exist. It may have been removed by the author".](#doesnotexist)
  
  
* If you're looking for help with Dota 2 League tickets, please go [here](https://support.steampowered.com/kb/1719-OPHL-1139/dota-2-league-tickets).
* If you’re looking for help with Dota 2 Custom Games, please go [here](https://developer.valvesoftware.com/wiki/Dota_2_Workshop_Tools/Addon_Overview).
  
  
​  
  
---
  ##   
  ## ITEM WORKSHOP FEEDBACK AND BUG REPORTS
* If the problems you're encountering are not addressed here or you have feedback concerning our item workshop tools or hero reference files, please report this on the [Dota Item Workshop Dev Forum](http://dev.dota2.com/forumdisplay.php?f=407).
* For bugs, provide as much detail as you can:
  
* The software package and format of the files you're working with
* What hero or items you're working with
* What plugins you're using to export model and animation files
* Any error messages you see
* Screen shots of problems with models or textures (including views of joints or wireframes if necessary)
* Steps we can follow to reproduce bugs
  
  
We appreciate your help!  
  
  
  
## I'm getting a compile error that says my model is 516 triangles and is not weighted to bones, but this does not apply to my model.
* If you get a model compile error saying your item is 516 triangles, the tool may actually be reading the 516 triangles of our "ERROR" model, which does not have any bones. Reading the 'ERROR' model actually means something else is failing earlier in the compile, possibly a texture. We've made adjustments to eliminate most causes of the misleading triangle message but it may occasionally still occur.
  
  
![http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/small_error_model.JPG](http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/small_error_model.JPG)​  
  
* Look at the Import Log for your item to get information about what is failing in your item's compile. When debugging it helps to also have your console open before you try to submit an item so you can see any additional errors that may be useful.
* If the console information doesn't make the problem clear, you can post the output from the console to the [Dota Dev Item Workshop Forum](http://dev.dota2.com/forumdisplay.php?f=407). Valve devs or community members may be able to help you resolve the problem after having more information.
  
  
  
  
## I imported a Valve FBX reference file into my modeling software but some joints have the incorrect orientation. 
* We are aware that some third party software has problems importing the FBX format we are now using for workshop reference files. We have transitioned to using the FBX format for better functionality within our pipeline and better compatibility with most commercial modeling and animation software. We found [Autodesk's FBX SDK](https://www.autodesk.com/developer-network/platform-technologies/fbx-sdk-2020-0) very helpful when we were transitioning our tools to FBX and we highly recommend this resource (which includes a Python SDK) to other modeling software developers.
  
  
  
  
## My model mesh has broken skinning, is the wrong scale, or is completely detached from the skeleton when I preview it in the workshop tool.
* Valve reference file. Are you weighting meshes to a current Valve reference file? Old Valve model files, files from other sources or decompiled game files may contain incorrect scaling or inaccurate joint positions. You can download Valve's latest model files from the [Hero Resource](http://www.dota2.com/workshop/requirements) page.
* Import and Export with Scale Factor set to 1.0. Our workshop tools don't use a set unit of measurement. However, when you import our workshop reference files or export your item files, it is important to ensure that your importer and exporter do not apply a scale factor other than 1.0. The scale factor can be viewed in your software's import and export settings. You should confirm the correct scale settings before importing any Valve workshop file.
* Bone renaming. If you see a compile error saying bones have not been found, check to see if your reference file import or authoring process, such as adding a rig, caused the bones of our default skeleton to become renamed.
* Include the root bone. Export your mesh file with the root bone included. Some exporters may decide to ignore the root if it is not part of the skinning, to avoid that you can add the root bone to the skin with 0 influence.
* Altered joint positions. Did you reposition the joints of Valve's default hero skeleton before authoring your item? Community hero wearable items, including mounts, must work with Valve's default hero joint positions and animations.
* Mesh shape is incompatible with animated joints. Is your mesh drastically different from the default hero skeleton in an area that has many highly active joints, such as wings? If your mesh distorts too much during animations you may have to revise the mesh to more closely follow the skeleton.
* Valve cloth. If you are authoring something that uses Valve's cloth, such as Zeus' scarf or Crystal Maiden's cape, study the skinning on Valve's hero reference file and copy it if necessary. Source 2 cloth requires very careful weighting.
* Static model export pose. Have you accidentally exported your model on an action pose or a range of animation? You'll need to export your model as a single, static frame of the skeleton's bind pose. If your item is skinned to a Valve skeleton, the joints must match the scale, positions and rotations of Valve's bind pose.
* 4 Vertex skinning limit. Our game is only able to support the skinning of 4 vertices per joint. Skinning on additional vertices will be deleted.
* Mesh triangulation. Did you triangulate your mesh? If you don't do this, our workshop tool will triangulate the mesh, which may cause changes from the deformation you authored.
* Duplicate bone names. If you are creating a custom skeleton for a ward, courier or ability model, avoid having duplicate bone names. These can cause model distortions in Source 2.
* Custom skeleton checkbox. If you are submitting an ability model with a custom skeleton and custom animations, be sure to mark the 'Model Uses a Custom Skeleton' checkbox to ensure that Valve's default animations for that item type are not accidentally applied to your skeleton.
  
  
​![http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/models/custom_model_checkbox.jpg?](http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/models/custom_model_checkbox.jpg?)  
  
* FBX or DMX exports. If you are seeing issues with models that have been exported as FBX files and have followed all of the above requirements, try exporting files as DMX if you have that option.
* More model guidelines - Please see our [Model Requirements](https://support.steampowered.com/kb/9814-QSHK-8085/dota-2-workshop-item-model-requirements) page and the [guidelines for specific item types](http://www.dota2.com/workshop/#types).
  
  
​[url id=submitfail][/url]  
  
## My item submission has failed to complete.
* If you were testing a work-in-progress item with a mesh that's over our triangle limit you will need to adjust it to be within the item's budget before you can submit it to the workshop.
* You need to make sure you are not using a "Limited" account to make a submission. To combat fraud, we require that Steam accounts need to have purchased at least $5 USD on the Steam store before they have certain privileges, including being able to submit items to the Workshop. You can find out more on the [Limited User Accounts FAQ](https://support.steampowered.com/kb/3330-IAGK-7663/limited-user-accounts).
  
  
  
  
## My item submission shows an "Invalid Zip File" error.
![http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/workshop_account_preparation/invalid_zip.jpg](http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/workshop_account_preparation/invalid_zip.jpg)  
  
* You will get an "Invalid Zip file" error if you try to add additional files to your workshop submission .zip file beyond those generated by the workshop tool. Files for supported item types should be submitted under the appropriate category. If there is no category for the item you wish to submit that means our workshop item tool is unable to accept it at this time.
  
  
  
  
## I looked for my item on the workshop but the link goes to a page that says "That item does not exist. It may have been removed by the author".
![http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/workshop_account_preparation/item_does_not_exist.jpg](http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/workshop_account_preparation/item_does_not_exist.jpg)  
  
* Make sure you are logged into the workshop.
* If you are trying to view a submission that you have marked hidden, be sure that you are trying to view it through the same account you used to submit it.
* If you are trying to view an item submitted by a friend that has its visibility set to "Friends Only" you will need to view it through the account they use to friend you.
* Make sure that the revenue shares have been finalized for the item. After all parties have agreed to the revenue shares, the entity making the submission has to finalize these shares.
  
  
[Dota 2 Item Workshop Guidelines Homepage](http://www.dota2.com/workshop/)
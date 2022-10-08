# Dota 2 Workshop - Wards
Updated 2021-12-03 19.12.21  
Version 8  

# ![http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/wards/header_wards.jpg](http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/wards/header_wards.jpg)

* [WARD CONCEPT CONSIDERATIONS](#concept)
* [WARD MODEL REQUIREMENTS](#model)
* [WARD MATERIALS](#materials)
* [WARD ANIMATION REQUIREMENTS](#animation)
* [HITBOXES](#hitboxes)
* [ATTACHMENT POINTS](#attachments)
* [WARD PORTRAIT](#portrait)
* [SUBMITTING WARDS](#submit)
* [ITEM TROUBLESHOOTING](#trouble)
* [WARD REFERENCE DOWNLOAD](#reference)

  
  
  
  
## WARD CONCEPT CONSIDERATIONS

* Observer and sentry wards need an 'eyeball' element that is very prominent and can be seen clearly from above in game view.
* For gameplay clarity, the eyeballs should have strong yellowish or bluish coloring.
* If the ward has a face or prominent features, make sure these can be clearly seen from above in game view.
* Our artists review wards by how they look in game, so please put as much effort into the in-game view as you do for their appearance in the loadout.
* For more information about general item design concepts, please see our [Character Art Guide.](https://support.steampowered.com/kb/9334-YDXV-8590/dota-2-workshop-character-art-guide)

  
  
![http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/wards/ward_default.jpg](http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/wards/ward_default.jpg)  ![http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/wards/megagreevil_ward.jpg](http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/wards/megagreevil_ward.jpg)  ![http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/wards/watcher_below_ward.jpg](http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/wards/watcher_below_ward.jpg)  ![http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/wards/f2p_ward.jpg](http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/wards/f2p_ward.jpg)  
  
![http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/wards/ward_default_game3.jpg](http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/wards/ward_default_game3.jpg)  ![http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/wards/ward_greevil_game.jpg](http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/wards/ward_greevil_game.jpg)  ![http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/wards/ward_watcher_game3.jpg](http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/wards/ward_watcher_game3.jpg)  ![http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/wards/ward_f2p_game.jpg](http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/wards/ward_f2p_game.jpg)  
  
​​[url id=model][/url]  
  
## WARD MODEL REQUIREMENTS

* Wards share the same model for the sentry and observer versions.
* There is a limit of 60 bones for the model.
* Both models can have two LOD (level of detail) meshes
* LoD0 is higher resolution. It is optional, is displayed in the portrait, loadout and closeup showcase views and is limited to 2000 triangles.
* LoD1 is lower resolution. It is required, is used in-game and is limited to 1500 triangles.
* Please note that our budgets refer to triangles, not polygons.
* It is helpful if you tessellate your model into triangles before submission to confirm that the final mesh is what you intend. Otherwise our tools will triangulate the mesh but may have different results from what you'll see using your software.
* Our game is only able to support the skinning of 4 vertices per joint. Skinning to additional vertices will be removed or will cause a failure when community items go through our workshop compiler.
* Please make sure the bind pose for your ward model is oriented upright and facing forward. This orientation determines the placement of the hitboxes.

  
  
![http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/submission/orientation_incorrect.jpg?](http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/submission/orientation_incorrect.jpg?)  ![http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/submission/orientation_correct.jpg](http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/submission/orientation_correct.jpg)  
  

* For general information about workshop models, go to [Workshop Item Model Requirements](https://support.steampowered.com/kb/9814-QSHK-8085/dota-2-workshop-item-model-requirements)
* We no longer accept .smd files for workshop models. Please provide .dmx or .fbx files.

  
  
  
  
## WARD MATERIALS

* Wards require two separate skin textures, one for the observer ward which has prominent areas of yellow coloring, and another for the sentry ward, which has prominent areas of blue coloring.
* The final material size for each texture is 256x256
* For general information about workshop item textures and masks, go to [Workshop Item Shader Masks](https://support.steampowered.com/kb/3081-QUXN-6209/dota-2-workshop-item-shader-masks)

  
  
  
  
## WARD ANIMATION REQUIREMENTS

* Wards need spawn, idle, and death animations.
* They have an option for portrait and rare animations.
* A run animation is not needed for wards since they are rooted in one place.
* It may help to orient the animation of the eye, head, or primary features to face slightly upwards so that they read better from above in game view.
* If you have separate portrait animations, these can be adjusted to have the head at a normal angle.
* For general information about NPC animations, go to [Workshop NPC Animations](https://support.steampowered.com/kb/3634-YOPS-9967/dota-2-workshop-npc-animations).

  
  
  
  
## HITBOXES

* Hitboxes creation by community artists is not currently supported for the Source 2 Dota Workshop. Hitboxes are created by Valve artists once a ward is accepted for the game.
* Temporary generic hitboxes are created by the workshop tool when you test your ward in demo mode so that it can be selectable. These are not the final hitboxes.

  
  
  
  
## ATTACHMENT POINTS

* Hit location attachments are needed for wards.
* The hit location specifies where attack projectiles will travel to.
* In the workshop submission tool you will need to enter the name of the bone that the attach_hitloc will bind to and, if necessary, adjust the attach position to be near the eye or above the center of the ward so that projectiles will stay well above the ground.
* Detailed instructions about designating and editing attaches in the workshop tool can be found on the [Submitting Items](https://help.steampowered.com/en/faqs/view/3E00-D38F-B793-7384) page.

  
  
![http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/wards/ward_attach.JPG](http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/wards/ward_attach.JPG)  
  
​[url id=portrait][/url]  
  
## WARD PORTRAIT

* The portrait options in the submission tool start with the same framing, lighting, and background as the default ward but you can customize these settings.
* If you have prepared a separate portrait animation with a different eye/head orientation, be sure to choose this animation from the drop-down list before framing your portrait.

  
  
​[url id=submit][/url]  
  
## SUBMITTING WARDS 

* Refer to the [Submitting Items](https://help.steampowered.com/en/faqs/view/3E00-D38F-B793-7384) page for important general information about testing and submitting items.
* It is no longer necessary to maintain our file structure when preparing your item files. The workshop tool will place your files where they need to go.

  # ITEM TROUBLESHOOTING

* If you have problems testing or submitting your ward, see our [Item Troubleshooting](https://help.steampowered.com/en/faqs/view/5D5F-A5BD-C25B-7205) page.

  
  
  
  
## WARD REFERENCE DOWNLOAD
Download the [Ward Model](http://media.steampowered.com/apps/dota2/workshop/ward.zip ) (675k)   
  

* These instructions pertain to Observer/Sentry wards that can be used and shared by all Dota heroes.
* See the [Hero Ability Models](http://support.steampowered.com/kb/7823-RUAZ-5739/dota-2-workshop-ability-models-summoned-units) webpage if you need information about the ability wards used by specific Dota heroes.

  
  
[Dota 2 Item Workshop Guidelines Homepage](http://www.dota2.com/workshop/)
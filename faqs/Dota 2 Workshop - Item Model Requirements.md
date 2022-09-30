# Dota 2 Workshop - Item Model Requirements
Updated 2021-08-23 17.14.26

  
  
![http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/models/disruptor_mount_model.JPG](http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/models/disruptor_mount_model.JPG)  
  

* [DOTA 2 WORKSHOP MODEL TYPES](#modeltypes)
* [BUDGETS](#budgets)
* [MODEL FILE FORMATS](#formats)
* [LOD (LEVEL OF DETAIL) GEOMETRY](#lod)
* [DIMENSIONS](#dimensions)
* [POLYGONS](#polygons)
* [BASE MODEL INTERACTION](#basemodel)
* [INTERACTION WITH OTHER HERO WEARABLE ITEMS](#iteminteraction)
* [MESH WEIGHTING](#geoanimations)
* [DECOMPILED MODELS](#decompiled)
* [BLEND SHAPES](#blendshapes)
* [EDGES AND VERTICES](#edgesvertices)
* [SKELETON](#skeleton)
* [BACKFACES](#backfaces)
* [HITBOXES AND ATTACHMENTS](#hitboxattach)
* [ITEM TROUBLESHOOTING](https://help.steampowered.com/en/faqs/view/5D5F-A5BD-C25B-7205#refmodel)
* [ART AND UV GUIDELINE LINKS](#artuv)
* [MODELING TUTORIAL AND SOFTWARE LINKS](#tutorial)

  
  
# [url id=modeltypes][/url]
# DOTA 2 WORKSHOP MODEL TYPES
This page is applies to all Dota workshop model types. You can find additional item-specific model requirements on these pages:  
  

* [Hero Wearables](https://help.steampowered.com/en/faqs/view/15B3-1CD0-72CF-A2CF)
* [Ability Models](https://support.steampowered.com/kb/7823-RUAZ-5739/dota-2-workshop-ability-models-summoned-units)
* [Couriers](https://support.steampowered.com/kb/8986-WRAZ-1046/dota-2-workshop-couriers)
* [Sentry/Observer Wards](https://support.steampowered.com/kb/8799-WLXN-3860/dota-2-workshop-wards)

  
  
[url id=budgets][/url]  
  
## BUDGETS

* Due to unique design of every hero, each one has different geometry and texture budgets for his or her items.
* Model budgets always refer to triangles, not polygons.
* Be sure to check the individual hero pages accessible from the [Hero Resource page](http://www.dota2.com/workshop/requirements) for specific information on item budgets.
* Wards, couriers, and ability models can have no more than 60 bones. Undying's Flesh Golem, which has to use Valve's default skeleton, has an exception to use 62 bones.
* Most hero wearables can use no more than 60 bones from the hero's default skeleton. The exception is Winter Wyvern's back slot because the hero has a large number of bones and this item covers most of the body.

  
  
[url id=formats][/url]  
  
## MODEL FILE FORMATS

* We no longer support .SMD files for workshop submissions. Model and animation files submitted through the workshop tool will need to be either .FBX or .DMX.
* Some third party modeling software has issues importing our reference FBX files, which may display with incorrect joint rotations. Until the developers of these packages are able to update their FBX plugins you may need to try using other software to author your items.

  
  
[url id=lod][/url]  
  
## LOD (LEVEL OF DETAIL) GEOMETRY

* Each item can have two models with different levels of detail.
* The optional, higher resolution LOD0 model is used in the portrait, loadout and in-game close up showcase views.
* The required lower resolution LOD1 model is used for normal top-down in-game viewing.
* When testing your item in the workshop tool, you can switch between LOD0 and LOD1.
* LOD0 can sometimes be twice as detailed as LOD1, depending on the hero, item, and overall budget.
* Some Valve artists create LOD0 first, then create LOD1 from this by optimizing and removing small details. Other Valve artists author LOD1 first, then build on this to add details for the LOD0 version.
* If LOD0 geometry is not provided, the LOD1 geometry will be used for all situations including close-up views.

  
  
[url id=dimensions][/url]  
  
## DIMENSIONS

* If you decide to make items of very different dimensions from the hero's default items, bear in mind that the hero's selection area will not grow or shrink to fit custom items.
* We're open to looking at item designs that push the boundaries but be aware that extreme deviation from the default item size or silhouette may cause problems identifying the hero in-game. If you decide to try a profoundly different silhouette for some items, you may need to bring colors or other items closer to what's recognizable for the hero to compensate for this. Our [Character Art guide](https://help.steampowered.com/en/faqs/view/0688-7692-4D5A-1935) has more information about achieving this balance.
* Be careful if your mesh drastically differs from the default hero skeleton in an area that has highly active joints, such as wings. If your mesh distorts too much during animations you may have to revise the mesh to more closely follow the skeleton.

  
  
[url id=polygons][/url]  
  
## POLYGONS
![http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/models/13_art_uv_alchemist.jpg](http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/models/13_art_uv_alchemist.jpg)  
  

* Like [textures](https://help.steampowered.com/en/faqs/view/0688-7692-4D5A-1935#gradient), geometry typically has a gradient, with the lowest amount of polygons being used around the feet/lower torso and highest density around the head and upper torso.
* Make every triangle count. A polygon should either be contributing to the silhouette and/or helping deformations.
* In situations where the texture resolution doesn't support clean edges on prominent areas of an item, for example, the edge of a mane or saddle on a mount, you may want to create these edges with geometry instead of with the texture. It helps to consider needs like this that are affected by your item budget early in your concept phase.
* Polygons are also added in cases where the normal map isn't projecting properly due to lack of geometry.
* Avoid creating long triangles as they tend to cause shading errors, especially during animations.
* It is helpful if you triangulate your model before submission to confirm that the final mesh is what you intend. If you don't, our tools will triangulate the mesh but the results may look different from what you authored.

  
  
[url id=basemodel][/url]  
  
## BASE MODEL INTERACTION

* Most hero items are created on top of the geometry of the bare hero. For example, the geometry of a hero's forearms is not removed; his or her bracers sit on top of it.
* Only if a body part is designated as an item slot - such as Pudge and Tusk's left arm or Faceless Void's head - can it be totally replaced by a custom item.

  
  
[url id=iteminteraction][/url]  
  
## INTERACTION WITH OTHER HERO WEARABLE ITEMS

* Use "Select Wearables" in the Preview Model window of the item workshop tool to test how your hero wearable items interact with each other and with the hero's existing items during idle, loadout, portrait, and other important animations. You can save your wearable selections in the workshop session for the main item.
* Since people are likely to equip Arcana or Immortal items if they have them, it's important to test your items in conjunction with these models. You won't see the texture or particle effects for these items when in item workshop demo mode but you will see how the models work together.
* Extreme intersections not noticeable in the top down game view may be distracting in portrait or loadout views.

  
  
[url id=geoanimations][/url]  
  
## MESH WEIGHTING 

* Check the weighting of your item geometry with various hero animations rather than just the bind pose:
*  Animations with extreme poses, such as attacks or casts
*  Animations seen in close-up, such as portraits and loadouts
*  Frequently displayed animations, such as idles and runs
* Look for extremely distorted mesh, disconnected edges, or stray vertices accidentally weighted to the wrong joints.
* Check LOD0 and LOD1 mesh weighting in loadout and in game
* You may need to add more faces or do more refined weighting to areas that are subjected to extreme movements or that are seen prominently in portraits or loadouts.
* The [Hero Resource](http://www.dota2.com/workshop/requirements) page for each hero will indicate the specific bones that weapons need to be weighted to.
* Weighting to Valve's Source 2 cloth bones has to be done very carefully. Try copying the weighting from Valve's reference model to your model to ensure the best cloth behavior.

  
  
[url id=decompiled][/url]  
  
## DECOMPILED MODELS

* Please don't model your items to fit decompiled hero models. Game compile processes may add scaling or poses to these models that are not representative of the geometry that custom items need to fit.
* We will be updating existing workshop reference files and adding files for new workshop heroes on a gradual, ongoing basis. If we haven't yet updated the reference files for the hero you're working on, our Source 1 reference files are still usable for item creation.

  
  
[url id=blendshapes][/url]  
  
## BLEND SHAPES

* The Dota Item Workshop does not support submission of blend shapes, also known as flex or morphs, within models.
* If you submit an item that needs facial blend shapes, Valve artists will create these so the meshes will move when the hero speaks.

  
  
[url id=edgesvertices][/url]  
  
## EDGES AND VERTICES

* Our game is only able to support the skinning of 4 vertices per joint. Skinning to additional vertices will be removed or will cause a failure when community items go through our workshop compiler.
* Hard edges and smoothing groups are OK to use, but are best kept to a minimum, as they break up the vertices and add to an item's vertex count.

  
  
[url id=skeleton][/url]  
  
## SKELETON

* Your item's geometry should be skin-weighted to the default hero skeleton in the model file provided by Valve. You can download these reference files on the individual hero pages accessible from the [Hero Resource page](http://www.dota2.com/workshop/requirements) .
* We are unable to ship hero items, including mounts, that require the joints of the hero or mount to be positioned differently from the default skeleton.
* All hero items need to work with the default hero animations. This is how they will be evaluated by Valve.
* External artists are not able to add bones to community items for heroes.
* If you move the joints in your item's model file to test mesh deformations, be sure to export your item from a single frame where the joints are in the hero's bind pose.
* When creating new skeletons for custom wards, couriers, or ability models, please avoid duplicate bone names or spaces in bone names. These can cause unwanted model deformations or compile failures in Source 2.
* If you add nodes to your custom skeleton that have keys on them, even if they have no animation, the nodes may be converted to bones by the workshop tool and could fail your submission if the item goes over the 60 bone limit.
* When using Valve's skeleton for an item, if you see a 'missing bones' error when compiling your model in the workshop tool or the mesh is totally disconnected from the skeleton, see if the joint names had gotten accidentally renamed during import or if you added a rig.
* If you are submitting an ability model with a custom skeleton and custom animations, be sure to mark the 'Model Uses a Custom Skeleton' checkbox to ensure that Valve's default animations for that item type are not accidentally applied to your skeleton.

  
  
![http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/models/custom_model_checkbox.jpg?](http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/models/custom_model_checkbox.jpg?)​  
  
[url id=backfaces][/url]  
  
## BACKFACES

* Please note that Dota 2 does not support double-sided materials; you will need to create additional geometry if a backface is needed.
* Bear in mind that missing backfaces of geometry that are not noticeable in top down game view may be obviously missing in portrait, loadout, or showcase views, so you may want to provide these faces for your LOD 0 models.
* Missing backfaces for undersides of capes, scarves, and wings are particularly noticeable in the loadout.

  # [url id=hitboxattach][/url]
# ​HITBOXES AND ATTACHMENTS

* External artists do not need to create hitboxes for couriers, wards or ability models. These will be created by Valve.
* Where necessary, attachments are designated and edited within the item workshop tool. More details are on the [Item Submission](https://help.steampowered.com/en/faqs/view/3E00-D38F-B793-7384) page.

  
  
​[url id=troubleshooting][/url]  
  
# ITEM TROUBLESHOOTING

* If you have problems compiling, testing or submitting your model, see our [Item Troubleshooting](https://help.steampowered.com/en/faqs/view/5D5F-A5BD-C25B-7205#refmodel) checklist.

  
  
​[url id=artuv][/url]  
  
## ART AND UV GUIDELINE LINKS

* For design-related model guidelines, please see the [Character Art Guide](https://support.steampowered.com/kb/9334-YDXV-8590/dota-2-workshop-character-art-guide)
* For guidelines about model UVs, please see [Item UV Mapping](https://support.steampowered.com/kb/8687-AGJK-8415/dota-2-workshop-item-uv-mapping)

  
  
​[url id=tutorial][/url]  
  
## MODELING TUTORIAL AND SOFTWARE LINKS

* [Modeling Tutorial Links](https://support.steampowered.com/kb/5538-WPZC-9529/dota-2-workshop-item-faq#tutorials)
* [Modeling Software Links](https://support.steampowered.com/kb/5538-WPZC-9529/dota-2-workshop-item-faq#software)

  
  
[Dota 2 Item Workshop Guidelines Homepage](http://www.dota2.com/workshop/)  
  

# Dota 2 Workshop - Hero Ability Models
Updated 2021-08-18 19.57.26  
Version 7  

![http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/ability_models/final_ game_cog_crop.jpg?v=1459382400](http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/ability_models/final_ game_cog_crop.jpg?v=1459382400)  
  
* [HERO ABILITY MODEL OVERVIEW](#overview)
* [ABILITY MODEL TYPES](#types)
* [BUDGETS AND MODEL REQUIREMENTS](#budgets)
* [SUPPORTED ABILITY MODELS](#supported)
* [OTHER ABILITY MODELS](#other)
* [DEFAULT OR CUSTOM ANIMATIONS?](#defaultcustomanim)
* [ABILITY MODEL ANIMATION GUIDELINES](#animguidelines)
* [HITBOXES](#hitboxes)
* [ATTACHMENT POINTS](#attachments)
* [ABILITY MODEL TESTING](#testing)
* [SUBMITTING ABILITY MODELS](#submitting)
* [ITEM TROUBLESHOOTING](https://help.steampowered.com/en/faqs/view/5D5F-A5BD-C25B-7205)
  
  
  
  
##  HERO ABILITY MODEL OVERVIEW
* Hero ability models are a wide variety of creatures and units that act in conjunction with specific heroes.
* They are enabled when the hero has attained a certain level or casts certain spells.
* These units are NPCs or "Non-Player Characters"
* There are specific requirements for these NPCs that differ from wearable hero items or mounts ridden by heroes.
* Hero wearable items and mounts rely on the hero's pre-existing skeleton, attachments, hitboxes, and animations. The community artist only provides the weighted mesh.
* For ability models, the skeleton and animations are separate from the hero and may sometimes be custom tailored by community artists in addition to the mesh.
* Not all heroes use an ability model. Where applicable, these can be previewed in the Dota 2 loadout for that hero.
  
  
![{STEAM_CLAN_IMAGE}/39983882/ba37cde24122328539936735ae7dda097245379e.png]({STEAM_CLAN_IMAGE}/39983882/ba37cde24122328539936735ae7dda097245379e.png)  
  
* Details about the gameplay use of specific ability models can be viewed by selecting the relevant heroes on the [Dota 2 Heroes](https://www.dota2.com/heroes/) page.
  
  
---
  
  
  
  
## ABILITY MODEL TYPES
* Hero wards tend to stay in one place and attack enemies. Juggernaut's Healing Ward is an exception - it can move about and can heal. These wards are not to be confused with [sentry/observer wards](https://support.steampowered.com/kb/8799-WLXN-3860/dota-2-workshop-wards) that serve very different functions and can be used by any hero.
  
  
Wards for Venomancer, Witch Doctor, Juggernaut, and Pugna  
  
![http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/ability_models/venomancer_ward_large.jpg?v=1459382400](http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/ability_models/venomancer_ward_large.jpg?v=1459382400)  ![http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/ability_models/witchdoctor_ward_large.jpg?v=1459382400](http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/ability_models/witchdoctor_ward_large.jpg?v=1459382400)  ![http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/ability_models/jugg_healing_ward_npc_dota_juggernaut_healing_ward_large.jpg?v=1459382400](http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/ability_models/jugg_healing_ward_npc_dota_juggernaut_healing_ward_large.jpg?v=1459382400)  ![http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/ability_models/draining_wight_npc_dota_pugna_nether_ward_1_large.jpg?v=1459382400](http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/ability_models/draining_wight_npc_dota_pugna_nether_ward_1_large.jpg?v=1459382400)  
  
* True Forms/Ultimates/Shapeshifts are creatures the human hero temporarily transforms into.
  
  
​Hero transforms for Lycan, Dragon Knight, Lone Druid, and Terrorblade  
  
![http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/ability_models/lycan_wolf_large.jpg?v=1459382400](http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/ability_models/lycan_wolf_large.jpg?v=1459382400)  ![http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/ability_models/dragon_knight_dragon_large.jpg?v=1459382400](http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/ability_models/dragon_knight_dragon_large.jpg?v=1459382400)  ![http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/ability_models/true_form_large.jpg?v=1459382400](http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/ability_models/true_form_large.jpg?v=1459382400) ​ ![http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/ability_models/demon_large.jpg?v=1459382400](http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/ability_models/demon_large.jpg?v=1459382400)  
  
* Summoned Units are usually creatures that can travel and attack enemies in order to assist the hero but also include Death Prophet's Exorcism ghosts and Clockwerk's Power Cogs.
  
  
​Summoned Units for Lone Druid, Warlock, Broodmother, and Invoker  
  
  ![http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/ability_models/spirit_bear_large.jpg?v=1459382400](http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/ability_models/spirit_bear_large.jpg?v=1459382400)  ![http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/ability_models/warlock_golem_large.jpg?v=1459382400](http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/ability_models/warlock_golem_large.jpg?v=1459382400)  ![http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/ability_models/broodmother_spiderling_large.jpg?v=1459382400](http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/ability_models/broodmother_spiderling_large.jpg?v=1459382400)  ![http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/ability_models/invoker_forged_spirit_large.jpg?v=1459382400](http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/ability_models/invoker_forged_spirit_large.jpg?v=1459382400)  
  
---
  ##   
  
  
## BUDGETS AND MODEL REQUIREMENTS
* For specific model and texture budgets for Ability Models and reference files of the default models, please see the individual hero links via the [Hero Requirements](http://www.dota2.com/workshop/requirements) page.
* Please note that our budgets refer to triangles, not polygons.
* Ability models need to stay within 60 bones.
* We no longer support .SMD file formats. Please submit your models and animations in .FBX or .DMX format.
* It is helpful if you tessellate your model into triangles before submission to confirm that the final mesh is what you intend. Otherwise our tools will triangulate the mesh but may have different results from what you'll see using your software.
* ​Our game is only able to support the skinning of 4 vertices per joint. Skinning to additional vertices will be removed or will cause a failure when community items go through our workshop compiler.
* Please make sure the bind pose for your ability model is oriented upright and facing forward. This orientation determines the placement of the hitboxes.
  
  
![http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/ability_models/ability_orientation_incorrect.jpg?](http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/ability_models/ability_orientation_incorrect.jpg?)  ![http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/ability_models/ability_orientation_correct.jpg](http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/ability_models/ability_orientation_correct.jpg)  
  
* For general guidelines about authoring models and textures for Dota, please see our [Asset Creation guidelines](http://www.dota2.com/workshop/#creation).
  
  
---
  
  
  
  
## SUPPORTED ABILITY MODELS
These heroes have Ability Models that are enabled in the Source 2 Dota Workshop:  
  
* Beastmaster - Hawk and Boar
* Broodmother - Spiderling
* Clockwerk - Power Cog
* Death Prophet - Exorcism Spirits
* Dragon Knight - Elder Dragon
* Invoker- Forged Spirit
* Juggernaut - Healing Ward
* Lone Druid - Spirit Bear and True Form
* Lycan - Shapeshift and Wolves
* Nature's Prophet - Treants
* Pugna - Nether Ward
* Shadow Shaman - Serpent Wards
* Terrorblade - Demon
* Tusk - Frozen Sigil
* Undying - Flesh Golem
* Venomancer - Plague Wards
* Warlock - Golem
* Witch Doctor - Death Ward
  
  
​  
  
---
  
  
  
  
## OTHER ABILITY MODELS
* We will gradually enable more ability models for the Source 2 Dota workshop. Ability models with complicated technical needs may need special tool development before they can be automated in the workshop tool. Others may not be able to be supported at all.
  
  
---
  
  
  
  
## DEFAULT OR CUSTOM ANIMATIONS?
* There are several options for handling animations for hero ability models, depending on the unit. You may be able to:
* Use Valve's skeleton and animations for that unit.
* Use Valve's skeleton and a mix of Valve and custom animations, as long as the transition poses match.
* Use Valve's skeleton but create all new custom animations.
* Use a custom skeleton and all custom animations.
* If your item uses an all new skeleton for a slot that also has a default skeleton option, please mark the "Custom Skeleton" checkbox in the workshop tool so that Valve's default animations are not accidentally applied to your custom skeleton.
  
  
![http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/models/custom_model_checkbox.jpg?](http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/models/custom_model_checkbox.jpg?)​  
  
* Some ability models with complicated needs for cloth, weightlists, modifiers, aiming, and animation blends may not have the option for artists to provide custom animations but will only allow a custom weighted mesh to be applied to Valve's default skeleton and animations. Ability models that currently require this are:
* Undying's Flesh Golem
* Lone Druid's True Form
* Dragon Knight's Elder Dragon
* Venomancer's Plague Wards
* Shadow Shaman's Serpent Wards
  
  
​  
  
---
  
  
  
  
## ABILITY MODEL ANIMATION GUIDELINES
* Attack - some units may have the option for several attack variations originating from both hands or from the mouth or tail.
* Aim - certain hero wards will need you to provide poses of them facing in several different directions. These are explained in the workshop tool.
* Ability - ability animations can show the units casting an ability, reacting to an ability or transforming into and out of the human form of the hero.
* Injured or other modifiers - These will be explained in the workshop submission tool. For injured attacks you can work from a copy of your regular attack animations and just make sure that they match their injured pose at the beginning and end.
* Turns - though optional, these right, left, and center poses are very helpful for generating smooth transitions during turns, especially for horizontal or long creatures that can otherwise look somewhat mechanical when turning.
* For general animation guidelines, see [Workshop NPC Animation](https://support.steampowered.com/kb/3634-YOPS-9967/dota-2-workshop-npc-animations)
  
  
​  
  
---
  
  
  
  
## HITBOXES
* Hitbox creation by community artists is not currently supported for the Source 2 Dota Workshop. Hitboxes are created by Valve artists once a custom NPC is accepted for the game.
* Temporary generic hitboxes are created by the workshop tool when you test your model in demo mode so that it can be selectable. These are not the final hitboxes.
  
  
---
  ##   
## 
## ATTACHMENT POINTS
* An attachment is a static point bound to a bone in the skeleton. The names and number of attachments used varies with each type of NPC.
* You create these in the item workshop submission tool by naming the bones that these attaches will bind to.
* Some ability models that use Valve's default skeleton will have the default attach bone names automatically filled in.
* Once your model compiles you will have the option to adjust the attachment's position or orientation if necessary.
* Below are typical attachment points. These names are specific and case sensitive.
* attach_hitloc - This attachment is required for every NPC item. "hitloc" stands for "Hit Location" and is used by the particle system to determine where projectile effects should travel to when fired at your NPC. For most creatures, the best place for "attach_hitloc" is a bone in the chest or head. Placing this attach in the root or on the ground results in projectiles traveling too low and is less appealing. For inorganic models, choose a location above the center of the model.
* attach_attack1 - This attachment is required for NPCs that can attack or cast spells.
* For units with ranged projectiles, this determines where projectiles will be created and launched from.
* For melee units, place the attachment in the hand the unit attacks with. You may be asked to place an additional attach_attack2 in the other hand, the mouth or the tail.
* attach_eye_l and attach_eye_r - These attachments are only used to apply Valve's default particles to some ability models. The workshop submission tool will say when these are required. Place these on the unit's eyes, making sure that the red X axis points in the direction the eye looks.
* Certain units, like Terrorblade's Demon or Warlock's Golem, may require additional attachments to position Valve's default particle effects. The workshop submission tool will explain these where needed.
* Details about designating and editing attachments in the workshop tool can be found on the [Submitting Items](https://help.steampowered.com/en/faqs/view/3E00-D38F-B793-7384) page.
  
  
---
  
  
  
  
## ABILITY MODEL TESTING
When Valve artists review custom NPCs they are mainly evaluated on how they look from above in game view. To test your custom ability models in game, you may need to attain a certain hero level or trigger certain events to spawn the units.   
  
* You can now use the Demo Mode option buttons in the workshop tool.
* You can force a hero to level up by clicking the Level Up or Level to Max buttons or opening the game console and entering "sv_cheats 1" and then using "dota_dev hero_level <number>" in the console or entering "-lvlup <number>" in the in-game chat.
* Clicking the Free Spells or Refresh buttons or entering the console command "dota_ability_debug 1" will remove ability cooldowns so you can quickly recast spells.
* Most units can simply be spawned by clicking its ability icon or using the corresponding hotkey once your hero has attained the necessary level.
* Some units require a specific combination of levels, abilities or events to spawn:
* To spawn Invoker's Forged Spirit, you need to have 1 instance of Quas and 2 instances of Exort. Then you select the Invoke ability, which creates an option to spawn a Forged Spirit.
* To spawn Broodmother's Spiderlings, you need her Spawn Spiderlings Ultimate ability, then you need to cast this ability onto an enemy just before they die to spawn the Spiderlings.
* To test the different level colors of Dragon Knight's Elder Dragon, you will need to level up the hero incrementally. You can also view the different materials by using the 'Texture' drop-down in the Preview Model page of the workshop tool.
  
  
​  
  
---
  
  
  
  
## SUBMITTING ABILITY MODELS 
* Refer to the [Submitting Items](https://help.steampowered.com/en/faqs/view/3E00-D38F-B793-7384) page for important general information about testing and submitting items.
* Ability models are submitted under the "Hero Item" category.
  
  
![http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/ability_models/ability_submission.jpg](http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/ability_models/ability_submission.jpg)  
  
* It is no longer necessary to maintain our file structure when preparing your item files. The workshop tool will place your files where they need to go.
  
  
​  
  
---
  
  
## 
## ITEM TROUBLESHOOTING
* If you have problems testing or submitting your item, see our [Item Troubleshooting](https://help.steampowered.com/en/faqs/view/5D5F-A5BD-C25B-7205) page.
  
  
[Dota 2 Item Workshop Guidelines Homepage](http://www.dota2.com/workshop/)
# Dota 2 Workshop - NPC Animations
Updated 2022-07-06 20.40.12  
Version 5  

![http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/smeevil_crop.jpg?v=1459382400](http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/smeevil_crop.jpg?v=1459382400)  
  

* [NPC OVERVIEW](#overview)
* [DEFAULT AND CUSTOM NPC ANIMATIONS](#default)
* [HEAD ORIENTATION IN GAME VIEW](#orientation)
* [ANIMATION CYCLES](#cycles)
* [ACT_DOTA_SPAWN](#spawn)
* [ACT_DOTA_IDLE](#idle)
* [ACT_DOTA_RUN](#run)
* [ACT_DOTA_DIE](#die)
* [ACT_DOTA_CAPTURE](#capture)
* [ACT_DOTA_LOADOUT](#loadout)
* [ACT_DOTA_ATTACK](#attack)
* [ACT_DOTA_CAST_ABILITY_#](#ability)
* [RARE ANIMATIONS - IDLE, CAPTURE, and LOADOUT](#rare)
* [TURN ANIMATIONS](#turn)
* [ANIMATION ACTIVITIES](#activities)

  
  
## [](id=overview)
## NPC OVERVIEW
Any unit that is not a hero can be referred to as an NPC or Non-Player Character. Dota uses many types of customizable NPCs that require animations:  
  

* [Couriers](https://support.steampowered.com/kb/8986-WRAZ-1046/dota-2-workshop-couriers)
* [Sentry/Observer Wards](https://support.steampowered.com/kb/8799-WLXN-3860/dota-2-workshop-wards)
* [Ability Models](https://support.steampowered.com/kb/7823-RUAZ-5739/dota-2-workshop-ability-models-summoned-units) (ultimates, True Forms, summons units, and ability wards that are used by specific heroes).

  ##   
## [](id=default)
## DEFAULT AND CUSTOM NPC ANIMATIONS

* A full set of custom animations must always be provided for Couriers and Wards.
* Ability Models have the option to use some or all of Valve's animations if the skeleton is the same as our default.
* A totally new set of custom animations must be provided if a new skeleton is created for an Ability Model.
* More information about animation requirements for ability models can be found on the [Ability Model page](https://help.steampowered.com/faqs/view/2ABE-09A8-DB83-3327).

  ##   
## [](id=orientation)
## HEAD ORIENTATION IN GAME VIEW

* It is helpful if idles, runs, and other important animations have the NPC's head or prominent features tilted slightly upward to read better from above in game view.
* If the NPC you are authoring has options for capture (portrait) or loadout animations, these can be animated with the head at a normal angle

  
  
## ​[url id=cycles][/url]
## ANIMATION CYCLES

* Non-looping animations play once, starting and ending in very different poses and actions.
* Looping animations play in repeating cycles and must have a matching start and end pose.
* It's also helpful if the movements near the end and start of looping animations are designed to smoothly transition into each other. Extreme movements or poses near the start or end of looping animations can cause a jarring transition when the cycle repeats.
* Non-looping animations usually have to transition to a looping idle at the end of the sequence, so the requirements for matching poses and smooth movements apply.

  ##   
## [](id=spawn)
## ACT_DOTA_SPAWN 

* Spawn animations are played when an NPC first appears in game.
* Spawning characters can emerge from the ground, fall from the sky, or fly into the scene from outside the map.
* If you want your full spawn animation to play, it's best for this animation to be short, 30 frames maximum. Otherwise, if the NPC is given a command immediately after it spawns, the animation for the new behavior will cut off the spawn animation.
* You could do a longer spawn animation if you are not concerned about interruptions but please try to keep the duration under a few seconds.
* Regardless of duration, it's best for spawn animations to have one clear action instead of multiple, complicated movements.
* Don't have very extreme movements or poses near the end of the spawn, otherwise there will be a jarring transition to the idle animation that follows the spawn.

  ##   
## [](id=idle)
## ACT_DOTA_IDLE

* Idle animations need to repeat in a looping cycle, with matching start and end poses.
* Idle animation plays while the NPC stays in one place, waiting for a command to move or react.
* Because idles are seen so often, rather than just have one simple cycle that mechanically repeats over and over, it's helpful, once you've established a cycle, to put several cycles together into one long sequence in your animation software and then add slight variations to body and head attitudes to make the character look more organic and alive. These variations should not be extreme, otherwise it will be very obviously repetitive when the animation loops. Extreme idle variations should be saved for rare idle animations, explained below.

  ## [](id=run)
## ACT_DOTA_RUN 

* This activity is for the animation your NPC will use for any type of walking or running movement.
* If you are trying to match a specific movement speed, animation should travel forward at this rate every second.
* Movement speeds vary with the type of NPC and with certain circumstances that affect movement speed, like haste, levelling, injured states and spells cast by other heroes. Test your NPC in game to make sure your run animations will work well at different speeds.
* Run animations should be prepared with the character moving forward. Our animation system will automatically extract the motion along its forward movement axis and apply the different speeds required by the game.
* Because NPCs often transition between idle and run animations, it's helpful if the two animations have similar core body positions.
* Sentry/Observer Wards or Hero Wards, such as Venomancer Plague Wards, do not need run animations because they are always rooted in one place.

  ## [](id=die)
## ACT_DOTA_DIE

* This animation is used when the NPC is killed. Normally the death animation ends once the character comes to rest on the ground.
* Flying couriers require special handling for death animations. For more details, go to the [Courier](https://support.steampowered.com/kb/8986-WRAZ-1046/dota-2-workshop-couriers#death) page.
* There is no need to sink any NPCs except flying couriers into the ground after they die, the game code will handle this.

  
  
 [url id=capture][/url]  
  
##  ACT_DOTA_CAPTURE 

* This is the looping animation, also known as portrait, that will play in the portrait frame when the NPC is selected in game.
* Idle animation is used for the portrait if separate capture animation is not provided, but often the idle movements that read well in game view can be too extreme for the small portrait frame.
* Capture animation can be created by making a copy of the idle animation and reducing the amount the NPC's body moves.
* If you have adjusted the angle of the head to face upward for the in-game idle, the head can be returned to a normal angle for the capture animation.
* Rare capture animation can help provide variety and interest - see below.

  
  
## [](id=loadout)
##  ACT_DOTA_LOADOUT

* This is the looping animation that will play in the loadout when you are selecting and previewing NPCs or hero items.
* Idle animation is used for the loadout if separate loadout animation is not provided, but sometimes different or more detailed animation is preferred for the closeup view in the loadout.
* Portrait animation can be created by making a copy of the idle animation and adding changes or enhancements.
* If you have adjusted the angle of the head to face upward for the in-game idle, the head can be returned to a normal angle for the loadout animation.
* In the case of flying couriers, you may want to adjust their flying height in a dedicated loadout idle animation (and rare idle if applicable) so they display at a good height in the loadout.
* Rare loadout animation can help provide variety and interest - see below.

  ##   
## [](id=attack)
## ACT_DOTA_ATTACK 

* If your Ability Model NPC can attack another unit, it will need at least one attack animation.

  ## [](id=ability)
## ACT_DOTA_CAST_ABILITY_# 

* If your Ability Model NPC has active abilities it can cast, you will need to create these animations if you are replacing the default animations.

  ## [](id=rare)
## RARE ANIMATIONS - IDLE, CAPTURE, and LOADOUT

* Rare animations will play once, randomly, if your NPC has been playing an idle animation with no commands for a while.
* These alternate animations help break up the repetition of the idles and make the characters more interesting and life-like.
* Rare animations can range from a simple head turn to a full body movement.
* Rare animations should have one clear idea that is well executed. This is preferable over trying to fit in many complicated ideas and actions that may be confusing or that may too time consuming to finish at a good quality level.
* Not all NPCs have options for rare animations but if they are offered, using these to add a bit of variety can increase the appeal of your character.

  ##   
## [](id=turn)
## TURN ANIMATIONS

* Though optional, these right, left, and center poses are very helpful for generating smooth transitions during turns, especially for horizontal or long creatures that can otherwise look somewhat mechanical when turning.

  
  
## [](id=activities)
## ANIMATION ACTIVITIES

* Dota 2 Workshop animation activities are now determined by how the animation files are input through the workshop tool UI. The initial iteration of the Dota 2 Workshop required artists to edit qc text files to assign activities to animation sequences but qc text file editing is no longer required. Bear this in mind if you see references to the qc process in developer websites or in the workshops of other Valve games.

  
  
[Dota 2 Item Workshop Guidelines Homepage](http://www.dota2.com/workshop/)
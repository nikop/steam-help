# Dota 2 Workshop - Couriers
Updated 2021-08-28 01.26.51

![http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/couriers/courier.jpg](http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/couriers/courier.jpg)  
  

* [COURIER CONCEPT CONSIDERATIONS](#concept)
* [EYE FOCUS](#eyefocus)
* [COURIER MODELS](#models)
* [COURIER SCALE](#scale)
* [COURIER TEXTURES](#textures)
* [COURIER ANIMATION OVERVIEW](#animation)
* [COURIER SPAWN ANIMATION](#spawn)
* [COURIER MOVEMENT ANIMATION](#movement)
* [FLYING COURIER HEIGHT AND DEATH ANIMATION](#death)
* [HITBOXES](#hitboxes)
* [ATTACHMENT POINTS](#attachments)
* [SUBMITTING COURIERS](#submitting)
* [ITEM TROUBLESHOOTING](https://help.steampowered.com/en/faqs/view/5D5F-A5BD-C25B-7205)
* [REFERENCE DOWNLOAD](#download)

  
  
## [url id=concept][/url]
## COURIER CONCEPT CONSIDERATIONS

* Make sure the courier's face or prominent features can be clearly seen from above in game view.
* Our artists review couriers by how they look in game, so please put as much effort into the in-game view as you do for their appearance in the loadout.
* Make sure your courier can't be confused with a hero or ability model because it has too many design, size, proportion, or animation similarities. Our demi hero couriers have enough differences from the actual heroes to avoid this problem.

  
  
![http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/couriers/skippy_parrot_large.jpg](http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/couriers/skippy_parrot_large.jpg)  ![http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/couriers/smeevil_mammoth_large.jpg](http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/couriers/smeevil_mammoth_large.jpg)  ![http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/couriers/seekling_large.jpg](http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/couriers/seekling_large.jpg)  
  
![http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/couriers/mega_greevil_courier_large.jpg](http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/couriers/mega_greevil_courier_large.jpg)  ![http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/couriers/mechjaw_large.jpg](http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/couriers/mechjaw_large.jpg)  ![http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/couriers/octopus_large.jpg](http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/couriers/octopus_large.jpg)  
  

* For more information about important general item design concepts, such as harmonious colors, values and areas of detail and rest, please see our [Character Art Guide.](https://help.steampowered.com/en/faqs/view/0688-7692-4D5A-1935)

  
  

---
  
  
[url id=eyefocus][/url]  
  
## EYE FOCUS

* The design of the eyes can determine a large part of a courier's visual appeal.
* Unfocused, sideways aiming eyes (left) may look more like those of an actual creature but aren't very appealing.
* Focused and forward aiming eyes (right) are much more appealing because of their similarity to human eye focus.
* If the eyes are very prominent and detailed, be sure to give this part of the model ample texture space.

  
  
![http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/couriers/eyes_unfocused3.JPG](http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/couriers/eyes_unfocused3.JPG)  ![http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/couriers/eyes_focused3.JPG](http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/couriers/eyes_focused3.JPG)​  
  

---
  ##   
## [url id=models][/url]
## COURIER MODELS

* Couriers require both a walking AND a flying model.
* There is a limit of 60 bones for each model.
* Both models can have two LOD (level of detail) meshes
* LoD0 is optional, is displayed in the portrait, loadout and closeup showcase views and is limited to 3500 triangles
* LoD1 is required, is used in-game and is limited to 3000 triangles or fewer ideally.
* Please note that our budgets refer to triangles, not polygons.
* It is helpful if you tessellate your model into triangles before submission to confirm that the final mesh is what you intend. Otherwise our tools will triangulate the mesh but may have different results from what you'll see using your software.
* Our game is only able to support the skinning of 4 vertices per joint. Skinning to additional vertices will be removed or will cause a failure when community items go through our workshop compiler.
* Please make sure the bind pose for your courier model is oriented upright and facing forward. This orientation determines the placement of the hitboxes.

  
  
![http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/couriers/courier_orientation_incorrect.jpg?](http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/couriers/courier_orientation_incorrect.jpg?)  ![http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/couriers/courier_orientation_correct.jpg](http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/couriers/courier_orientation_correct.jpg)  
  

* It helps differentiation in game if the flying courier has some change in the model, animation pose or both rather than just being a floating version of the ground courier.
* For general information about workshop models, go to [Workshop Item Model Requirements](https://help.steampowered.com/en/faqs/view/5FB8-4078-8B2A-C52B)

  
  

---
  
  
[url id=scale][/url]  
  
## COURIER SCALE

* The Donkey default courier that is provided as a reference is quite large and most couriers need to be smaller than this. Keep this in mind when establishing the size of the courier model.
* It's helpful early in your authoring process to bring a static mesh of your courier into game weighted to just one root bone to assess its size against heroes, creeps and the environment. If a scale change is needed, it's easier to do this before the courier is fully weighted, rigged, and animated.
* Flying couriers are closer to the game view camera, so they can appear much bigger than the ground couriers and may require a reduction in scale.

  
  
​  
  

---
  
  
[url id=textures][/url]  
  
## COURIER TEXTURES

* Both the ground and the flying models must share the same single 512H x 512W texture.
* For Dota specific guidelines about colors and values for textures, see the [Character Art Guide](https://help.steampowered.com/en/faqs/view/0688-7692-4D5A-1935)
* For information about authoring Dota materials, see the [Shader Masks guide](https://help.steampowered.com/en/faqs/view/299C-D7F9-09A5-98B6)
* Workshop couriers use our default courier material which was revised in early 2016 to have a Spec Exponent that is 30 and a Spec Intensity that is 3.

  
  
​  
  

---
  
  
[url id=animation][/url]  
  
## COURIER ANIMATION OVERVIEW

* Custom couriers require entirely custom skeletons and animations.
* Couriers are upgraded to flying as quickly as possible during gameplay, so it is best to concentrate most of your time and creative ideas on the flying version of your courier.
* It may help to orient the animation of the head or primary features to face slightly upwards so that they read better from above in game view. Some bird characters can achieve this by using bird-like movements to tilt the head to look upward with first one eye and then the other.
* If you do upward-oriented animations for game view the courier's portrait and loadout animations can be adjusted to have the head at a normal angle.
* The sections below have details about courier-specific animation needs
* For other general animation guidelines, please see [NPC Animation](https://help.steampowered.com/en/faqs/view/7880-740F-641A-6D50).

  
  
​  
  

---
  
  
[url id=spawn][/url]  
  
## COURIER SPAWN ANIMATION

* Only the ground couriers are seen spawning in game.
* Flying couriers do not need spawn animations, they just appear playing their idle, rising up from the ground.

  
  
​  
  

---
  
  
[url id=movement][/url]  
  
## COURIER MOVEMENT ANIMATION

* Run animations should be prepared with the courier moving forward. Our animation system will automatically extract the motion along its forward movement axis and apply the different speeds required by the game.
* Because couriers often transition between idle and run animations, it's helpful if the two animations have similar core body positions.
* Flying couriers move more quickly than walking couriers but these speeds are often adjusted for balance. Test both versions in game to make sure your animations work well with the current movement speeds.
* The flying courier will briefly move much faster when it is given a speed burst, also known as haste.
* An optional haste animation can be submitted that shows the courier with a different body attitude and animation communicating that it is flying much faster.
* If a courier is some kind of floating creature for both the ground and flying versions, it helps differentiation in game if the flying animations are not simply exact copies of the ground animations.
* You should animate the flying version at ground level for all but the death animation. This is necessary because the flying courier is raised off the ground via game code by 160 units.

  
  
​  
  

---
  
  
[url id=death][/url]  
  
## FLYING COURIER HEIGHT AND DEATH ANIMATION

* All animations for flying couriers should be located at the same height from the ground as walking couriers. This is because the game engine will raise the couriers to their flying height.
* For the death animation of a flying courier, you have the option of having the courier fly far away into the air, like the death animation for the default Donkey courier, or have it crash onto the ground.
* If you want your flying courier to crash to the ground upon death:
* The flying death animation needs to start with the courier at ground level, in the same position as its flying run or flying idle animation.
* When the flying courier falls, the point of the animation where the flying courier makes "ground" contact requires the courier's body to be located -160 units in the vertical axis below the position where the flying death animation begins.
* Sinking into the ground does not happen automatically in the game engine after flying courier deaths because some of them fly up into the sky when they die. You will need to add the sinking to your flying death animation.
* Once the flying courier has crashed and become still at the -160 units "ground" location, keep it static there for two seconds.
* Then, slowly sink the dead flying courier well below the -160 unit "ground" location over the course of two more seconds.
* The final height at the end of the death animation will be whatever is needed to move all of the courier's body BELOW the -160 unit level.
* There is no need to sink ground couriers or other NPCs into the ground after they die, the game code will handle this automatically.

  
  
​  
  

---
  
  
[url id=hitboxes][/url]  
  
## HITBOXES

* Hitbox creation by community artists is not currently supported for the Source 2 Dota Workshop. These are created by Valve artists once a courier is accepted for the game.
* Temporary generic hitboxes are created by the workshop tool when you test your courier in demo mode so that it can be selectable. These are not the final hitboxes.

  
  
​  
  

---
  
  
[url id=attachments][/url]  
  
## ATTACHMENT POINTS

* Eye and hit location attachments are needed for couriers.
* Eye attaches are necessary because unusual effects may be applied to the courier.
* Hit location attachments (known as attach_hitloc) determine where attack particles from enemies will strike the courier.
* For the best attack particle trajectory, the attach_hitloc needs to be above the center of the courier, near the chest or head.
* In the workshop tool, you will need to select the bones that these attaches will bind to.
* After the courier is compiled, you'll have the option to adjust the attach position or orientation if necessary.
* If you position eye attaches on eye joints that have animation, be aware that eye particles will rotate and move with the eye animation, which is not desirable.
* If your courier does not have joints near its eyes or the eye joints are animated, you will need to apply both of the eye attaches to the courier's head joint and then position these attaches out to align with each of the model's eyes.
* Make sure that the TX of each eye attach faces generally forward so that the eye particles (if they are added) aim in front of the courier.
* If your courier does not have eyes, place the left and right eye attaches somewhere else on the courier that could work as locations for unusual eye particles, such as horns, ears, elbows, or wings.
* Details about designating and editing attachments in the workshop tool can be found on the [Submitting Items](https://help.steampowered.com/en/faqs/view/3E00-D38F-B793-7384) page.

  
  
![http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/couriers/courier_eye_attach.JPG](http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/couriers/courier_eye_attach.JPG)​  
  

---
  
  
[url id=submitting][/url]  
  
## SUBMITTING COURIERS 

* Refer to the [Submitting Items](https://help.steampowered.com/en/faqs/view/3E00-D38F-B793-7384) page for important general information about testing and submitting items.
* If you wish to design separate radiant and dire couriers with either totally different models or just two different color styles, these need to be two separate courier submissions.
* It is no longer necessary to maintain our file structure when preparing your item files. The workshop tool will place your files where they need to go.

  
  
​  
  

---
  
  
# ITEM TROUBLESHOOTING

* If you have problems testing or submitting your courier, see our [Item Troubleshooting](https://help.steampowered.com/en/faqs/view/5D5F-A5BD-C25B-7205) page.

  
  

---
  
  
[url id=download][/url]  
  
## REFERENCE DOWNLOAD

* Download the [Donkey Courier](http://media.steampowered.com/apps/dota2/workshop/courier.zip) model (5.8 MB)

  
  
[Dota 2 Item Workshop Guidelines Homepage](http://www.dota2.com/workshop/)  
  

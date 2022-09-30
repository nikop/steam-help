# Dota 2 Workshop - Hero Wearable Items
Updated 2021-08-12 21.02.53

  
  
![http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/hero_wearables/luna_sets.jpg](http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/hero_wearables/luna_sets.jpg)  
  

* [WEARABLE ITEM TYPES AND ITEM SETS](#types)
* [WEARABLE ITEM TECHNICAL REQUIREMENTS](#requirements)
* [WEARABLE ITEM TESTING AND SUBMISSION](#submission)
* [SPECIAL WEARABLE ITEM CONSIDERATIONS](#considerations)

  
  
## [url id=types][/url]
## WEARABLE ITEM TYPES AND ITEM SETS

* Hero wearable items can be:
* Clothing
* Helmets and Armor
* Weapons
* Mounts ridden by the hero
* ​Each hero has several "slots" that can be equipped with a variety of items. The number of slots and types of items vary for each hero.
* ​A full set of wearable items for a hero can be displayed on the Steam Dota workshop as a collection.
* In game, a collection of wearable items for a hero is known as an "item set".
* The images above show various item sets available for Luna that use Head, Weapon, Offhand Weapon (shield), Shoulder, and Mount item slots.

  ##   
## [url id=requirements][/url]
## ​WEARABLE ITEM TECHNICAL REQUIREMENTS

* Hero wearable items - including mounts - use the hero's default skeleton, joint position, cloth, material settings, and animations.
* Hero wearable items need to be weighted to hero skeletons provided by Valve.
* Valve's hero reference models as well as information about each hero's item slots, texture and model budgets, and specific authoring requirements can be found through the [Hero Resource](http://www.dota2.com/workshop/requirements) page.
* Please note that our budgets refer to triangles, not polygons.​
* It is helpful if you tessellate your model into triangles before submission to confirm that the final mesh is what you intend. Otherwise our tools will triangulate the mesh but may have different results from what you'll see using your software.
* Our game is only able to support the skinning of 4 vertices per joint. Skinning to additional vertices will be removed or will cause a failure when community items go through our workshop compiler.
* When creating hero items, be very aware of how the values, color palettes, gradients, and texture details of your items affect hero readability in game.
* You can differ from default colors and silhouettes as long as your items still support the hero's identification. For more details, please see our updated [Character Art Guide](https://support.steampowered.com/kb/9334-YDXV-8590/dota-2-workshop-character-art-guide).
* ​Refer to the Asset Creation guidelines on the [Dota 2 Item Workshop Guidelines Homepage](http://www.dota2.com/workshop/) for general information about authoring models and textures.

  ##   
## [url id=submission][/url]
## WEARABLE ITEM TESTING AND SUBMISSION

* Refer to the [Submitting Items](https://help.steampowered.com/en/faqs/view/3E00-D38F-B793-7384) page for important general information about testing and submitting items.
* There will be specific instructions within the tool or in the hero's resource page if there are special requirements for authoring, testing, or submitting a hero item, such as a Nightstalker day/night item or a weapon for Leshrac.
* You'll need to submit each hero item separately and save a separate workshop session for each one.
* Once you have taken each of the items in your set as far as the model compile in the workshop tool, you can preview your hero wearing all the items you created by using "Select Wearables" on the Preview Models page. All of your items must be compiled in the workshop tool first in order to generate the vmdls needed for previewing and in-game testing.
* Your "Select Wearables" choices will be stored when you save your workshop session file. You can clear out your custom item selection by choosing "Reset to Default" in the "Select Wearables" pane.
* You'll be able to put a full set of hero items into a [collection](https://help.steampowered.com/en/faqs/view/3E00-D38F-B793-7384#collection) after they're submitted to the workshop.
* If you have technical problems testing or submitting your hero items, please see our [Item Troubleshooting](https://help.steampowered.com/en/faqs/view/5D5F-A5BD-C25B-7205) page

  ##   
## [url id=considerations][/url]
## SPECIAL WEARABLE ITEM CONSIDERATIONS

* Certain heroes have opportunities for item textures to display different colors or motion effects. For more information, see [Authoring Arcana, Ability and Ambient Textures](https://support.steampowered.com/kb/9942-EIPV-2211/dota-2-workshop-authoring-items-to-work-with-arcanas-and-gems).
* We may request low-violence versions of some items. Some heroes have low-violence base models that need to be considered when creating items. For more information, see [Low Violence Items.](https://help.steampowered.com/en/faqs/view/266F-8F7F-55FA-63FA)
* Some hero weapons require an effects model that allows Valve's default weapon effects (flames, glows, etc) to follow the custom shape of your weapon. For more information, see [Item Effects Models](https://support.steampowered.com/kb/9875-WEUP-5451/dota-2-workshop-item-effects-models).
* Some thrown weapons like Pudge's hook, Enchantress' spear, and Huskar's spear have the option for a weapon swap that allows the custom model to fly through the air during an attack or ability. This swap is enabled by a Valve particle effect that requires these weapons to be authored at the origin and have the same orientation and size as the hero's default weapon in order to display properly in game. Please refer to the hero reference files available through the [Hero Resource](http://www.dota2.com/workshop/requirements) page.

  
  
[Dota 2 Item Workshop Guidelines Homepage](http://www.dota2.com/workshop/)  
  

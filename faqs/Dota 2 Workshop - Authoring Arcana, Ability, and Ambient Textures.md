# Dota 2 Workshop - Authoring Arcana, Ability, and Ambient Textures
Updated 2021-10-28 01.24.11

![{STEAM_CLAN_IMAGE}/1976/4a2cbaf07bd6b8ab4c5fe2ef7810d20450d32858.png]({STEAM_CLAN_IMAGE}/1976/4a2cbaf07bd6b8ab4c5fe2ef7810d20450d32858.png)  
  

* [Detail Mask Overview](#overview)
* [Terrorblade - Arcana and Ambient Textures](#terrorblade)
* [Legion Commander - Arcana Textures](#legion)
* [Phantom Assassin - Arcana Textures](#phantom)
* [Lone Druid - Ability Textures](#druid)
* [Earthshaker - Ability and Ambient Textures](#earthshaker)
* [Sven - Ability Textures](#sven)
* [Rubick Ambient Textures](#rubick)
* [Lycan Ultimate Ambient Textures](#lycan)
* [Razor Ambient Textures](#razor)

  
  
[url id=overview][/url]  
  
## Detail Mask Overview

* If you are making items for heroes that have colored, glowing, or scrolling Arcana, ability, or ambient textures, you can add to the appeal of your items by authoring them to react to these.
* Arcana textures can display on a hero's other items when an Arcana item is equipped.
* Ability textures display only when a hero casts a certain ability spell.
* Ambient textures display constantly, such as the texture flames on Chaos Knight's items but other heroes use this in a more subtle way that is still effective.
* Only Valve creates Arcana items but community artists have the option to make their item textures react when an Arcana is equipped.
* Arcana, ability, and ambient textures are accomplished through a combination of greyscale detail masks that community artists can author and Valve's default detail maps and default material settings that determine additional coloring, texture scrolling speed, and cubemaps among other things.
* If properly authored detail masks and color textures are not provided by the community artist, a workshop item will not display Arcana, ability, or ambient textures or colors.
* A detail mask will only work on a custom item if the hero's default or Arcana material has a detail mask enabled. It must use the Valve's default detail map for that hero.
* The strength or subtlety of the hues in an artist's color texture and the values in an artist's detail mask determine how vigorously the Arcana, ability, or ambient textures will display on their items.
* Valve artists have sometimes added detail masks to workshop items to help them display Arcana textures but moving forward we prefer that the community artists have the awareness of this need and provide the detail masks themselves.
* The item workshop submission tool is not currently able to let artists activate arcana textures on their items, but they will be able to preview ability and ambient textures.
* The links below will explain detail mask options for several heroes and Arcanas. Not all applicable heroes or items are covered but these examples should give an idea of practices that can be used in other situations.

  
  
​  
  

---
  ##   
## [url id=terrorblade][/url]
## Terrorblade - "Fractal Horns of Inner Abysm" Arcana and Ambient Textures

* Terrorblade's Arcana has an option to display alternate colors by using different Prismatic Gems.
* The Arcana uses Terrorblade's Head slot, but you have the option to author a detail mask for your head item so it can react to Terrorblade's default scrolling texture and blue-green ambient color when the Arcana is not equipped.
* Strong color or white in an artist's color texture means that a Terrorblade item will retain this coloring or the white areas regardless of how the detail mask is authored or what color Arcana or gem is applied. It is up to community artists to decide how much base item color or white is to remain when an Arcana or gem color is active and author the color and detail masks accordingly.
* The default detail map used for Terrorblade is white and grey to allow Arcanas, gems, and Terrorblade's default blue-green ambient to provide different colorings.
* All Terrorblade workshop items with detail masks will use this default scrolling detail map.

  
  
Terrorblade default detail map, weapon color, detail mask, and model display.   
  
Dark and desaturated color combined with a high contrast detail mask creates one strong outline that will cleanly display the Arcana colors and scrolling textures beneath the Arcana particles. The image on the right shows both the blue (default) and red (Arcana) coloring and scrolling texture applied to the detail mask areas.  
  
![{STEAM_CLAN_IMAGE}/1976/963303f5885c0239d5318c9568ef0d680e5fdfef.png]({STEAM_CLAN_IMAGE}/1976/963303f5885c0239d5318c9568ef0d680e5fdfef.png)  
  
Terrorblade default detail map, head color, detail mask, and model display.   
  
Even though the head item is replaced for the Arcana, the default head item still uses a detail mask to display the default ambient scrolling texture on the horns when the arcana is not equipped. Strong greenish coloring is retained from the color texture.  
  
![{STEAM_CLAN_IMAGE}/1976/32b32dc854f7747f30dfc80d2659378852cf96e0.png]({STEAM_CLAN_IMAGE}/1976/32b32dc854f7747f30dfc80d2659378852cf96e0.png)  
  
Terrorblade default detail map, demon color, detail mask, and game display.   
  
The demon's very dark and desaturated color texture is designed to totally take its color from the Arcana, gems, or Terrorblade's default blue-green ambient. Combined with a detail mask that has small, fine details in a mix of strong and soft values means there will be a variety of added color and scrolling textures all over the demon's body.  
  
![{STEAM_CLAN_IMAGE}/1976/4ed404b384b6fd501ecf0f281d24a3cc6a9b958c.png]({STEAM_CLAN_IMAGE}/1976/4ed404b384b6fd501ecf0f281d24a3cc6a9b958c.png)  
  

---
  ##   
## [url id=legion][/url]
## Legion Commander - "Blades of Voth Domosh" Arcana

* This Arcana uses Legion Commander's weapon slot, changing from single weapon to dual wield swords.
* Because of this, there's no need to add an Arcana detail mask to a custom Legion Commander spear - it will never be used with the Arcana.
* Some of Legion Commander's default items have detail masks to pick up the Arcana texture when that item is equipped. The detail masks do not react when there is no Arcana.
* All Legion Commander workshop items with properly authored detail masks will use Valve's detail map and materials when the Arcana is equipped.

  
  
Legion Commander's Arcana detail map, banner color, detail mask, and game display  
  
![{STEAM_CLAN_IMAGE}/1976/8070052f401622d867547209ae17a5f95a089828.png]({STEAM_CLAN_IMAGE}/1976/8070052f401622d867547209ae17a5f95a089828.png)  
  

---
  
  
[url id=phantom][/url]  
  
## Phantom Assassin - "Manifold Paradox" Arcana Textures

* Phantom Assassin's Arcana uses the weapon slot, changing from single weapon to dual wield swords.
* Some of Phantom Assassin's default items have detail masks to pick up the Arcana texture when that item is equipped. The detail masks do not react when there is no Arcana.

  
  
Phantom Assassin's Arcana detail map, default helmet color, detail mask, and game display  
  
![{STEAM_CLAN_IMAGE}/1976/f3b79f287152d23339f6cbd7129360341e18b32c.png]({STEAM_CLAN_IMAGE}/1976/f3b79f287152d23339f6cbd7129360341e18b32c.png)  
​  
  

---
  
  
[url id=druid][/url]  
  
## Lone Druid - "Rabid" Ability Texture

* This ability displays a brightly glowing design that sits on top of a dark or medium valued color texture.
* The Rabid texture does not display well on top of white or very light base colors, so keep this in mind when designing the color texture for your items.
* The detail masks for Lone Druid's wearable items, Spirit Bear, and True Form are high contrast and focused on just a few areas.
* Don't author the detail mask to use an even, overall Rabid coloring on the Spirit Bear or True Form - this could look broken or cause confusion with other spell effects.
* Because the Rabid effect is an important visual cue for gameplay, have the areas that display the Rabid texture easily viewable from above in game view.

  
  
True Form color texture, detail mask, and Rabid texture game display  
  
![{STEAM_CLAN_IMAGE}/1976/29393d3951d80dec7e4c723a8c99a49ae8a8f241.png]({STEAM_CLAN_IMAGE}/1976/29393d3951d80dec7e4c723a8c99a49ae8a8f241.png)  
  
Spirit Bear color, detail mask, and Rabid game display  
  
![{STEAM_CLAN_IMAGE}/1976/5d4200e8bc09ac9d9e8db250d0118e764e437bba.png]({STEAM_CLAN_IMAGE}/1976/5d4200e8bc09ac9d9e8db250d0118e764e437bba.png)  
  

---
  ## [url id=earthshaker][/url]
## Earthshaker - "Enchant Totem" Ability and Ambient Textures

* Earthshaker's totem has a subtle scrolling ambient texture that constantly displays in the item's surface decorations.
* This turns into a vivid glowing scrolling texture when he uses his Enchant Totem ability.

  
  
![{STEAM_CLAN_IMAGE}/1976/650e3e5a77c8c47d960c7d04cc4b0ce650d13a4c.png]({STEAM_CLAN_IMAGE}/1976/650e3e5a77c8c47d960c7d04cc4b0ce650d13a4c.png)  
  
![{STEAM_CLAN_IMAGE}/1976/5b205d31083b09213cd915780ac2d5f1ae38561d.png]({STEAM_CLAN_IMAGE}/1976/5b205d31083b09213cd915780ac2d5f1ae38561d.png)  
  

---
  
  
[url id=sven][/url]  
  
## Sven - "God's Strength" Ability Texture

* This ability affects textures in two ways:
* It changes blue areas of Sven's body and items to a strong red color
* It adds a scrolling gold texture to areas defined by the detail mask
* Any blue areas on your color textures that match Sven's default blue will turn red during this ability.
* It's best to use the detail mask for small, focused areas of each item rather than overwhelm too much of the surface with the gold texture.
* The gold scrolling texture will work best if it's against dark values on the color texture.
* Items with detail masks will use Valve's default gold detail map for Sven.

  
  
Sven's God's Strength detail map, sword color, detail mask, and game display  
  
![{STEAM_CLAN_IMAGE}/1976/0bb1b6beb8308749b721635a6a6f3cb5d14aaad3.png]({STEAM_CLAN_IMAGE}/1976/0bb1b6beb8308749b721635a6a6f3cb5d14aaad3.png)  
  

---
  
  
[url id=rubick][/url]  
  
## Rubick - Ambient Detail Map

* This ambient, scrolling detail map of green bubbles displays constantly on Rubick items authored with a detail mask.

  
  
Rubick detail map, robe color, detail mask, and game display  
  
![{STEAM_CLAN_IMAGE}/1976/d7266ec18e20cc3812a0fed74363b42e2fa16b96.png]({STEAM_CLAN_IMAGE}/1976/d7266ec18e20cc3812a0fed74363b42e2fa16b96.png)  
  

---
  
  
[url id=lycan][/url]  
  
## Lycan - Ultimate Ambient Detail Map

* This ambient scrolling texture for Lycan's Ultimate displays constantly.
* The detail mask is very faint but covers a large area and is very visible in game.

  
  
Lycan's Ultimate detail map, color, detail mask, and in-game display.  
  
![{STEAM_CLAN_IMAGE}/1976/34c35c35e3099ee6805f4eb02f5a88f18aa3fd3e.png]({STEAM_CLAN_IMAGE}/1976/34c35c35e3099ee6805f4eb02f5a88f18aa3fd3e.png)  
  

---
  
  
[url id=razor][/url]  
  
## Razor - Ambient Detail Map

* This ambient detail map of purplish electrical lightning displays constantly on Razor's base arms and any items authored with detail masks.

  
  
Razor detail map, body color, detail mask, and model display  
  
![{STEAM_CLAN_IMAGE}/1976/3fecbb502e3c4f5c37851bf248f13205a0a65918.png]({STEAM_CLAN_IMAGE}/1976/3fecbb502e3c4f5c37851bf248f13205a0a65918.png)  
  
After reading through these notes, look again at how Arcana, Ability, and Ambient textures are displayed on these and other Dota heroes - you'll have much more insight about how these texture enhancements were accomplished.  
  
[Dota 2 Item Workshop Guidelines Homepage](http://www.dota2.com/workshop/)  
  

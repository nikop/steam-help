# Dota 2 Workshop - Item Shader Masks
Updated 2021-10-28 01.43.57

![http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/shaders/ogre_magi_base_items.jpg?v=1459382400](http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/shaders/ogre_magi_base_items.jpg?v=1459382400)  
  

* [OVERVIEW](#overview)
* [SOURCE 1 TEXTURE AND SHADER MASK CONVERSION](#source1)
* [SOURCE 2 TEXTURES AND SHADER MASKS](#source2) 
* [Color Map](#color)
* [Transparency](#transparency)
* [Normal Map](#normal)
* [Detail Mask](#detail)
* [Metalness Mask](#metalness)
* [Self Illumination Mask](#selfillum)
* [Specular Mask](#specular)
* [Rimlight](#rimlight)
* [Base Tint Mask](#basetint)
* [Specular Exponent](#exponent)
* [Diffuse Mask (rarely used)](#diffuse)
* [TEXTURE BUDGETS AND RESOLUTION](#budgets)

  
  
[url id=overview][/url]  
  
## OVERVIEW

* The hero shader in Dota 2 is extremely powerful, capable of many high-end material properties. Every hero, item, courier, and creep makes use of the shader. Each texture works in conjunction with all the others.
* All shader settings for all of a hero's items will be derived from the base hero material. The game automatically creates a single model and texture out of the hero and its currently equipped items, assigning a single shader to everything. We do not support custom item shaders that differ from the default item shader. For example, an additive shader on a solid hero isn't supported, but the hero material is very powerful and supports a range of effects, so there is almost always a way to achieve the desired effect.
* We do not support double-sided materials; you will need to create geometry where a backside is needed.
* Some masks, like the Metalness Mask, Detail Mask, and Diffuse Mask, are only used on certain heroes or items.

  
  
## Ogre Magi textures and shader masks: 
Base Model, Color, Normal, Self Illumination, Specular, Rimlight, Base Tint, and Specular Exponent  
  
![http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/shaders/ogre_magi_base_all_masks_s2.jpg?v=1459382400](http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/shaders/ogre_magi_base_all_masks_s2.jpg?v=1459382400)  
  
## Ogre Magi Weapon textures and shader masks: 
Model, Color, Normal, Metalness, Self Illumination, Specular, Rimlight, Base Tint, and Specular Exponent  
  
![http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/shaders/ogre_magi_weapon_all_masks_s2.jpg?v=1459382400](http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/shaders/ogre_magi_weapon_all_masks_s2.jpg?v=1459382400)  
  

---
  
  
[url id=source1][/url]  
  
## SOURCE 1 TEXTURE AND SHADER MASK CONVERSION

* Source 2 - Transparency and masks are now their own individual files, normal green channel is down.
* Source 1 - Transparency was included in color maps, the normal green channel was up and multiple shader masks were contained within mask 1 and mask 2 files.
* Our workshop tools can convert Source 1 textures into the Source 2 files but for accuracy of new submissions you should author the separate textures needed for Source 2.

  
  
​  
  

---
  
  
[url id=source2][/url]  
  
## SOURCE 2 TEXTURES AND SHADER MASKS 
[url id=color][/url]  
  
##  Color Map
  
  

* When creating your color map, be very aware of how the values, color palettes, gradients, and texture details of your items affect hero readability in game.
* For guidelines about color map authoring, please see our [Character Art Guide](https://support.steampowered.com/kb/9334-YDXV-8590/dota-2-workshop-character-art-guide).
* The color map can be 24 or 32 bit.

  
  
Color Maps for Ogre Magi, Disruptor, and Razor  
  
![http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/shaders/ogre_magi_color.jpg?v=1459382400](http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/shaders/ogre_magi_color.jpg?v=1459382400)  ![http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/shaders/disruptor_color.jpg?v=1459382400](http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/shaders/disruptor_color.jpg?v=1459382400)  ![http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/shaders/razor_color.jpg?v=1459382400](http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/shaders/razor_color.jpg?v=1459382400)​  
  

* We will soon be adding a control to the workshop demo mode that will allow you to see your items with desaturated colors in order to assess the readability of color map values. You can also use the console command r_hero_debug_render_mode 5 to enable desaturated display.

  

  
  
![http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/shaders/values_color_crop.jpg](http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/shaders/values_color_crop.jpg)  
  
![http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/shaders/values_greyscale_crop.jpg](http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/shaders/values_greyscale_crop.jpg)  
  

---
  
  
[url id=transparency][/url]  
  
##  Transparency
  
  

* Transparency determines where the texture is opaque.
* White is opaque, black is invisible. Transparency can only be fully opaque or fully invisible, there is no greyscale.
* Transparency is now enabled for all Dota heroes.
* Transparency is now a separate texture file in Source 2 but you can leave the transparent file input blank in the submission tool if your item doesn't need this.

  
  
​  
  
The mesh, Color Map, Transparency, and game model for Abaddon's default cape  
  
![http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/shaders/abaddon_cape_model_grey2.jpg](http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/shaders/abaddon_cape_model_grey2.jpg)  ![http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/shaders/abaddon_cape_color.jpg?v=1459382400](http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/shaders/abaddon_cape_color.jpg?v=1459382400)  ![http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/shaders/abaddon_cape_trans.jpg?v=1459382400](http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/shaders/abaddon_cape_trans.jpg?v=1459382400)  ![http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/shaders/abaddon_cape_color_model.jpg?v=1459382400](http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/shaders/abaddon_cape_color_model.jpg?v=1459382400)  
  

---
  
  
  
  
[url id=normal][/url]  
  
##  Normal Map
  
  

* The normal map gives the illusion of the lighting of raised and indented surfaces on a smooth mesh.
* The normal map should be 24-bit. In Source 2, red channel is left; green is down; blue is up.  If you aren't creating a custom normal map, use a flat normal color (128,128,255).

  
  
![http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/shaders/square_flat_normal.jpg?v=1459382400](http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/shaders/square_flat_normal.jpg?v=1459382400)​  
  

* NOTE - the normal green channel was up in Source 1, it has been inverted to be down for Source 2.
* Normal maps work best in combination with high specular and other masks.
* You can find resources and tutorials about making normal maps through community links on our [Dota Workshop Submission Guidelines Homepage](http://www.dota2.com/workshop/)

  
  
The Normal Map and Specular Mask for Ogre Magi's default weapon  
  
  ![http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/shaders/ogre_magi_weapon_normal_s2.jpg?v=1459382400](http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/shaders/ogre_magi_weapon_normal_s2.jpg?v=1459382400)  ![http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/shaders/ogre_magi_weapon_specmask.jpg?v=1459382400](http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/shaders/ogre_magi_weapon_specmask.jpg?v=1459382400)  
  
The model mesh without Normal Map, with Normal Map, and with all final textures including Specular and Metalness  
  
![http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/shaders/ogre_magi_ingame_2.JPG?v=1459382400](http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/shaders/ogre_magi_ingame_2.JPG?v=1459382400)  ![http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/shaders/ogre_magi_ingame_3.JPG?v=1459382400](http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/shaders/ogre_magi_ingame_3.JPG?v=1459382400)  ![http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/shaders/ogre_magi_ingame_0.JPG?v=1459382400](http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/shaders/ogre_magi_ingame_0.JPG?v=1459382400)  
  

---
  
  
[url id=detail][/url]  
  
##  Detail Mask
  
  

* NOTE - a Detail Mask will only work on a custom item if the hero's default material has this enabled. It must use the hero's default detail map.
* The Detail Mask determines where a detail map scrolling texture or added color will display on an item's surface.  For more specifics about how to author textures for these situations, please see [Authoring Items for Arcana, Ability, and Ambient Textures.](https://support.steampowered.com/kb/9942-EIPV-2211/dota-2-workshop-authoring-textures-for-arcanas-abilities-and-ambients)
* Most of the heroes and their items do not use the Detail Mask features at all. If a hero uses a Detail Mask on its body or default items, you could experiment with authoring a Detail Mask for part of your custom item, but be careful not to over use this.
* The default values are black. Lighter values will make the detail map appear.
* The material for the hero's default item controls the blending mode for the detail map. In the example below, the default material for Razor is using an additive blend mode.

  
  
​  
  
The Color Map, Detail Mask, and Detail Map of electrical arcs used on Razor's body.   
  
![http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/shaders/razor_color.jpg?v=1459382400](http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/shaders/razor_color.jpg?v=1459382400)  ![http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/shaders/razor_detailmask.jpg?v=1459382400](http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/shaders/razor_detailmask.jpg?v=1459382400)  ![http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/shaders/razor_electric_detail.jpg?v=1459382400](http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/shaders/razor_electric_detail.jpg?v=1459382400)  
  
Razor's arm without the Detail Mask  
  
![http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/shaders/razor_arm_no_detailmask_cropped.jpg?v=1459382400](http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/shaders/razor_arm_no_detailmask_cropped.jpg?v=1459382400)  
  
Razor's arm with the Detail Mask  
  
![http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/shaders/razor_arm_with_detailmask_cropped.jpg?v=1459382400](http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/shaders/razor_arm_with_detailmask_cropped.jpg?v=1459382400)  
  
    
  

---
  
  
[url id=metalness][/url]  
  
##  Metalness Mask
  
  

* The Metalness Mask reduces and darkens the color and rimlight in order to simulate a real-world metallic look. It works in combination with the Base Tint mask, which returns the color through specular highlights. This mask is used in combination with other masks that help the surface appear more metallic. Typically this means bright, broad highlights that are tinted by the base color.
* In the examples below with Ogre Magi's weapon and Nyx's helmet you'll see:

  
* Color, Normal, and Specular
* Metalness added
* All maps combined, including Metalness, Base Tint, Exponent, and Rimlight

  
  
![http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/shaders/ogre_weapon_metalness.jpg?v=1459382400](http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/shaders/ogre_weapon_metalness.jpg?v=1459382400)  
  
![http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/shaders/nyx_metalness.jpg?v=1459382400](http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/shaders/nyx_metalness.jpg?v=1459382400)  
  

---
  
  
[url id=selfillum][/url]  
  
##  Self Illumination Mask
  
  

* Self Illumination determines where the surface is self-illuminated independent of environment lighting.
* This mask can make the pixels of the surface full-bright with the coloring from the color texture.

  
  
​  
  
Self Illumination is used to create glowing areas, such as the mouth of Ogre Magi's weapon  
  
![http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/shaders/ogre_weapon_self_illum.jpg?v=1459382400](http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/shaders/ogre_weapon_self_illum.jpg?v=1459382400)  
  
A more subtle mask is used for the glow within Earth Spirit's arms.  
  
![http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/shaders/earth_spirit_self_illum_example.jpg](http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/shaders/earth_spirit_self_illum_example.jpg)  
  

* The default values are black. Lighter values will make a surface ignore lighting and just show color texture. Self illuminated areas in-game will also have a bloom (or glow) effect to them.
* It is best to be selective when using self-illumination so that you concentrate focus on the most important areas of an item or hero.

  
  
​  
  

---
  
  
[url id=specular][/url]  
  
##  Specular Mask
  
  

* The Specular Mask determines the brightness of the highlights, multiplied by specular intensity from the material.
* An Ambient Occlusion map is a good base for this map. Instructions about making an ambient occlusion map can be found in our [Color Texture Light Baking guide](https://support.steampowered.com/kb/8700-SJKN-4322/dota-2-character-texture-guide).
* This mask works in tandem with the Specular Exponent mask.
* Specular intensity values from the mask are multiplied by the specular scale value from the material. Custom items will use the value in the material for the default item. In most cases specular scale is a number higher than 1, which results in exaggerated highlights.

  
  
​  
  
No Specular  
  
![http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/shaders/ogre_weapon_no_specular.jpg?v=1459382400](http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/shaders/ogre_weapon_no_specular.jpg?v=1459382400)  
  
Full Specular  
  
![http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/shaders/ogre_weapon_full_specular.jpg?v=1459382400](http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/shaders/ogre_weapon_full_specular.jpg?v=1459382400)  
  
Authored Specular  
  
![http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/shaders/ogre_weapon_authored_specular.jpg?v=1459382400](http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/shaders/ogre_weapon_authored_specular.jpg?v=1459382400)  
  

---
  
  
[url id=rimlight][/url]  
  
##  Rimlight

* Rimlight is the highlighting on the edges around a model to give it depth and help it stand out from the environment. It's also known as fresnel intensity or rimlight intensity.
* Rimlight intensity values from the mask are multiplied by the rimlight scale value from the material. Custom items will use the value in the material for the default item. In most cases, rimlight scale is a number higher than 1, which results in an exaggerated rimlight.

  
  
​  
  
No Rimlight  
  
![http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/shaders/ogre_body_no_rimlight.jpg?v=1459382400](http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/shaders/ogre_body_no_rimlight.jpg?v=1459382400)  
  
With Authored Rimlight  
  
![http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/shaders/ogre_body_with_rimlight.jpg?v=1459382400](http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/shaders/ogre_body_with_rimlight.jpg?v=1459382400)  
  

* Dark values can be used for metals and lighter values for skin, leather, and wood. This may not be the case for all items.
* There are darker values in the crevices, which can be achieved by creating an [Ambient Occlusion](https://support.steampowered.com/kb/8700-SJKN-4322/dota-2-character-texture-guide) map.

  
  
​  
  
Ogre Magi's weapon rimlight mask is light for leather and dark for metal  
  
![http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/shaders/ogre_weapon_rimlight_example.jpg?v=1459382400](http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/shaders/ogre_weapon_rimlight_example.jpg?v=1459382400)  
  

---
  
  
[url id=basetint][/url]  
  
##  Base Tint Mask
  
  

* The base tint mask determines how much color the specular highlights get from the color texture. It is useful for colored metals (such as gold), or to simulate light penetrating a surface and being reflected back with color, making the surface appear fleshy.
* This mask was known as Tint Spec by Color in Source 1.
* Dark values in this channel will color specular highlights by diffuse color from the item's color texture.
* Light values will keep specular highlights the color of the light affecting the surface.

  
  
​  
  
Ogre Magi's bracer and Disruptor's base model without and with a Base Tint Mask  
  
![http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/shaders/ogre_bracer_basetint_demo.jpg?v=1459382400](http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/shaders/ogre_bracer_basetint_demo.jpg?v=1459382400)  
  
![http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/shaders/disruptor_basetint_demo.jpg?v=1465171200](http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/shaders/disruptor_basetint_demo.jpg?v=1465171200)  
  

---
  
  
[url id=exponent][/url]  
  
##  Specular Exponent
  
  

* Specular exponent values determine the size of the specular highlight on a surface.
* Dark values will give the impression of a rough surface.
* Light values will give the impression of a polished surface.
* Specular masks and specular exponents work together to create different surface types. Examples include:
* Metal - high specular, medium exponent
* Leather - medium specular, high exponent
* Wood - low specular, very low exponent
* Values in this mask act as a scale for the specular exponent value from the material. If the entire channel is white, then the entire surface will inherit specular exponent values from the material.

  
  
 Specular Highlight  
  
  
  
  ![http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/shaders/spec_exponent_highlights.jpg?v=1459382400](http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/shaders/spec_exponent_highlights.jpg?v=1459382400)  
  
Matching Specular Exponent Values  
  
  
  
  ![http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/shaders/spec_exponent_values.jpg?v=1459382400](http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/shaders/spec_exponent_values.jpg?v=1459382400)  
  
  
  
Full Specular Exponent  
  
![http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/shaders/spec_exponent_weapon_full_specular.jpg?v=1459382400](http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/shaders/spec_exponent_weapon_full_specular.jpg?v=1459382400)  
  
  
  
Authored Specular Exponent  
  
![http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/shaders/spec_exponent_authored_specular.jpg?v=1459382400](http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/shaders/spec_exponent_authored_specular.jpg?v=1459382400)  
  

---
  
  
[url id=diffuse][/url]  
  
## Diffuse Mask (rarely used)

* NOTE: Diffuse Mask is only enabled for a few early Dota heroes such as Puck, Juggernaut and Nyx.
* Diffuse masks are mostly obsolete and most items won't need this.
* The Diffuse Mask can apply a color transformation, like a hue shift or a contrast adjustment to the original color. This color transformation is encoded into a 3D texture called a colorwarp. This effect is then applied using a fresnel term, meaning it only appears around the edges of the character.​

  
  
Puck without (left) and with (right) a Custom Fresnel Color Warp applied to different extents by a light body diffuse mask (upper) and dark wings diffuse mask (lower)  
  
![http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/shaders/puck_no_diffuse.jpg?v=1459382400](http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/shaders/puck_no_diffuse.jpg?v=1459382400)  ![http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/shaders/puck_with_diffuse.jpg?v=1459382400](http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/shaders/puck_with_diffuse.jpg?v=1459382400)  ![http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/shaders/puck_rainbow_fresnel.jpg?v=1459382400](http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/shaders/puck_rainbow_fresnel.jpg?v=1459382400)  ![http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/shaders/puck_combined_diffusemasks.jpg?v=1459382400](http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/shaders/puck_combined_diffusemasks.jpg?v=1459382400)​  
  

---
  
  
[url id=budgets][/url]  
  
## TEXTURE BUDGETS AND RESOLUTION
  
  

* Due to the unique design of every hero, they each have different texture budgets for their items. Be sure to check the individual hero texture budgets through the [Hero Resource](http://www.dota2.com/workshop/requirements) page.
* All textures for an item must have the same proportions as the budget for that slot on the hero's page, otherwise the submission will fail.
* Textures will need a resolution equal to or higher than the item resolution specified on hero's page. If they don't, the submission tool will scale them up or down which might result in reduced quality.
* Valve artists author source textures up to 4 times larger than the in-game size for painting and promotional purposes. For example, a typical weapon could have a texture resolution of 256x256 pixels in game but source art could be 1024x1024.

  
  
  
  
[Dota 2 Item Workshop Guidelines Homepage](http://www.dota2.com/workshop/)
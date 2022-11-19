# Dota 2 Workshop - Color Texture Light Baking
Updated 2021-08-28 00:52:48  
Version 4  

![http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/color_texture_light_baking/590_01-DefiningColor_notext_01.jpg](http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/color_texture_light_baking/590_01-DefiningColor_notext_01.jpg)  
  
This guide describes a method for quickly creating a consistent color texture from a high resolution sculpted source and applying it to the low resolution in-game asset.  
  

* [DEFINING COLOR](#define)
* [AMBIENT OCCLUSION](#ambient)
* [POINT LIGHT MAP](#pointlight)
* [COLOR MAP](#colormap)
* [GRAPHIC PATTERNS](#patterns)
* [FINAL ADJUSTMENTS](#final)

  
  
  
  
##  DEFINING COLOR

* Dota 2's in-game lighting is quite subtle and as a result we tend to lose a lot of the sculptural detail in the character's normal maps.
* We offset this by baking - or painting - the light into the color texture.

  
  
---
  
  
  
  
## AMBIENT OCCLUSION
Start with the predominant color of the character  
  
![http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/color_texture_light_baking/590_01-DefiningColor_notext_02.jpg](http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/color_texture_light_baking/590_01-DefiningColor_notext_02.jpg)  
  
---
  
  
Bake an ambient occlusion map (AO Map) of the model.  
  
![http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/color_texture_light_baking/590_02-AmbientOcclusion_notext_01.jpg](http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/color_texture_light_baking/590_02-AmbientOcclusion_notext_01.jpg)  
  
---
  
  
Multiply the ambient occlusion layer on top of the base color at an 80% opacity.  
  
![http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/color_texture_light_baking/590_02-AmbientOcclusion_notext_02.jpg](http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/color_texture_light_baking/590_02-AmbientOcclusion_notext_02.jpg)  
  
---
  
  
  
  
##   
## POINT LIGHT MAP

* Place a couple of simple white point lights in your scene and render out a light map.
* You don't want ambient occlusion in this light pass, just pure point light information, preferably with a material that captures specular highlights.
* Turn off projected shadows. Typically, multiple point light maps are baked with lights in various positions then blended in Photoshop into one map for more precise control.

  
  
![http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/color_texture_light_baking/590_03-PointLight_notext_01.jpg](http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/color_texture_light_baking/590_03-PointLight_notext_01.jpg)  
  
---
  
  

* The point light map captures more sculptural information than is possible with a pure AO map.
* We bake this map separately from the AO as we want to control the two elements differently.
* The point lightmap also gives you a good starting point to introduce your top-to-bottom, light-to-dark gradient.

  
  
![http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/color_texture_light_baking/590_03-PointLight_notext_02.jpg](http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/color_texture_light_baking/590_03-PointLight_notext_02.jpg)  
  
---
  
  

* Clamp the shadows so they don't darken the base map unnecessarily.
* A 90 90 90 (RGB) screen layer at 85% opacity on top of the point light map is a good place to start.
* You can group these two layers together to make them easier to blend onto the base map.

  
  
![http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/color_texture_light_baking/590_04-PointLightClamped_notext_01.jpg](http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/color_texture_light_baking/590_04-PointLightClamped_notext_01.jpg)  
  
---
  
  

* The point light group is layered above the AO map.
* Set the point light group's blending mode to 100% soft light.
* This constitutes the 'underpainting' of the texture. Because we have a strong sculptural base to the texture we don't need to paint too much in the way of lighting and shadow information.

  
  
![http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/color_texture_light_baking/590_04-PointLightClamped_notext_02.jpg](http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/color_texture_light_baking/590_04-PointLightClamped_notext_02.jpg)  
  
---
  
  
  
  
## COLOR MAP
The majority of the painting is done in the color layers.  
  
![http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/color_texture_light_baking/590_05-ColorMap_notext_01.jpg](http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/color_texture_light_baking/590_05-ColorMap_notext_01.jpg)  
  
---
  
  
The color group is blended on top of other layers in overlay mode at 80% opacity.  
  
![http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/color_texture_light_baking/590_05-ColorMap_notext_02.jpg](http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/color_texture_light_baking/590_05-ColorMap_notext_02.jpg)  
  
---
  
  

* Dota 2 has a very bright and intense palette with lots of saturated colors. Layers with certain blend modes can blow out the palette into unusual colors, so it's worth clamping shadows and highlights to avoid excessive contrast. How aggressively you do this is best determined on a per character basis.
* For this character the color layer group was duplicated and given a blending mode of lighten at 30% opacity.

  
  
![http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/color_texture_light_baking/590_06-ColorMapClamped_notext_01.jpg](http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/color_texture_light_baking/590_06-ColorMapClamped_notext_01.jpg)  
  
---
  
  
The color layer group was duplicated again and given a blending mode of darken at 50% opacity. This allows the shadows and highlights to be controlled independently.  
  
![http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/color_texture_light_baking/590_06-ColorMapClamped_notext_02.jpg](http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/color_texture_light_baking/590_06-ColorMapClamped_notext_02.jpg)  
  
---
  
  
  
  
## GRAPHIC PATTERNS

* Most of Dota's characters have large crisp graphic patterns to aid legibility.
* These patterns can be blocked in loosely on the initial rough texture then later enhanced by a masked color layer.
* A layer mask is created using the lasso tool.
* Then color is painted on to sharpen edges and make colors more consistent.

  
  
![http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/color_texture_light_baking/590_07-GraphicPatterns_notext_01.jpg](http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/color_texture_light_baking/590_07-GraphicPatterns_notext_01.jpg)  
  
---
  
  
Color is loosely painted inside the layer mask to preserve a sharp edge to the design. The blending mode is set to normal at 80% opacity.  
  
![http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/color_texture_light_baking/590_07-GraphicPatterns_notext_02.jpg](http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/color_texture_light_baking/590_07-GraphicPatterns_notext_02.jpg)  
  
---
  
  
  
  
## FINAL ADJUSTMENTS
Make final adjustments to details like the eye highlights, improve the value gradient overall, and adjust the saturation.  
  
![http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/color_texture_light_baking/590_08-FinalAdjustments_notext_01.jpg](http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/color_texture_light_baking/590_08-FinalAdjustments_notext_01.jpg)    
  
---
  
  
This color texture is now perfectly synched to all of the details in the normal map.  
  
![http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/color_texture_light_baking/590_01-DefiningColor_notext_01.jpg](http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/color_texture_light_baking/590_01-DefiningColor_notext_01.jpg)![http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/color_texture_light_baking/590_08-FinalAdjustments_notext_02.jpg](http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/color_texture_light_baking/590_08-FinalAdjustments_notext_02.jpg)  
  
[Dota 2 Item Workshop Guidelines Homepage](http://www.dota2.com/workshop/)
# Dota 2 Workshop - Item UV Mapping
Updated 2021-07-10 19.49.55

![http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/uvs/luna_mount_uvs2.JPG](http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/uvs/luna_mount_uvs2.JPG)  
  
 UV Mapping is the process of  unwrapping the surface of a 3D model to create a 2D image onto which the model's texture can be painted.   
  
![http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/uvs/15_art_UVs_brewmaster.jpg](http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/uvs/15_art_UVs_brewmaster.jpg)  
  

* To achieve better texture details you can overlap UVs on symmetrical or repeating parts of the model but do not weld them through. Internally we offset overlapping UVs +1 in U direction.
* Texture seams are better kept to a minimum as they break up the vertices and add to an item's vertex count.
* In general, you can push an item's UVs to the texture borders closer than usual because hero's and item's textures are all added together in-engine.
* Mirror UVs as much as possible. Reserve asymmetry for areas that are most prominent in the portrait and game cameras. In the example above with Brewmaster, all solid colored areas have been overlapped.
* On Dota heroes, face UVs occupy at least 25% of the body’s UVs so that the portraits have sufficient detail. Bear this in mind when creating UVs for replacement head items or for the heads of NPCs and hero mounts that will be seen prominently in portraits or in the loadout.
* Most of the mounts ridden by Dota heroes have somewhat solid body coloring instead of skin covered with sharply defined details like stripes or spots. This gives our artists the option to use smaller UV space for the simpler body areas and use larger UV space for more important details on the mounts' heads, armor, tails, and fur or feather accents.
* All swappable costume items should be UV’d in their own unique 0 to 1 space (creating a unique texture).
* Like [textures](https://help.steampowered.com/en/faqs/view/0688-7692-4D5A-1935#gradient), UVs also typically have a density gradient with the lowest amount of UV space towards the feet/lower torso and largest UV space toward the head and upper torso. Portrait and game camera should inform these decisions.
* Eyes with a lot of detail should be a separate, larger UV island.
* Waste as little space as possible when laying out UV islands without packing it too tight. Always leave approximately 5-10 pixels (on a 2k source texture) between each shell and the edges of the 0 to 1 space. On some hardware, smaller versions of the textures will be loaded, and this can cause bleeding artifacts if the islands are packed too tightly.
* Grouping UV islands that will be colored similarly helps retain color separations when smaller versions of the textures are loaded.

  
  
[Dota 2 Item Workshop Guidelines Homepage](http://www.dota2.com/workshop/)
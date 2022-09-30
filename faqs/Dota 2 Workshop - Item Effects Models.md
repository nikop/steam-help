# Dota 2 Workshop - Item Effects Models
Updated 2021-10-28 02.13.44

![http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/effectsmeshes/01_effects_weapon_in_game3.jpg](http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/effectsmeshes/01_effects_weapon_in_game3.jpg)  
  

* [EFFECTS MODEL OVERVIEW](#definition)
* [AUTHORING GUIDELINES](#overview)
* [PARTICLE VERTEX LIMITS AND CONTEXT](#particlecounts)
* [AUTHORING EXAMPLE IN MAYA 2016](#example)
* [ADDING THE EFFECTS MESH IN THE WORKSHOP TOOL](#toolmesh)
* [EFFECTS MODEL PREVIEWING](#previewing)

  
  
[](id=definition)  
  
##  EFFECTS MODEL OVERVIEW 

* Items which have vertex-based ambient effects on them by default, such as edge glows, require that item authors submit a mesh which defines where these particles should go on the custom shape of their item.
* A workshop item with an effects model will use the default ambient effect authored by Valve for that item and place the particles according to the position of the vertices.
* Hero items that require effects models include weapons for Abaddon, Anti-Mage, Bounty Hunter, Doom, Ember Spirit, Juggernaut, Kunkka, Phantom Assassin, and Skywrath Mage.
* Effects model ambient particles can display in different contexts for different heroes. Some display at all times, some only display when the hero has a certain ability enabled, some require first leveling up to a certain point before the related ability can be enabled.
* Vertex-based effects are not to be confused with particle effects that use attachment points or selection boxes on items.

  
  
[](id=overview)  
  
## AUTHORING GUIDELINES

* To author an effects model you create a new mesh, much like creating an LOD. However, this mesh will represent particle positions, one per vertex.
* Triangles, faces, and general connectivity do not matter on this mesh. The best way to create a mesh for this is to treat it as a single polygon.
* Keep in mind that particles will be created from all vertices in the mesh, so do not attempt to create valid convex or closed triangles in the traditional sense if this creates vertices in undesired locations.
* While it is possible to use the vertices from the original model mesh, generally speaking the density will not end up being appropriate for the effect.
* In addition, UV's, hard edges, etc. can create duplicate vertices in some cases which is generally undesirable.

  
  
[](id=particlecounts)  
  
## PARTICLE VERTEX LIMITS AND CONTEXT
Here are the particle vertex count limits and ambient effect display context for effects models for these hero items:  
  

* Abaddon - weapon - 128, constant
* Anti-Mage - weapon and offhand - 128 each, constant
* Bounty Hunter - weapon and offhand - 120 each, displays when Jinada ability (available at Level 1) is enabled and is not in cooldown.
* Doom - weapon - 48, constant
* Ember Spirit - weapon and offhand - 32 each, constant
* Juggernaut - weapon - 128, constant
* Kunkka - weapon - 64, displays when his Tidebringer ability (available at Level 1) is enabled and is not in cooldown.
* Phantom Assassin - weapon - 120, displays when Coup de Grace ability (available at Level 6) is enabled.
* Skywrath Mage - weapon - 128, constant
* Terrorblade - two part weapon in one slot - 128 total for both, constant
* Underlord - weapon - 80, displays when his Atrophy Aura ability (available at Level 1) is enabled and a nearby enemy dies while under the effect. Weapon particle display is stronger for hero deaths than for creep deaths and increases with the number of deaths.

  
  
[](id=example)  
  
## AUTHORING EXAMPLE IN MAYA 2016
Below is an example of how to quickly create effects for an item in Maya 2016. Each type of modeling software will vary, but there should be equivalent processes in each.   
  

* First, start with your finished geometry. Select this mesh and Modify>Make Live. This will allow you to use the item's model mesh to draw vertices for your new effects mesh, while constraining them to the topology of the original.

  
  
  ![http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/effectsmeshes/02_effects_weapon_make_live.jpg?v=1459382400](http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/effectsmeshes/02_effects_weapon_make_live.jpg?v=1459382400)  
  

* Next switch to the Mesh Tools>Create Polygon. This will allow you to draw the new effects mesh locked to the live geometry.

  
  
  ![http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/effectsmeshes/03_effects_weapon_create_polygon.jpg?v=1459382400](http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/effectsmeshes/03_effects_weapon_create_polygon.jpg?v=1459382400)  
  

* Draw points where you wish to see particles, such as along a blade edge.

  
  
![http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/effectsmeshes/04_effects_weapon_vertices.jpg](http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/effectsmeshes/04_effects_weapon_vertices.jpg)  
  

* The density of these points will usually be higher than that of the normal mesh, as shown in the example below. It may require a bit of trial and error to get the proper density for the desired look.

  
  
![http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/effectsmeshes/06_effects_weapon_vertices_wireframe.jpg?v=1459382400](http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/effectsmeshes/06_effects_weapon_vertices_wireframe.jpg?v=1459382400)  
  

*  The entire effects mesh you create will be a single polygon.

  
  
![http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/effectsmeshes/05_effects_weapon_final_fx_model.jpg?v=1459382400](http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/effectsmeshes/05_effects_weapon_final_fx_model.jpg?v=1459382400)  
  

* Once you've added all the points, you can export just the effects mesh as either an .fbx or .dmx file.
* Name your mesh the same as the item with an _fx postfix, similar to an LOD, for example itemname_weapon_fx.

  
  
[](id=toolmesh)  
  
## ADDING THE EFFECTS MESH IN THE WORKSHOP TOOL

* Heroes that have effects model requirements for their items will have an "Effects Mesh" entry between the "Meshes" and "Materials" entries on the workshop tool's "Select Inputs" page.

  
  
![http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/effectsmeshes/09_fx_mesh_workshop_tool.jpg?](http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/effectsmeshes/09_fx_mesh_workshop_tool.jpg?)  
  
[](id=previewing)  
  
## EFFECTS MODEL PREVIEWING

* Loading the effects model along with the model meshes into the Dota 2 Workshop item submission tool should show you a preview of the default ambient particles on the model and in the demo mode loadout only if they are supposed to display all the time for that hero.

  
  
![http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/effectsmeshes/07_effects_weapon_preview2.jpg](http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/effectsmeshes/07_effects_weapon_preview2.jpg)  
  
![http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/effectsmeshes/08_effects_weapon_preview_loadout2.jpg?v=1459382400](http://cdn.dota2.com/apps/dota2/images/workshop/guidelines/effectsmeshes/08_effects_weapon_preview_loadout2.jpg?v=1459382400)  
  

* If you don't see the effects model particles in the preview or loadout, they may only appear at a certain hero level or in a certain context which will require testing in game using demo mode.
* Look at the [Particle Count and Context](#particlecounts) section above to see the conditions required to display effects model ambient particles for specific heroes.

  
  
[Dota 2 Item Workshop Guidelines Homepage](http://www.dota2.com/workshop/)
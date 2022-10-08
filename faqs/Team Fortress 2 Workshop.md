# Team Fortress 2 Workshop
Updated 2021-10-28 00.27.57  
Version 8  

* [What are the steps to making an item?](#stepsitem)
* [How does the item publishing process work?](#publishitem)
* [What software tool should I use to make my item?](#itemtools)
* [Where can I find good tutorials to learn 3D modeling?](#l2model)
* [I am a 3D artist, how do I get started?](#watchmego)
* [What are the polycount limits on my items?](#polycount)
* [What resolution should my textures be?](#textureres)
* [I've made an .obj file and .tga, how do I test them in game?](#objtga)
* [Where can I get the models of the existing characters so I can build my item in context?](#existingassets)
* [Any tips on creating textures?](#texturetip)
* [What are some guidelines for matching TF2's art style and improving the chances of my item getting in?](#artstyle)
* [What types of items should be reported?](#reportitem)
* [What if someone keeps reporting items that are not violating any terms?](#beenreported)

  
  
  
  
#### What are the steps to making an item?
Here are broad steps involved in making a 3D item:  
  

* Concept: Come up with a good idea in words. Trust us, this is the hardest part.
* Design: Draw in 2D or 3D what it will actually look like.
* Model: Using a 3D program, create the clean polygon model that will actually be in the game.
* Pelt: Unwrap the 3D model like a bearskin rug (UVs) so you can texture map it.
* Paint: Using your UVs as a guide, pick a color. Paint a color. Repeat.
* Skin: Bind the model to a joint for articulation.
* Compile: Use itemtest and don’t forget to make an LOD!
* Test: Load the itemtest map and look at your item on the character.
* Publish: Upload it to the steam workshop!

  
  
  
  
#### How does the item publishing process work?

* You create an item that meets the submission requirements.
* You test your item using the in-game 'itemtest' map.
* You publish your item to the Steam Workshop through the in-game item publishing tool.
* We review your item and potentially select it to be added to the game.
* If selected we contact you then integrate the item into Team Fortress 2.
* We test your item.
* We add it to the game and split the money your item generates in the Mann Co. store with you.

  
  
  
  
#### What software tool should I use to make my item?
It varies depending upon the project, but this is generally what we use:  
  

* [Maya](http://usa.autodesk.com/maya/) (models, textures, skeletons, morphs, animation)
* [Photoshop](http://www.photoshop.com/) (textures)
* [Zbrush](http://www.pixologic.com/) (detail models, morphs and textures)
* [3Dcoat](http://www.3d-coat.com/) (models and textures)
* [Mudbox](http://usa.autodesk.com/adsk/servlet/pc/index?id=13565063&siteID=123112) (models and textures)
* [Wings3D](http://www.wings3d.com/) (models only, but it’s free)
* [Modo indie](https://store.steampowered.com/app/401090/MODO_indie/) (models and textures)
* [3DS-Max](http://usa.autodesk.com/3ds-max/) (models, textures, skeletons, morphs, animation)

  
  
  
  
#### Where can I find good tutorials to learn 3D modeling?
Search for "speed modeling" on [YouTube](http://www.youtube.com/results?search_query=speed+modelling&aq=f) and visit the [source developer wiki](http://developer.valvesoftware.com/wiki/Model_Creation_Overview). There are a lot of digital art communities online with great information. Here are a couple that we like to visit:  
  

* [http://www.polycount.com/forum](http://www.polycount.com/forum)
* [http://www.wings3d.com/paulthepuzzles/aardvarks.html](http://www.wings3d.com/paulthepuzzles/aardvarks.html)

  
  
  
  
#### I am a 3D artist, how do I get started?
First, you’ll need to install the [Source Developer Kit (SDK)](http://developer.valvesoftware.com/wiki/SDK_Installation).  
  
  
  
#### What are the polycount limits on my items?
Keep the polycount similar to what's already in the game. Try to keep hats under 800 polygons, and weapons under 8,000.  
  
  
  
#### What resolution should my textures be?
Texture sizes should not be larger than 512x512. For hats, 256x256 is usually large enough.  
  
  
  
#### I've made an .obj file and .tga, how do I test them in game?
Use the itemtest wizard.  
  
  
  
#### Where can I get the models of the existing characters so I can build my item in context?
[Download this zip file](http://media.steampowered.com/apps/tf2/workshop/TF_heads.zip) which contains the .obj files and textures for all the TF classes.  
  
  
  
#### Any tips on creating textures?
Maintain the same texture density of other models in the world (Nothing higher res or lower res than what's next to it. For hats, maintain team colors, if not - neutral colors (see color swatch below.) Character textures are less noisy/detailed than everything else in the game. Character items/hats should match that style.  
  
  
  
#### What are some guidelines for matching TF2's art style and improving the chances of my item getting in?
This is a tricky question we grapple with daily. When we started, the game followed an idealized 1950’s-60’s Americana look. Nothing too modern, hyper-realistic or overly "cartoony". Clearly the art style has evolved over the years, but here are some guidelines that you should keep in mind as you create your items.  
  

* Hats should maintain the personality of the character (heavy's boxing Gloves , Scout's batter's helmet, etc.)
* TF generally has realistic proportions, with slightly exaggerated aspects to emphasize certain areas.
* Try and avoid fine surface details. No scales, skin pores, fabric textures, super detailed normals, etc. Take a look at giant size of the TF characters hands and imagine what they would build.
* Try and use flat colors that are close to the [TF color family](http://www.teamfortress.com/contribute/images/tips_palette.gif) that the base game uses. Try and avoid full black, full white, or fully saturated colors.
* Use a subtle vertical gradient and a subtle ambient occlusion layers multiplied over the colors.

  
  
  
  
#### What types of items should be reported?
Any inappropriate items, including but not limited to, racism, sexuality, or prejudice. Also any copyright or stolen material should be reported as well. For more information please review the Steam Subscriber Agreement [here](http://store.steampowered.com/subscriber_agreement/).  
  
  
  
#### What if someone keeps reporting items that are not violating any terms?
Users who repeatedly report items that do not violate terms will receive a lower reputation themselves and thus will not benefit from doing this.
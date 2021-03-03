Add all of your assets to this folder. Then export this folder as a unity package. Right-click "Export-Package" and select this folder. 
-Export all of your selectable objects with scripts. 
-Export your room with everything needed. materials, lights, audio files etc...
-If you want Post Processing you can modify the Post Processing profile. Be sure to give it a unique name "PostProc_ROOM NAME" 
-See "ExampleSelectable" script to see how to implement an interactable object. Be sure to tag your objects as "selectable". 
-Only Implement the OnInteract Function dont modify any of the scripts. So basically implement the functionality when the user Pressed E on your objects that's all your doing. 


DONT export the character controller or anything else that I already have in the main project to avoid duplicates.
In theory, I should be able to import the package you give me with your room and any additional mechanics that you’ve implemented into the main project.
This is intended to take some of the load off of me and allow you to have more flexibility with how you want your room to be set up.
*note unless specified your interactable won’t be synced over the network they will only be visible on local clients.

I'll try and be flexible with what you want to implement if you have any questions reach out to me on Discord.


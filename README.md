Project Development Steps

Environment & Player Setup: I started by creating the floor and the player character.
Visuals: I used custom assets and materials to give the player and the floor their colors and textures.
Player Movement: I wrote a C# script to allow the player character to move using physics.
Camera Follow: I implemented a camera script to ensure the camera follows the player smoothly during movement.
Level Boundaries: I added walls around the map so the player doesn't fall off, and I applied materials to make them look consistent.
Collectibles: Finally, I added star-shaped collectible items to the game and wrote a rotation script to make them spin.

I used ready-made assets for the football and the star collectibles.


Troubleshooting & Errors

Scene Loading Issue
Problem: When I first opened Unity, I saw a blank scene instead of my game. Also, the Game window was appearing immediately instead of the Scene view.
Solution: I selected the correct scene from the project files and deleted the extra blank scene to keep everything organized.

Script Assignment Error
Problem: At first, I attached the rotation script to an "Empty Game Object" instead of the stars. Because of this, the stars were not rotating correctly.
Solution: I realized the mistake, removed the script from the empty object, and attached it directly to each star asset.

Missing Script Warning (Prefab)
Problem: Since I used an asset from the store, it came with its own script. I deleted that script to write my own, but Unity gave a "Missing Script" error. I couldn't fix it just by deleting it from the scene.
Solution: I asked an AI for help and learned about Prefab Mode. I entered the Prefab Mode for the star, manually removed the missing component from the source file, and the error disappeared.

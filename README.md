# EFPSE Spooky's Jump Scare Mansion Clone
**This is a fan-made clone made using [Easy FPS Editor](https://cg8516.itch.io/easyfpseditor-ce). Go download the real game on [Steam](https://store.steampowered.com/app/356670/Spookys_Jump_Scare_Mansion/).**

This repository contains the Project files for the game. Simply download this repo and place the contents within a solder in your EPFSE install location /Projects folder.

Made with [EasyFPSEditor_CE_bugtest5.exe](https://github.com/CG8516/DumpingGround/blob/main/EFPSE_DEVBUILDS/EasyFPSEditor_CE_bugtest5.exe).


## Features
- Invisible decoration triggers with Editor Icons
- Slow tiles
- Randomly spawning cardboard jumpscares
- Random map change
- Enemy chases across levels


## Issues & Limitations
- enemy spawn locations hardcoded on each map (link to enemy trigger script)
- cardboard scare triggers assume player is going down on Y axis (moving up the screen) and spawns the scare on the next tile in this direction
- no background music, couldn't figure out a way to continue playing across different maps without it stopping and restarting


## C# Script Generator and Map Settings Overwriter


## Credits
Assets, resources and tutorials used to create this.

### Assets
- Textures = https://spookys-jump-scare-mansion.fandom.com/wiki/Floors_And_Walls
- Cardboard Scare Sound = https://sfxr.me/
- Door Sounds = https://opengameart.org/content/door-open-door-close
- Font = https://www.dafont.com/lunchtime-doubly-so.font

### Tutorials & Guides
- Wiki (https://pixelwolf.net/efpse/wiki/index.php/Scripting)
- Global entry map for Global variable declaration - taken from PixelWolf (https://www.youtube.com/watch?v=DRuUH33a280)
- Health bar and stamina bar - TJ's Creation Kit (https://www.youtube.com/watch?v=ltq240dj57U)
- Sprint - Mikulu Games & TJ's Creation Kit (https://www.youtube.com/watch?v=wNEEmtLEJok)
- Enemy FSM - Flappy (https://www.youtube.com/watch?v=R8-YHPBG1pg)
- Map script and setting generator - (https://github.com/CG8516/EFPSE-Project-Fixer/blob/main/Program.cs)
- https://store.steampowered.com/app/356670/Spookys_Jump_Scare_Mansion/


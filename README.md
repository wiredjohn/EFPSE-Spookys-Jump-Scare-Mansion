# EFPSE Spooky's Jump Scare Mansion Clone
**This is a fan-made clone made using [Easy FPS Editor](https://cg8516.itch.io/easyfpseditor-ce). Go download the real game on [Steam](https://store.steampowered.com/app/356670/Spookys_Jump_Scare_Mansion/).**

This repository contains the Project files for the game. Simply download this repo and place the contents within a folder in your EPFSE install location /Projects folder.

Made with [EasyFPSEditor_CE_bugtest5.exe](https://github.com/CG8516/DumpingGround/blob/main/EFPSE_DEVBUILDS/EasyFPSEditor_CE_bugtest5.exe).


## Features
- Resembles the early level of SJSM, survive 50 rooms to win
- Rooms are randomly selected for a different experience every time
- Get chased by an enemy that follows you from room to room
- Random cardboard cut-out jump scares
- Slime tiles that slow you down


## Issues & Limitations
- Enemy spawn locations hardcoded on each map ([trigger_specimen_2.script](/Scripts/trigger_specimen_2.script))
- Cardboard scare triggers assume player is going down on Y axis (moving up the screen) and spawns the scare on the next tile in this direction
- No background music, couldn't figure out a way to continue playing across different maps without it stopping and restarting


## C# Script Generator and Map Settings Overwriter
I created a small C# application to automate a lot of annoying things in EFPSE for this project. 

For example, the default player rotation is UP in this game instead of RIGHT, so to update this I would need to open each Map file -> change the Player Direction in the Map Properties -> hit save then dismiss the confirmation pop-up for every single map. Then remember to change this any time I created a new map.

So instead this program will automatically:
- Change player starting rotation
- Set script attached to Terminal 1
- Set ambient colour
- Set fog settings

And also generate the ".script" and "_loop.script" file for any Map that doesn't already have one, using a default template to mirror the script across all maps.

Application is available within [/_Tools/CreateMapScripts](/_Tools/CreateMapScripts).


## Credits
Assets, resources and tutorials used to create this.

### Assets
- Textures = https://spookys-jump-scare-mansion.fandom.com/wiki/Floors_And_Walls
- Enemy Sounds = https://sfxr.me/
- Door Sounds = https://opengameart.org/content/door-open-door-close
- Font = https://www.dafont.com/lunchtime-doubly-so.font

### Tutorials & Guides
- I used **PixelWolf**'s Unofficial EFPSE Wiki *constantly* - [wiki](https://pixelwolf.net/efpse/wiki/index.php/Scripting)
- Global entry map for Global variable declaration - taken from **OpenMawProductions** - [youtube](https://www.youtube.com/watch?v=DRuUH33a280)
- Health bar and stamina bar - **TJ's Creation Kit** - [youtube](https://www.youtube.com/watch?v=ltq240dj57U)
- Sprint - **Mikulu Games** & **TJ's Creation Kit** - [youtube](https://www.youtube.com/watch?v=wNEEmtLEJok)
- Enemy FSM would not be nearly as functional without the FSM deep dive by **Flappy** - [youtube](https://www.youtube.com/watch?v=R8-YHPBG1pg)
- **Clark**'s EFPSE Project Fixer helped me understand how to access and modify Map data files for my Setting Overwriter Application - [github](https://github.com/CG8516/EFPSE-Project-Fixer/blob/main/Program.cs)

**And of course, Spooky's Jump Scare Mansion - which you should download on [Steam](https://store.steampowered.com/app/356670/Spookys_Jump_Scare_Mansion/)**

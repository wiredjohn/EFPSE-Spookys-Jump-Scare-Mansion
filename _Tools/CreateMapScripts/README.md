# EFPSE Script Generator
This is a very simple C# appliction to automate some annoying manual task in Easy FPS Editor.

Made with [EasyFPSEditor_CE_bugtest5.exe](https://github.com/CG8516/DumpingGround/blob/main/EFPSE_DEVBUILDS/EasyFPSEditor_CE_bugtest5.exe). 

**If your Game was made with an older version then run this at your own risk and take a backup first! I have not tested against older versions.**

Massive thanks to Clark for his [EFPSE Project Fixer](https://github.com/CG8516/EFPSE-Project-Fixer) which helped me to understand the data file structures and how to access them.

## Overview
This script will:
1) Generate a .script file for each Map in a project using a default script
2) Generate a _loop.script file for each Map in a project using a default script
3) Overwrite the 
	- Script attached to Terminal 1
	- Ambient colour
	- Fog settings
	- Player starting rotation

## Usage
This script has already been ran for the [Spooky's Jump Scare Mansion Clone](https://github.com/wiredjohn/EFPSE-Spookys-Jump-Scare-Mansion) project that it was built for, so you don't need to run this if you're just trying to run that project.

If you are running this against that project or any other, simply put the _Tools/CreateMapScripts folder in that same structure within your Project folder and either open the .csproj with Visual Studio to run, or run
```cmd
dotnet run
```

## Script Generation
You must create a "_default_map.script" and a "_default_map_loop.script" in your project /Scripts folder if you intend to use the default script generator.

The contents of these files will then be copied into a respective ".script" and "_loop.script" for each of your maps.

If you already have a .script or _loop.script file for a Map then the script will not overwrite or replace it. Scripts will only be generated for Maps that don't already have these scripts.

If you have updated your script default templates and need to regenerate your scripts, then delete the old files from your /Scripts folder manually first.

## Default Setting Overwriter
The "OverwriteMapDefaults" method will take a backup of your Maps.dat file before writing any changes. These backups will be written to your project root with a timestamp in the name, e.g. "Maps.dat-backup-20260820193945". 

This method will not run if it can't create a backup first.'
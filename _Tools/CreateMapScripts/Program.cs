using System;
using System.Collections.Generic;
using System.IO;

namespace MapScripts;

internal static class Program
{
    private const int MapEntrySize = 34;

    private const string DefaultMapScript = "_default_map.script";
    private const string DefaultMapLoopScript = "_default_map_loop.script";

    private const string Terminal1Script = "trigger_room_exit";
    private const string AmbientColour = "76 76 76";
    private const string Fog = "0 0 0 300";
    private const string PlayerRotation = "0 None None None None 1 0 0";

    private static readonly string ProjectRoot =
        Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, @"..\..\..\..\..\"));

    private static string ScriptsPath =>
        Path.Combine(ProjectRoot, "Scripts");

    private static string MapsPath =>
        Path.Combine(ProjectRoot, "Maps.dat");

    public static void Main()
    {
        Console.WriteLine("Map Script Generator");
        Console.WriteLine("====================");

        List<string> mapList = GetMapList();

        string defaultMapScript = File.ReadAllText(
            Path.Combine(ScriptsPath, DefaultMapScript));

        string defaultMapLoopScript = File.ReadAllText(
            Path.Combine(ScriptsPath, DefaultMapLoopScript));

        GenerateScripts(mapList, defaultMapScript, ".script");
        GenerateScripts(mapList, defaultMapLoopScript, "_loop.script");

        OverwriteMapDefaults();

        Console.WriteLine();
        Console.WriteLine("Done.");
    }

    private static void GenerateScripts(
        IEnumerable<string> mapList,
        string scriptContent,
        string extension)
    {
        if (string.IsNullOrWhiteSpace(scriptContent)) 
        {
            Console.WriteLine(
                $"Skipping {extension} generation - default script content is blank");
            return; 
        }

        foreach (string map in mapList)
        {
            string scriptFile = Path.Combine(
                ScriptsPath,
                map + extension);

            if (File.Exists(scriptFile))
            {
                Console.WriteLine(
                    $"Skipping {map}{extension} - already exists.");

                continue;
            }

            File.WriteAllText(scriptFile, scriptContent);

            Console.WriteLine(
                $"Created {map}{extension}");
        }
    }

    private static List<string> GetMapList()
    {
        string[] mapLines = File.ReadAllLines(MapsPath);

        List<string> mapList = new();

        for (int i = 0; i < mapLines.Length; i += MapEntrySize)
        {
            string mapName = mapLines[i].Trim();

            if (string.IsNullOrWhiteSpace(mapName))
                continue;

            mapList.Add(
                Path.GetFileNameWithoutExtension(mapName));
        }

        return mapList;
    }

    private static void OverwriteMapDefaults()
    {
        // EFPSE must be closed before running this.
        // Otherwise it may overwrite these changes when it regains focus.

        Console.WriteLine();
        Console.WriteLine("Updating map defaults...");

        string backupPath =
            $"{MapsPath}-backup-{DateTime.Now:yyyyMMddHHmmss}";

        try
        {
            File.Copy(MapsPath, backupPath);

            Console.WriteLine($"Backup created: {backupPath}");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Couldn't take a backup. Aborting!");
            Console.WriteLine(ex.Message);
            return;
        }

        string[] lines = File.ReadAllLines(MapsPath);

        // Terminal 1 script
        ReplaceMapField(lines, 13, Terminal1Script);

        // Ambient colour
        ReplaceMapField(lines, 24, AmbientColour);

        // Fog
        ReplaceMapField(lines, 25, Fog);

        // Player rotation
        ReplaceMapField(lines, 33, PlayerRotation);

        File.WriteAllLines(MapsPath, lines);

        Console.WriteLine("Map data overwritten.");
    }

    private static void ReplaceMapField(
        string[] lines,
        int fieldOffset,
        string value)
    {
        for (int i = fieldOffset; i < lines.Length; i += MapEntrySize)
        {
            lines[i] = value;
        }
    }
}
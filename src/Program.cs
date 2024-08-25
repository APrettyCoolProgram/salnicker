// =============================== Version 0.9.1 ===============================
// Salnicker: Convers a file of SHA hashes into individual files.
// https://github.com/APrettyCoolProgram/Salnicker
// Copyright (c) A Pretty Cool Program. All rights reserved.
// Licensed under the Apache 2.0 license.
// =============================================================================

// 240824.2023

internal static class Program
{
    /// <summary>Main entry point for the program.</summary>
    /// <param name="args">The passed arguments.</param>
    public static void Main(string[] args)
    {
        Dictionary<string, string> hashes = [];

        if (args.Length == 1)
        {
            if (File.Exists(args[0]))
            {
                var fileLines = File.ReadAllLines(args[0]);

                foreach (string line in fileLines)
                {
                    string[] hashComponent = line.Split(" ", 2);

                    hashes.Add(hashComponent[0], hashComponent[1]);
                }
            }
            else
            {
                Console.WriteLine($"{Environment.NewLine}File not found.{Environment.NewLine}");
            }

            foreach (var hash in hashes)
            {

                File.WriteAllText($"{hash.Value.Trim()}.sha256", $"{hash.Key} {hash.Value}");
            }
        }
    }
}
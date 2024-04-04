// =============================== Version 0.1.0 ===============================
// Salnicker: Convers a file of SHA hashes into individual files.
// https://github.com/APrettyCoolProgram/Salnicker
// Copyright (c) A Pretty Cool Program. All rights reserved.
// Licensed under the Apache 2.0 license.
//
// =============================================================================

// 240404.1130

internal static class Program
{
    public static void Main(string[] args)
    {
        Dictionary<string, string> hashes = new Dictionary<string, string>();

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
                Console.WriteLine("File not found.");
            }

            foreach (var hash in hashes)
            {

                File.WriteAllText($"{hash.Value}.sha256", $"{hash.Key} {hash.Value}");
            }
        }
    }
}
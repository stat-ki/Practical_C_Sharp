using System;
using System.Diagnostics;
using System.IO;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = File.ReadAllLines("../../../commands.txt");
            ExecuteCommands(lines);
        }

        static ProcessStartInfo CreateStartupInfo (string line)
        {
            var items = line.Split('|');
            var startInfo = new ProcessStartInfo
            {
                FileName = items[0],
                Arguments = items.Length >= 2 ? items[1] : null
            };
            return startInfo;
        }

        static void ExecuteCommands(string[] lines)
        {
            foreach (var line in lines)
            {
                var info = CreateStartupInfo(line);
                if (string.IsNullOrWhiteSpace(info.FileName))
                {
                    continue;
                }
                using (var process = Process.Start(info))
                {
                    process.WaitForExit();
                }
            }
        }
    }
}

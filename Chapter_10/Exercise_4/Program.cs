using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace Exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var file = args[0];
            var lines = File.ReadAllLines(file);
            var line = lines.Select(s => Regex.Replace(s, @"\bversion=""v4.0""", @"version=""v5.0"""));
            File.WriteAllLines(file, line);
        }
    }
}

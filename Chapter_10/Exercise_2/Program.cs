using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var file = args[0];
            PickNumber(file);
        }

        private static void PickNumber(string file)
        {
            foreach (var line in File.ReadLines(file))
            {
                var matches = Regex.Matches(line, @"\b\d{3,}\b");
                foreach (Match m in matches)
                {
                    Console.WriteLine(m.Value);
                }
            }
        }
    }
}

using System;
using System.Text.RegularExpressions;

namespace Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var texts = new[] {
               "Time is money.",
               "What time is it?",
               "It will take time.",
               "We reorganized the timetable.",
            };

            foreach (var line in texts)
            {
                var matches = Regex.Matches(line, @"\btime\b", RegexOptions.IgnoreCase);
                foreach (Match m in matches)
                {
                    Console.WriteLine(m.Index);
                }
            }
        }
    }
}

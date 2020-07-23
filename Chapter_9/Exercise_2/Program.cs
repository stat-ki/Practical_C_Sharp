using System;
using System.IO;
using System.Linq;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var file = args[0];
            var lines = File.ReadLines(file).Select((s, n) => string.Format("{0,4}: {1}", n + 1, s));
            var path = Path.ChangeExtension(file, ".txt");
            File.WriteAllLines(path, lines);
            var text = File.ReadAllText(path);
            Console.WriteLine(text);

        }
    }
}

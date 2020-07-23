using System;
using System.IO;
using System.Linq;

namespace Exercise_5
{
    class Program
    {
        static void Main(string[] args)
        {
            var dir = args[0];
            DisplayLargeFile(dir, 1 * 1024L * 1024L);
        }

        private static void DisplayLargeFile(string dir, long size)
        {
            var files = Directory.EnumerateFiles(dir, "*.*", SearchOption.AllDirectories)
                                 .Where(file => FileSize(file) >= size);
            foreach (var file in files)
                Console.WriteLine(file);
        }

        private static long FileSize(string file)
        {
            var fi = new FileInfo(file);
            return fi.Length;
        }
    }
}

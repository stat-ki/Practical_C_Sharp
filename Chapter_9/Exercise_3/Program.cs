using System;
using System.IO;

namespace Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var file1 = args[0];
            var file2 = args[1];
            File.AppendAllLines(file1, File.ReadLines(file2));
        }
    }
}

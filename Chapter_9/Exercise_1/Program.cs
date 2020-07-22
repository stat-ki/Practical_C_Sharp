using System;
using System.IO;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var file = args[0];

            var count = 0;
            using (var sr = new StreamReader(file))
            {
                while (!sr.EndOfStream)
                {
                    var line = sr.ReadLine();
                    if (line.Contains(" class "))
                    {
                        count++;
                    }
                }
                Console.WriteLine(count);
            }
            Console.WriteLine("----");

            //File.ReadAlllinesメソッドを使うパターン
            //var count = File.ReadAllLines(file).Count(s => s.Contains(" class "));
            //Console.WriteLine(count);
            //Console.WriteLine("----");

            //File.ReadLinesメソッドを使うパターン
            //var count = File.ReadLines(file).Count(s => s.Contains(" class "));
            //Console.WriteLine(count);
            //Console.WriteLine("----");
        }
    }
}

using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            RunAsync();
            Console.ReadLine();
        }

        private static async void RunAsync()
        {
            var text = await TextReaderSample.ReadTextAsync("../../../oop.md");
            Console.WriteLine(text);
        }
    }

    static class TextReaderSample
    {
        public static async Task<string> ReadTextAsync(string filePath)
        {
            var sb = new StringBuilder();
            var sr = new StreamReader(filePath);
            while (!sr.EndOfStream)
            {
                var line = await sr.ReadLineAsync();
                sb.AppendLine(line);
            }
            return sb.ToString();
        }
    }
}

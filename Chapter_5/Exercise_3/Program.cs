using System;
using System.Linq;
using System.Text;

namespace Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = "Jackdaws love my big sphinx of quartz";

            int spaces = text.Count(c => c == ' ');
            Console.WriteLine("{0}個のスペース", spaces);
            Console.WriteLine("-----");

            var replaced = text.Replace("big", "small");
            Console.WriteLine(replaced);
            Console.WriteLine("-----");

            var count = text.Split(' ').Length;
            Console.WriteLine("{0}個の単語", count);
            Console.WriteLine("-----");

            var words = text.Split(' ').Where(s => s.Length <= 4);
            Console.WriteLine(String.Join(",", words));
            Console.WriteLine("-----");

            var array = text.Split(' ').ToArray();
            var sb = new StringBuilder();
            foreach (var word in array)
            {
                sb.Append(word);
                sb.Append(' ');
            }
            Console.WriteLine(sb.ToString());
        }
    }
}

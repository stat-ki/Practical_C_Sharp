using System;
using System.Linq;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[] { 5, 10, 17, 9, 3, 21, 10, 40, 21, 3, 35 };

            var max_number = numbers.Max();
            Console.WriteLine(max_number);
            Console.WriteLine("----");

            var skip = numbers.Length - 2;
            foreach (var n in numbers.Skip(skip))
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("----");

            var strs = numbers.Select(n => n.ToString());
            foreach(var s in strs)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("----");

            var sorted = numbers.OrderBy(n => n);
            foreach(var i in sorted.Take(3))
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("----");

            var count = numbers.Distinct().Count(n => n >= 10);
            Console.WriteLine(count);
        }
    }
}

using System;
using System.Linq;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[] { 5, 10, 17, 9, 3, 21, 10, 40, 21, 3, 35 };

            //最大値を出力する
            var max_number = numbers.Max();
            Console.WriteLine(max_number);
            Console.WriteLine("----");

            //最後から二つの要素を出力する
            var skip = numbers.Length - 2;
            foreach (var n in numbers.Skip(skip))
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("----");

            //文字列に変換し、出力する
            var strs = numbers.Select(n => n.ToString());
            foreach(var s in strs)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("----");

            //昇順に並び替えて、最初の３つを出力する
            var sorted = numbers.OrderBy(n => n);
            foreach(var i in sorted.Take(3))
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("----");

            //重複を排除し、１０以上の数の個数を出力する
            var count = numbers.Distinct().Count(n => n > 10);
            Console.WriteLine(count);
        }
    }
}

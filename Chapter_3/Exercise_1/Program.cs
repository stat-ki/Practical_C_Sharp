using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int> { 12, 87, 94, 14, 53, 20, 40, 35, 76, 91, 31, 17, 48 };

            //8か9で割り切れる数字があるか調べる
            var exists = numbers.Exists((int i) => { return i % 8 == 0 || i % 9 == 0; }) ;
            if (exists)
                Console.WriteLine("exists");
            else
                Console.WriteLine("not exists");

            Console.WriteLine("-----");

            //各要素を2.0で割った値を出力する
            numbers.ForEach((int i) => { Console.WriteLine(i / 2.0); });
            Console.WriteLine("-----");

            //値が50以上の要素を出力する
            var over50 = numbers.Where((int i) => { return i >= 50; });
            foreach (int i in over50)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("-----");

            //各要素を２倍、その結果をList<int>に格納し、出力する
            List<int> doubled = numbers.Select((int i) => { return i * 2; }).ToList();
            doubled.ForEach((int i) => { Console.WriteLine(i); });
        }
    }
}

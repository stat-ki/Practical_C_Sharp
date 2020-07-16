using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string> {
                 "Tokyo", "New Delhi", "Bangkok", "London", "Paris", "Berlin", "Canberra", "Hong Kong",
            };

            //入力された都市名が何番目に格納されいているかを出力する
            Console.WriteLine("検索する都市名を入力してください:");
            var line = Console.ReadLine();
            var index = names.FindIndex(s => s == line);
            Console.WriteLine(index);
            Console.WriteLine("-----");

            //o　が含まれている都市の数を抽出し、出力する
            var count = names.Count(s => s.Contains("o"));
            Console.WriteLine(count);
            Console.WriteLine("-----");

            //o が含まれている都市名を抽出し、出力する
            var contains = names.Where(s => s.Contains("o"));
            foreach (var s in contains)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("-----");

            //B から始まる都市を抽出し、その文字数を出力する
            var letters = names.Where(s => s.StartsWith("B")).Select(s => s.Length);
            foreach (var l in letters)
            {
                Console.WriteLine(l);
            }
        }
    }
}

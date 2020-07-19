using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var books = new List<Book> {
               new Book { Title = "C#プログラミングの新常識", Price = 3800, Pages = 378 },
               new Book { Title = "ラムダ式とLINQの極意", Price = 2500, Pages = 312 },
               new Book { Title = "ワンダフル・C#ライフ", Price = 2900, Pages = 385 },
               new Book { Title = "一人で学ぶ並列処理プログラミング", Price = 4800, Pages = 464 },
               new Book { Title = "フレーズで覚えるC#入門", Price = 5300, Pages = 604 },
               new Book { Title = "私でも分かったASP.NET MVC", Price = 3200, Pages = 453 },
               new Book { Title = "楽しいC#プログラミング教室", Price = 2540, Pages = 348 },
            };

            //タイトルが一致する本の値段とページ数を出力する
            var book = books.FirstOrDefault(b => b.Title == "ワンダフル・C#ライフ");
            Console.WriteLine("{0}円 {1}ページ", book.Price, book.Pages);
            Console.WriteLine("-----");

            //タイトルにC#が含まれている本の数を出力する
            var count = books.Count(b => b.Title.Contains("C#"));
            Console.WriteLine(count);
            Console.WriteLine("-----");

            //タイトルにC#が含まれている本のページ数の平均を出力する
            var average = books.Where(b => b.Title.Contains("C#")).Average(b => b.Pages);
            Console.WriteLine(average);
            Console.WriteLine("-----");

            //価格が4000円以上で最初に見つかった本のタイトルを出力する
            var over4000yen = books.FirstOrDefault(b => b.Price >= 4000);
            Console.WriteLine(over4000yen.Title);
            Console.WriteLine("-----");

            //価格が4000円以下の本の中で最大のページ数を出力する
            var max_page = books.Where(b => b.Price <= 4000).Max(b => b.Pages);
            Console.WriteLine(max_page);
            Console.WriteLine("-----");

            //ページ数が400以上の本を値段が高い順に出力する
            var sorted = books.Where(b => b.Pages >= 400).OrderByDescending(b => b.Price);
            foreach(var b in sorted)
            {
                Console.WriteLine("{0} {1}円", b.Title, b.Price);
            }
            Console.WriteLine("-----");

            //タイトルにC#が含まれ、ページ数が500以下の本を出力する
            var selected = books.Where(b => b.Title.Contains("C#") && b.Pages <= 500);
            foreach(var b in selected)
            {
                Console.WriteLine(b.Title);
            }
        }

        class Book
        {
            public string Title { get; set; }
            public int Price { get; set; }
            public int Pages { get; set; }
        }
    }
}

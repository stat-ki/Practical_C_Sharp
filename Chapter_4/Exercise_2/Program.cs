using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_2
{
    public class YearMonth
    {
        static void Main(string[] args)
        {
            var ymCollection = new YearMonth[] {
                new YearMonth(1980, 1),
                new YearMonth(1990, 4),
                new YearMonth(2000, 7),
                new YearMonth(2010, 9),
                new YearMonth(2020, 12),
            };

            foreach(var ym in ymCollection)
            {
                Console.WriteLine(ym);
            }
            Console.WriteLine("----");

            Console.WriteLine(FindFirst21Century(ymCollection));
            Console.WriteLine("----");

            var result = FindFirst21Century(ymCollection);
            if (result == null)
            {
                Console.WriteLine("21世紀のデータはありません");
            } else
            {
                Console.WriteLine(result);
            }
            Console.WriteLine("----");

            var array = ymCollection.Select(ym => ym.AddOneMonth()).ToArray();
            // Select((YearMonth ym) => { ym.AddOneMonth(); })とすると、型引数が必要となる
            foreach (var ym in array)
            {
                Console.WriteLine(ym);
            }
        }

        public int Year { get; private set; }
        public int Month { get; private set; }

        public YearMonth(int year, int month)
        {
            Year = year;
            Month = month;
        }

        public bool Is21Century()
        {
            return 2001 <= Year && Year <= 2100;
        }

        public YearMonth AddOneMonth()
        {
            if (Month == 12)
            {
                return new YearMonth(Year + 1, 1);
            }
            else
            {
                return new YearMonth(Year, Month + 1);
            }
        }

        static YearMonth FindFirst21Century(YearMonth[] ymCollection)
        {
            foreach(var ym in ymCollection)
            {
                if (ym.Is21Century())
                {
                    return ym;
                }
            }
            return null;
        }

        public override string ToString()
        {
            return $"{Year}年{Month}月";
        }
    }
}


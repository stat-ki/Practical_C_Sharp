using System;

namespace Exercise_1
{
    public class YearMonth
    {
        static void Main(string[] args)
        {
            var a = new YearMonth(2020, 7);
            Console.WriteLine(a.Is21Century());
            var b = a.AddOneMonth();
            Console.WriteLine(b.ToString());
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
            } else
            {
                return new YearMonth(Year, Month + 1);
            }
        }

        public override string ToString()
        {
            return $"{Year}年{Month}月";
        }
    }
}

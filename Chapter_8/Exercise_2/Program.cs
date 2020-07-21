using System;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var dt = DateTime.Today;
            foreach (var dayofweek in Enum.GetValues(typeof(DayOfWeek)))
            {
                Console.WriteLine("{0:yy/MM/dd} next {1} is {2:yy/MM/dd}", dt, (DayOfWeek)dayofweek, NextDay(dt, (DayOfWeek)dayofweek));
            }
        }

        public static DateTime NextDay(DateTime date, DayOfWeek dayOfWeek)
        {
            var nextweek = date.AddDays(7);
            var days = (int)dayOfWeek - (int)(date.DayOfWeek);
            return nextweek.AddDays(days);
        }
    }
}

using System;
using System.Globalization;
using System.Text;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var now = DateTime.Now;

            var str1 = string.Format("{0:yyyy/M/d HH:mm}", now);
            Console.WriteLine(str1);

            var str2 = now.ToString("yyyy年MM月dd日 HH時mm分ss秒");
            Console.WriteLine(str2);

            var culture = new CultureInfo("ja-JP");
            culture.DateTimeFormat.Calendar = new JapaneseCalendar();
            var dayOfweek = culture.DateTimeFormat.GetDayName(now.DayOfWeek);
            var datestr = now.ToString("ggyy", culture);
            var str3 = string.Format("{0}年{1, 2}月{2 ,2}日({3})", datestr, now.Month, now.Day, dayOfweek);
            Console.WriteLine(str3);
        }
    }
}

using System;

namespace Exercise_6
{
    class Program
    {
        static void Main(string[] args)
        {
            var local = new DateTime(2020, 8, 19, 16, 32, 20, DateTimeKind.Local);
            var date = new DateTimeOffset(local);
            var utc = date.ToUniversalTime();
            var timezone = TimeZoneInfo.FindSystemTimeZoneById("Singapore Standard Time");
            var sst = TimeZoneInfo.ConvertTime(utc, timezone);

            Console.WriteLine(utc);
            Console.WriteLine(sst);
        }
    }
}

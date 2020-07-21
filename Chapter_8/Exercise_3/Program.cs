using System;

namespace Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var tw = new TimeWatch();
            tw.Start();
            for (var i = 1; i <= 100; i ++)
            {
                Console.WriteLine(i);
            }
            TimeSpan duration = tw.Stop();
            Console.WriteLine("run time was {0}s", duration.TotalMilliseconds);
        }
    }

    class TimeWatch
    {
        private DateTime _time;

        public void Start()
        {
            _time = DateTime.Now;
        }

        public TimeSpan Stop()
        {
            return DateTime.Now - _time;
        }
    }
}

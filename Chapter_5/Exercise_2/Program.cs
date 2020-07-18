using System;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine();
            int num;
            if (int.TryParse(s, out num))
            {
                Console.WriteLine("{0:#,#}", num);
            }
            else
            {
                Console.WriteLine("not number");
            }
        }
    }
}

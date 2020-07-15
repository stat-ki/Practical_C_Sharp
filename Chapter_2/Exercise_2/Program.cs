using System;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length >= 1 && args[0] == "-tom")
            {
                PrintInchToMeter(1, 10);
            }
            else
            {
                PrintMeterToInch(1, 10);
            }
        }

        static void PrintInchToMeter(int start, int stop)
        {
            for (int inch = start; inch <= stop; inch++)
            {
                double meter = InchConverter.FromInch(inch);
                Console.WriteLine("{0} inch = {1:0.000} m", inch, meter);
            }
        }

        static void PrintMeterToInch(int start, int stop)
        {
            for (int meter = start; meter <= stop; meter++)
            {
                double inch = InchConverter.FromMeter(meter);
                Console.WriteLine("{0} meter = {1:0.000} inch", meter, inch);
            }
        }
    }
}

using System;
using System.Text.RegularExpressions;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsPhoneNumber("080-1234-5678"));
            Console.WriteLine(IsPhoneNumber("123-4567-8901"));
        }

        static bool IsPhoneNumber (string str)
        {
            return Regex.IsMatch(str, @"^0[789]0-\d{4}-\d{4}$");
        }
    }
}

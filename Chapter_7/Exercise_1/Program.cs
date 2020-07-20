using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = "Cozy lummox gives smart squid who asks for job pen";

            var dict1 = new Dictionary<Char, int>();
            foreach (var c in text)
            {
                var upper = char.ToUpper(c);
                if ('A' <= upper && upper <= 'Z')
                {
                    if (dict1.ContainsKey(upper))
                    {
                        dict1[upper]++;
                    }
                    else
                    {
                        dict1[upper] = 1;
                    }
                }
            }
            foreach (var d in dict1.OrderBy(x => x.Key))
            {
                Console.WriteLine("{0} : {1}", d.Key, d.Value);
            }

            //SortedDictionary を使うパターン

            //var dict2 = new SortedDictionary<Char, int>();
            //foreach (var c in text)
            //{
            //    var upper = char.ToUpper(c);
            //    if ('A' <= upper && upper <= 'Z')
            //    {
            //        if (dict2.ContainsKey(upper))
            //        {
            //            dict2[upper]++;
            //        }
            //        else
            //        {
            //            dict2[upper] = 1;
            //        }
            //    }
            //}
            //foreach (var d in dict2)
            //{
            //    Console.WriteLine("{0} : {1}", d.Key, d.Value);
            //}
        }
    }
}

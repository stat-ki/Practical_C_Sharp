using System;
using System.Linq;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var abbrs = new Abbreviations();

            abbrs.Add("IOC", "国際オリンピック委員会");
            abbrs.Add("NPT", "核拡散防止条約");

            var count = abbrs.Count;
            Console.WriteLine(abbrs.Count);
            Console.WriteLine("----");

            if (abbrs.Remove("NPT"))
            {
                Console.WriteLine(abbrs.Count);
            }
            else
            {
                Console.WriteLine("削除できません");
            }
            Console.WriteLine("----");

            foreach (var item in abbrs.Where(x => x.Key.Length == 3))
            {
                Console.WriteLine("{0}={1}", item.Key, item.Value);
            }
        }
    }
}

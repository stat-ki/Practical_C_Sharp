using System;
using System.Collections.Generic;
using System.IO;

namespace SalesCaluculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            var sales = new SalesCounter("../../../sales.csv");
            IDictionary<string, int> amoutPerProductCategory = sales.GetProductCategorySales();
            foreach (var obj in amoutPerProductCategory) {
                Console.WriteLine("{0} {1}", obj.Key, obj.Value);
            }
        }

        
    }
}

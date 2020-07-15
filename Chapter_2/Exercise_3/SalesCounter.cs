using System;
using System.Collections.Generic;
using System.IO;

namespace SalesCaluculator
{
    public class SalesCounter
    {
        private IEnumerable<Sale> _sales;

        public SalesCounter(string filePath)
        {
            _sales = ReadSales(filePath);
        }

        public IDictionary<string, int> GetProductCategorySales()
        {
            var dict = new Dictionary<string, int>();
            foreach (var sale in _sales)
            {
                if (dict.ContainsKey(sale.ProductCategory))
                    dict[sale.ProductCategory] += sale.Amount;
                else
                    dict[sale.ProductCategory] = sale.Amount;
            }
            return dict;
        }

        private static IEnumerable<Sale> ReadSales(string filePath)
        {
            List<Sale> sales = new List<Sale>();
            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                string[] items = line.Split(",");
                Sale sale = new Sale
                {
                    ShopName = items[0],
                    ProductCategory = items[1],
                    Amount = int.Parse(items[2])
                };
                sales.Add(sale);
            }
            return sales;
        }
    }
}

using Chapter1_1;

namespace Exercise
{
    class Program
    {
        public static void Main(string[] args)
        {
            Product dorayaki = new Product(98, "どら焼き", 210);
            int tax = dorayaki.GetTax();
            System.Console.WriteLine($"{tax}円");
        }
    }
}

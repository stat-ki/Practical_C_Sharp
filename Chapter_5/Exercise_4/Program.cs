using System;

namespace Exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var line = "Novelist=谷崎潤一郎;BestWork=春琴抄;Born=1886";
            foreach (var array in line.Split(";"))
            {
                var contents = array.Split("=");
                Console.WriteLine("{0}:{1}", Translate(contents[0]), contents[1]);
            }
        }

        static string Translate(string str)
        {
            switch (str)
            {
                case "Novelist":
                    return "作家";

                case "BestWork":
                    return "代表作";

                case "Born":
                    return "誕生年";
            }
            //解答: throw new ArgumentException("引数keyは、正しい値ではありません");
            return "不明";
        }
    }
}

using System;
using System.IO;
using System.Net;
using System.Text;

namespace Exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var wc = new WebClient();
            wc.Encoding = Encoding.UTF8;
            var html = wc.DownloadString("https://www.google.com/");
            File.WriteAllText("../../../sample.html", html);   
        }
    }
}

using System;
using System.Linq;
using System.Xml.Linq;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var file = "../../../sports.xml";
            Ex1_1(file);
            Console.WriteLine("----");
            Ex1_2(file);
            Console.WriteLine("----");
            Ex1_3(file);
            Console.WriteLine("----");
            Ex1_4(file);

        }

        static void Ex1_1(string file)
        {
            var xdoc = XDocument.Load(file);
            var sports = xdoc.Root.Elements().Select(x => new
            {
                Name = x.Element("name").Value,
                TeamMembers = x.Element("teammembers").Value
            });
            foreach (var sport in sports)
            {
                Console.WriteLine("{0}: {1}人", sport.Name, sport.TeamMembers);
            }
        }

        static void Ex1_2(string file)
        {
            var xdoc = XDocument.Load(file);
            var sports = xdoc.Root.Elements().Select(x => new
            {
                Name = x.Element("name").Value,
                FirstPlayed = x.Element("firstplayed").Value
            }).OrderBy(x => int.Parse(x.FirstPlayed));
            foreach (var sport in sports)
            {
                Console.WriteLine("{0}: {1}年", sport.Name, sport.FirstPlayed);
            }
        }

        static void Ex1_3(string file)
        {
            var xdoc = XDocument.Load(file);
            var sport = xdoc.Root.Elements().Select(x => new
            {
                Name = x.Element("name").Value,
                TeamMembers = x.Element("teammembers").Value
            }).OrderByDescending(x => int.Parse(x.TeamMembers)).First();
            Console.WriteLine("{0}: {1}人", sport.Name, sport.TeamMembers);
        }

        static void Ex1_4(string file)
        {
            var xdoc = XDocument.Load(file);
            var element = new XElement("ballsport",
                new XElement("name", "サッカー", new XAttribute("kanji", "蹴球")),
                new XElement("teammembers", "11"),
                new XElement("firstplayed", "1863")
            );
            xdoc.Root.Add(element);
            xdoc.Save("../../../sports_2.xml");
        }
    }
}

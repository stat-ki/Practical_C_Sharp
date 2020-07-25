using System;
using System.Linq;
using System.Xml.Linq;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var file = "../../../kanjis.xml";
            var xdoc = XDocument.Load(file);
            var words = xdoc.Root.Elements().Select(x =>
                new XElement("word",
                    new XAttribute("kanji", x.Element("kanji").Value),
                    new XAttribute("yomi", x.Element("yomi").Value)
                )
            );
            var root = new XElement("kanjis_2", words);
            root.Save("../../../kanjis_2.xml");
        }
    }
}

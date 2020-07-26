using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Xml;
using System.Xml.Serialization;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var novelist = Ex2_1("../../../novelist.xml");
            Ex2_2(novelist, "../../../novelist.json");
        }

        static Novelist Ex2_1(string file)
        {
            using (var reader = XmlReader.Create(file))
            {
                var serializer = new XmlSerializer(typeof(Novelist));
                var novelist = (Novelist)serializer.Deserialize(reader);
                return novelist;
            }
        }

        static void Ex2_2(Novelist novelist, string file)
        {
            using (var stream = new FileStream(file, FileMode.Create, FileAccess.Write))
            {
                var selializer = new DataContractJsonSerializer(novelist.GetType(), new DataContractJsonSerializerSettings { DateTimeFormat = new DateTimeFormat("yyyy-MM-dd'T'HH:mm:ssZ") });
                selializer.WriteObject(stream, novelist);
            }
        }
    }

    [XmlRoot("novelist")]
    [DataContract]
    public class Novelist
    {
        [XmlElement(ElementName = "name")]
        [DataMember(Name = "name")]
        public string Name { get; set; }

        [XmlElement(ElementName = "birth")]
        [DataMember(Name = "birth")]
        public DateTime Birth { get; set; }

        [XmlArray("masterpieces")]
        [XmlArrayItem("title", typeof(string))]
        [DataMember(Name = "masterpieces")]
        public string[] Masterpieces { get; set; }
    }
}

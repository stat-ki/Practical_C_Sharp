using System;
using System.Runtime.Serialization;
using System.Xml;
using System.Xml.Serialization;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Ex1_1("../../../employees.xml");
            Ex1_2("../../../employees_2.xml");
            Ex1_3("../../../employees_2.xml");
        }

        private static void Ex1_1(string file)
        {
            var emp = new Employee
            {
                Id = 123,
                Name = "出井 秀行",
                HireDate = new DateTime(2001, 5, 10)
            };
            using (var writer = XmlWriter.Create(file)) {
                var serializer = new XmlSerializer(emp.GetType());
                serializer.Serialize(writer, emp);
            }
        }

        private static void Ex1_2(string file)
        {
            var emps = new Employee[]
            {
                new Employee
                {
                    Id = 123,
                    Name = "出井 秀行",
                    HireDate = new DateTime(2001, 5, 10)
                },
                new Employee
                {
                    Id = 139,
                    Name = "大橋 孝仁",
                    HireDate = new DateTime(2004, 12, 1)
                },
            };
            var settings = new XmlWriterSettings
            {
                Encoding = new System.Text.UTF8Encoding(false),
                Indent = true,
                IndentChars = "  ",
            };
            using (var writer = XmlWriter.Create(file, settings))
            {
                var serializer = new DataContractSerializer(emps.GetType());
                serializer.WriteObject(writer, emps);
            }
        }

        public static void Ex1_3(string file)
        {
            using (XmlReader reader = XmlReader.Create(file))
            {
                var serializer = new DataContractSerializer(typeof(Employee[]));
                var emps = serializer.ReadObject(reader) as Employee[];
                foreach (var emp in emps)
                {
                    Console.WriteLine("{0} {1} {2}", emp.Id, emp.Name, emp.HireDate);
                }
            }
        }
    }

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime HireDate { get; set; }
    }
}

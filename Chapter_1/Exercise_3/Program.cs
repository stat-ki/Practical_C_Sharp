using System;

namespace Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student
            {
                Name = "山田太郎",
                Birthday = new DateTime(2000, 1, 1),
                Grade = 1,
                ClassNumber = 1
            };
            Console.WriteLine("{0}, {1: yyyy/M/d}生まれ, {2}歳, {3}年{4}組",
                student.Name, student.Birthday, student.GetAge(), student.Grade, student.ClassNumber);
            //objectクラスが基底クラスであるため、エラーにならない。
            object obj = student;
            Console.WriteLine(obj is Student);
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public DateTime Birthday { get; set; }

        public int GetAge()
        {
            DateTime today = DateTime.Today;
            int age = today.Year - Birthday.Year;
            if (today < Birthday.AddYears(age))
                age--;
            return age;
        }
    }

    public class Student : Person
    {
        public int Grade { get; set; }
        public int ClassNumber { get; set; }
    }
}

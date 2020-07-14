namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass { X = 1, Y = 2 };
            MyStruct myStruct = new MyStruct { X = 30, Y = 40 };
            PrintObject(myClass, myStruct);
            PrintObject(myClass, myStruct);
        }

        static void PrintObject(MyClass obj1, MyStruct obj2)
        {
            System.Console.WriteLine("X = {0}, Y = {1}", obj1.X, obj1.Y);
            System.Console.WriteLine("X = {0}, Y = {1}", obj2.X, obj2.Y);
            obj1.X *= 2;
            obj1.Y *= 2;
            obj2.X *= 2;
            obj2.Y *= 2;
        }
    }

    class MyClass
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    struct MyStruct
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
}

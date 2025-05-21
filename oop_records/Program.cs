namespace oop_records
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //MyClass my = new MyClass 
            //{
            //    MyProperty = 1,
            //    A = 2,
            //};
            //my.MyProperty = 3; //Hata verecektir.
            //Console.WriteLine(my.MyProperty);

            //MyClass2 m = new MyClass2()
            //{
            //    MyProperty = 5
            //};
            //MyClass2 m2 = new MyClass2()
            //{
            //    MyProperty = 5
            //};

            //Console.WriteLine(m.Equals(m2));

            //myRecord m3 = new myRecord()
            //{
            //    MyProperty = 5
            //};
            //myRecord m4 = new myRecord()
            //{
            //    MyProperty = 5
            //};
            //Console.WriteLine(m3.Equals(m4));

            //MyClass2 m = new MyClass2()
            //{
            //    MyProperty1 = 5,
            //    MyProperty2 = 10,
            //};
            //m.MyProperty1 = 51;
            //MyClass2 m2 = new MyClass2()
            //{
            //    MyProperty1 = m.MyProperty1,
            //    MyProperty2 = 15
            //};

            //MyClass2 m2 = m.With(11);
            
            myRecord m = new myRecord()
            {
                MyProperty1 = 5,
                MyProperty2 = 10,
            };
            myRecord m2 = m with { MyProperty2 = 10 };


        }
    }

    record myRecord
    {
        public int MyProperty1 { get; init; }
        public int MyProperty2 { get; init; }
    }
    //class MyClass2
    //{
    //    public int MyProperty1 { get; init; }
    //    public int MyProperty2 { get; init; }
    //    public MyClass2 With(int property2)
    //    {
    //        return new MyClass2
    //        {
    //            MyProperty1 = this.MyProperty1,
    //            MyProperty2 = property2
    //        };
    //    }
    //}

    //class MyClass
    //{
    //    readonly int a;
    //    public int A
    //    {
    //        get
    //        {
    //            return a;
    //        }
    //        init
    //        {
    //            a = value;
    //        }
    //    }
    //    public int MyProperty { get; init; } = 3;
    //}
}
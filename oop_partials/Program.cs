
#region partial class

//using x;

//var m = new MyClass();
//m.A();
//m.B();
//namespace x
//{
//    partial class MyClass
//    {
//        partial class MyClass2
//        {

//        }
//        public void A()
//        {

//        }
//    }
//    partial class MyClass
//    {
//        partial class MyClass2
//        {

//        }
//        public void B()
//        {

//        }
//    }
//}
#endregion
#region partial record
//partial record Z
//{

//}
//partial record Z
//{

//}
#endregion
#region partial abstract class
//abstract partial class MyClass
//{

//}
//abstract partial class MyClass
//{

//}
#endregion
#region partial struct
//partial struct MyStruct
//{

//}
//partial struct MyStruct
//{

//}
#endregion
#region partial interface

//partial interface IInterface
//{

//}
//partial interface IInterface
//{

//}
#endregion

#region partial metotlar
new MyClass();
partial class MyClass
{
    
    public MyClass()
    {
        O();
        Y();
        Z();
    }
    partial void O();
    partial void Y();
    partial void Z();

    partial void Y()
    {
        Console.WriteLine("Y tetiklendi...");
    }

}
#endregion
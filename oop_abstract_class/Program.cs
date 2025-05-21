#region Abstract class nesne üretimi
new _A();

class MyClass
{
    public MyClass()
    {
        Console.WriteLine("Myclass");
    }
}

abstract class A : MyClass
{
    public A()
    {
        Console.WriteLine("A Abstract Class");
    }
}

class _A : A
{
    public _A()
    {
        Console.WriteLine("_A class");
    }
}
#endregion

#region Abstract class yapısal özelliği
abstract class MyAbstactClass
{
    //Somut yapılanmalar
    public void X()
    {

    }

    public int MyProperty { get; set; }

    int x;

    //Soyut yapılanmalar
    abstract public void X2();
    abstract public void W(string a, int b);
    abstract public int Y { get; set; }

    //Abstract class içerisindeki abstract yapıların concrete class içerisindeki tanımları public olmak zorundadır.

    #region Zoraki override
    class MyClass : MyAbstactClass
    {
        public override int Y { get; set; }

        public override void W(string a, int b)
        {

        }

        public override void X2()
        {

        }
    }
    #endregion
    #region Abstract Class’ın Abstract Class’tan Türemesi
    //Z z = new();
    
    //abstract class X4
    //{
    //    public void A() { }
    //    public void B() { }
    //    public void C() { }
    //    public abstract void D();
    //    public abstract void H();
    //}
    //abstract class Y4:X4
    //{
    //    public void E() { }
    //    abstract public void F();
    //}
    //class Z : Y4
    //{
    //    public override void D()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public override void F()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public override void H()
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
    #endregion
}

#endregion

//IExample example = null;
#region Interface tanımlama kuralı
//interface IExample
//{

//}

//namespace MyNamespace
//{

//    interface IExample
//    {

//    }
//    class MyClass
//    {
//        interface IExample
//        {

//        }
//    }

//}
//class MyClass
//{
//    interface IExample
//    {
//        interface IExample2
//        {

//        }
//    }
//}
#endregion

#region Interface vs Abstract Class
//public interface IMyInterface
//{
//    void X();
//    void Y(int a);
//    int Z { get; set; }
//}

//abstract class MyAbstractClass
//{
//    abstract public void X();
//    abstract public void Y(int a);
//    abstract public int Z { get; set; }
//}



#endregion

#region Interface Kullanımı
//class MyClass3 : IMyInterface2
//{
//    public int Z { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

//    public void X()
//    {
//        throw new NotImplementedException();
//    }

//    public void Y(int a)
//    {
//        throw new NotImplementedException();
//    }
//}

//public interface IMyInterface2
//{
//    void X();
//    void Y(int a);
//    int Z { get; set; }
//}


#endregion

#region Interface’ler de Çoklu Kalıtım Durumu
//MyClass4 myClass4 = new MyClass4();
//IA Ia = new MyClass4(); //ınterfaceler referans türlü değişkenler oldukları için Myclass'ı interfaceler ile refere edebiliriz.
//IB Ib = new MyClass4();
//IC Ic = new MyClass4();
//Ic.C(); //Her bir interface referansı kendi memberına erişebilecektir. Yani bir abstraction davranışı oluşacaktır.


//class MyClass4 : IA, IB, IC
//{
//    public void A(){}

//    public void B(){}

//    public void C(){}
//}
//interface IA
//{
//    void A();
//}
//interface IB
//{
//    void B();
//}
//interface IC
//{
//    void C();
//}
#endregion

#region Interface’in Interface’den Türemesi
//class MyClass4 : IC
//{
//    public void A()
//    {
//        throw new NotImplementedException();
//    }

//    public void B()
//    {
//        throw new NotImplementedException();
//    }

//    public void C()
//    {
//        throw new NotImplementedException();
//    }

//    public void D()
//    {
//        throw new NotImplementedException();
//    }

//    public void W()
//    {
//        throw new NotImplementedException();
//    }
//}
//interface IA
//{
//    void A();
//}
//interface IB : IA
//{
//    void B();
//}
//interface IC : IB, ID, IW
//{
//    void C();
//}
//interface ID
//{
//    void D();
//}
//interface IW
//{
//    void W();
//}
#endregion





#region Interface Refaransı Üzerinden Member’lara Erişim
//MyClass m = new();
//IA ıa = m;

//ıa.X();
//IB ıb = m;
//ıb.X();


//class MyClass : IA, IB
//{
//    int IA.X()
//    {
//        Console.WriteLine("A - X");
//        return 0;
//    }

//    int IB.X()
//    {
//        Console.WriteLine("A - Y");
//        return 1;
//    }
//}
//public interface IA
//{
//    int X();
//}
//public interface IB
//{
//    int X();
//}
#endregion


#region Default Implementation
class MyClass : IA
{
    public void X()
    {
        Console.WriteLine("X");
    }
    public void Y() { Console.WriteLine("Y"); } //Ama biz default ımp. karşın gene bir ımplementasyonda bulunacaksak bunu yapabiliriz fakat default ımp.'da ki gövdeyi ezecektir.

}

interface IA
{
    void X();
    //Normal de Y'nin default ımlp. olmazsa compiler hata verecektir. Amma velakin default ımp. varsa hata ortadan kalkacaktır.
    //Yani IA'da ki Y imzasına karşılık herhangi bir tanımda bulunmazsak default ımp. çalışacaktır.

    void Y()
    {
        Console.WriteLine("Default Implementation Y");
    }
}
#endregion
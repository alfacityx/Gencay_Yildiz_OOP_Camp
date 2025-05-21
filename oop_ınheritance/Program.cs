namespace oop_ınheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Inheritance - 1
            Muhasebeci muhasebeci = new Muhasebeci();
            muhasebeci.Adi = "";
            #endregion
            #region Inheritance - 2

            //new D();

            #region İsim Saklama(Name Hiding) Sorunsalı
            //D d=new D();
            //d.X();
            #endregion

            #endregion


        }
    }
    #region Inheritance - 1
    public class Personel
    {
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string MedeniHal { get; set; }
    }
    public class Muhasebeci : Personel
    {

    }
    public class Yazılımcı : Personel
    {

    }
    public class Müdür : Personel
    {

    }
    #endregion
    #region Inheritance - 2
    //public class BuyukBaba
    //{
    //    //Base Class

    //}
    //public class Baba : BuyukBaba
    //{
    //    //Base Class ve Derived Class
    //}

    //public class Oğul : Baba
    //{
    //    //Derived Class
    //}

    #region Kalıtımda Nesne Üretim Sırası
    //Bir sınıftan nesne üretimi yapılırken kalıtım aldığı üst sınıflar varsa eğer önce sınıflardan SIRAYLA nesne üretilir.
    //class A
    //{
    //    public A()
    //    {
    //        Console.WriteLine($"{nameof(A)} nesnesi oluşturulmuştur.");
    //    }
    //}
    //class B : A
    //{
    //    public B()
    //    {
    //        Console.WriteLine($"{nameof(B)} nesnesi oluşturulmuştur.");
    //    }
    //}
    //class C : B
    //{
    //    public C()
    //    {
    //        Console.WriteLine($"{nameof(C)} nesnesi oluşturulmuştur.");
    //    }
    //}
    //class D : C
    //{
    //    public D()
    //    {
    //        Console.WriteLine($"{nameof(D)} nesnesi oluşturulmuştur.");
    //    }
    //}
    #endregion
    #region Bir Sınıftan Base Class Construct’ına Ulaşım
    //class MyClass
    //{
    //    public MyClass(int a)
    //    {

    //    }
    //    public MyClass()
    //    {

    //    }
    //}
    //Eğer ki base class'ın constructor'ı sadece parametre alan constructor ise derived classlarda o constructor'a bir değer GÖNDERMEK ZORUNDAYIZ...
    //Bunu da base keywordüyle sağlayabiliriz...

    //Bir class'ın construct'ın yanında : base keywordünü kullanırsak eğer o class'ın base classının tüm constructorlarını bize getirecektir.
    //Haliyle ilgili sınıftan bir nesne üretilirken base class'tan nesne üretimi esnasında hangi constructor'ın tetikleneceğini bu şekilde belirleyebiliriz.
    //class MyClass2 : MyClass
    //{
    //    public MyClass2()
    //    {
    //        //Eğer ki base class'ta boş bir parametreli constructor varsa derived class'ta base ile bir bildirimde bulunmak zorunda değiliz...
    //        //Niçin? Çünkü varsayılan olarak kalıtımsal durumda base classta ki boş parametreli constructor tetiklenir.
    //    }
    //    //public MyClass2() : base(5)
    //    //{

    //    //}
    //    public MyClass2(int a) : base(a)
    //    {

    //    }
    //}
    #endregion

    #region This ve Base Keywordü
    //class A
    //{
    //    int a;
    //    public int b;
    //    public int MyProperty { get; set; }
    //}
    //class B : A
    //{
    //    int c;
    //    public int d;
    //    public void X()
    //    {
    //        base.MyProperty = 1;
    //        this.MyProperty = 2;
    //        //İllaha başlarına base veya this diye belirtmemize gerek yok compiler tarafından otomatik olarak arka tarafta da kendisi veriyor.
    //        MyProperty = 3;

    //        //this ile o anki sınıfın nesnesi üzerindeki tüm memberlara erişebiliriz.
    //        this.d = 4;
    //        base.d = 5;

    //    }
    //}
    #endregion

    #region İsim Saklama(Name Hiding) Sorunsalı

    class A
    {
        public void X()
        {

        }
    }
    class B : A
    {

    }
    class C : B
    {

    }
    class D : C
    {
        public void  X()
        {

        }
    }
    #endregion


}

#endregion
namespace oop_sinif_modeline_ozel_keywordler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region this keyword'ü
            //Bir sınıfın, uygulamanın herhangi bir noktasında üretilmiş olan instance'larını/object'lerini / nesnelerini sınıf içerisinde temsil etmemizi
            //sağlayan bir keyworddür.
            //this keywordü,bir sınıf içerisinde bulunan birden fazla constructor overload'ı arasında geçiş yapmamızı sağlayan bir keyworddür.
            //MyClass myClass = new MyClass(3,"sa");
            #endregion

            #region base keyword'ü
            //base keyword'ü bir instance'ın base class'ını sınıf modeli içerisinde temsil eden bir keyword'dür.
            //base keyword'ü,base class'daki constructor'lardan seçim yapmamızı sağlar.
            //MyClass2 myClass2 = new MyClass2();

            #endregion

            #region readonly keyword'ü
            //bir class içerisinde tanımlanmış olan değişkenin yahut referansın sadece okunabilir olmasını sağlayan bir keyword'dür.
            //readonly keyword'ü ile işaretlenmiş olan referansların değerleri ya tanımlama noktasında ya da constructor'da verilebilir.

            //const yapılanmalar, readonly ile karıştırılabilir.Aralarındaki fark şöyledir;
            //const tanımlandığı yerde değer verilmelidir.Ve constructor içerisinde bile değer ataması gerçekleştirilemez!
            //Lakin readonyl'de ister tanımlama noktasında isterseniz de constructor içerisinde değer ataması gerçekleştirilebilir.
            //İkisi arasındaki temel farklardan biriside budur.

            #endregion
        }
    }
    #region this keyword
    //class MyClass
    //{
    //    public string Name { get; set; }
    //    public MyClass()
    //    {
    //        //this.Name = "Test";

    //        Console.WriteLine("Boş Constructor");
    //    }
    //    public MyClass(int a) : this()
    //    {
    //        Console.WriteLine("a parametreli Constructor");
    //    }

    //    public MyClass(int a, string b) : this(a)
    //    {
    //        Console.WriteLine("a ve b parametreli Constructor");
    //    }

    //}
    #endregion

    #region base keyword'ü
    //class MyClass
    //{
    //    public int MyProperty { get; set; }
    //    public MyClass()
    //    {
    //        //this.Name = "Test";

    //        Console.WriteLine("Boş Constructor");
    //    }
    //    public MyClass(int a) : this()
    //    {
    //        Console.WriteLine("a parametreli Constructor");
    //    }

    //    public MyClass(int a, string b) : this(a)
    //    {
    //        Console.WriteLine("a ve b parametreli Constructor");
    //    }
    //}
    //class MyClass2 : MyClass
    //{
    //    public MyClass2() : base(3, "")
    //    {
    //        base.MyProperty = 1;
    //        Console.WriteLine("Son constructor");
    //    }
    //}
    #endregion

    #region readonly keyword'ü
    class MyClass3
    {
        readonly object x = 4;
        public MyClass3()
        {
            x = 15;
        }

    }
    #endregion
}
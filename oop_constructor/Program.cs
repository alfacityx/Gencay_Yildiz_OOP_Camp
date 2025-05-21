using System.Diagnostics.Metrics;

namespace oop_constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Constructor Nedir?
            //Constructor bir nesne üretimi sürecinde ilk tetiklenen metottur.
            #endregion

            #region Parametreli Constructor
            //new MyClass(5);
            //new MyClass(11, 121);
            //new MyClass();
            //new MyClass();
            //new MyClass();


            //MyClass m = new(15);
            #endregion

            #region Private Constructor
            //new MyClass();
            #endregion

            #region This keywordüyle Constructor'lar arası geçiş           
            //new MyClass(5,"Mehmet");
            #endregion

            #region Record’lar da Constructor

            #endregion

            #region Destructor Metot Nedir?
            //Bir class’tan üretilmiş olan nesne imha edilirken otomatik çağrılan metottur.
            #endregion

            #region Destructor Metot Örnek - 1
            //X();
            //GC.Collect(); //GarbageCollector devreye sokulmuş oldu.
            //Console.ReadLine();

            //static void X()
            //{
            //    MyClass m = new MyClass();
            //}
            #endregion
            #region Destructor Metot Örnek - 2
            //for (int i = 100; i >=1 ; i--)
            //{
            //    new MyClass2(i);
            //}
            //Console.WriteLine("************************");
            //GC.Collect();

            //Console.ReadLine();
            #endregion

            #region Deconstruct Metot Nedir?
            //Bir sınıf içerisinde “Deconstruct” ismiyle tanımlanan metot, compiler tarafından özel olarak algılanmakta - 
            //ve sınıfın nesnesi üzerinden geriye hızlıca Tuple bir değer döndürmemizi sağlamaktadır.

            //Person person = new Person()
            //{
            //    Name = "Ebu",
            //    Age = 20,
            //};

            //var (x, y) = person;
            #endregion

            #region Static Constructor Metot Nedir?
            //Static constructor ise ilgili sınıftan ilk nesne üretilirken bir kereye mahsus tetiklenen metottur.
            MyClass myClass = new MyClass();
            MyClass myClass2 = new MyClass();

            //var database = Database.GetInstance; //Singleton Design Patterns
            //var database2 = Database.GetInstance;

            //database.ConnectionStrings = "OPADSIHASDASD"; //Eğer ki databaseler üzerinde değerler aynıysa bil ki o singleton/aynı nesnedir.

            #endregion

        }
    }
    #region Parametreli Constructor
    //class MyClass
    //{
    //    public MyClass()
    //    {

    //    }
    //    public MyClass(int a)
    //    {
    //        Console.WriteLine("Nesne Oluşturuldu." + a);
    //    }
    //    public MyClass(int a, int b) //Overload
    //    {
    //        Console.WriteLine("Nesne Oluşturuldu." + a+ " " + b);

    //    }
    //}
    #endregion

    #region Private Constructor
    //class MyClass
    //{
    //    public MyClass()
    //    {

    //    }

    //}
    #endregion

    #region This keywordüyle Constructor'lar arası geçiş
    //public class MyClass
    //{
    //    public MyClass()
    //    {
    //        Console.WriteLine("1. Constructor");

    //    }
    //    public MyClass(int a) : this()
    //    {
    //        Console.WriteLine($"2. Constructor : {a}");
    //    }

    //    public MyClass(int a,string b) : this(a)
    //    {
    //        Console.WriteLine($"3. Constructor : {a} | {b }");
    //    }

    //}
    #endregion

    #region Record’lar da Constructor
    //public record MyRecord
    //{
    //    public MyRecord()
    //    {

    //    }
    //    public MyRecord(int a) : this()
    //    {

    //    }
    //}
    #endregion

    #region Destructor Metot Örnek - 1
    //public class MyClass
    //{
    //    public MyClass()
    //    {
    //        Console.WriteLine("Nesne Üretilmiştir.");
    //    }

    //    ~MyClass()
    //    {
    //        Console.WriteLine("Nesne İmha Ediliyor...");
    //    }

    //}
    #endregion
    #region Destructor Metot Örnek - 2

    //public class MyClass2
    //{
    //    int no;
    //    public MyClass2(int no)
    //    {
    //        this.no = no;
    //        Console.WriteLine($"{no}. Nesne Oluşturulmuştur.");
    //    }
    //    ~MyClass2()
    //    {
    //        Console.WriteLine($"{no}. Nesne İmha Edilmiştir...");
    //    }
    //}
    #endregion

    #region Deconstruct Metot
    //public class Person
    //{
    //    public string Name { get; set; }
    //    public int Age { get; set; }

    //    public void Deconstruct(out string name, out int age)
    //    {
    //        name = Name;
    //        age = Age;
    //    }
    //}
    #endregion

    #region Static Constructor
    class MyClass
    {
        public MyClass()
        {
            Console.WriteLine("Constructor Çalıştı");
        }

        static MyClass() //İsmi sınıf ismiyle aynı olacaktır.
        {
            //Static constructor'da geri dönüş değeri ve erişim belirleyicisi bildirilmez!
            //Overloading yapılmaz! Bir sınıfın içerisinde sade ve sadece bir tane tanımlanabilir.
            //Yani parametre almaz.
            //Üretilen ilk nesnenin dışında birdaha tetiklenmez.
            //Static construct'ın tetiklenebilmesi için illaha ilk nesne üretimi yapılmasına gerek yoktur. İlgili sınıf içerisinde herhangi bir static
            //yapılanmanında tetiklenmesi static construct'ın tetiklenmesini sağlayacaktır.

            Console.WriteLine("Static Constructor Çalıştı");

        }

    }
    #endregion
    #region Singleton Design Patterns
    //Bir sınıftan uygulama bazında sade ve sadece tek bir nesne oluşturulmasını istiyorsan kullanabileceğin bir design pattern.

    //public class Database
    //{
    //    private Database()
    //    {

    //    }

    //    public string ConnectionStrings { get; set; }

    //    static Database database;
    //    static public Database GetInstance
    //    {
    //        get
    //        {
    //            return database;
    //        }
    //    }
    //    static Database()
    //    {
    //        database = new Database();
    //    }
        #endregion

}

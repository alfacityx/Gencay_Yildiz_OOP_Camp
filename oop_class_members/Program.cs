using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_class_members
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Class Members
            #region Field
            //Nesne içerisinde değer tutmamızı sağlayan alanlardır.

            //MyClass m1 = new MyClass(); //Nesne Oluşturduk!!!
            ////m1.a = 5;
            //MyClass m2 = new MyClass(); //Nesne Oluşturduk!!!
            //m2.a = 25;

            //Fieldlar türüne özgü varsayılan değer alırlar.
            //Eğer bir değişken class içerisinde field olarak tanımlanıyorsa default değeri verilir.
            //Yok eğer class’ta değil metot vs.içerisinde tanımlanıyorsa default değer verilmez.
            //Console.WriteLine(m1.a);
            //int a;
            //Console.WriteLine(a);
            #endregion
            #region Property
            //Fiedlarda ki değerleri kontrollü bir şekilde dışarıya açan veya dışarıdan gelen değeri kontrollü bir şekilde fieldlara atamamızı sağlayan yapılanmadır.
            //MyClass myClass = new MyClass();
            //Console.WriteLine(myClass.Yasi); //Get bloğu çalışacak
            //myClass.Yasi = 65; //Set bloğu çalışacak
            //Console.WriteLine(myClass.Yasi);

            //myClass.Yasi = 12;
            //Console.WriteLine(myClass.Yasi);
            #endregion
            #region Metot
            //MyClass myClass = new MyClass();
            //myClass.X();

            #endregion
            #region Indexer
            //Nesneye indexer özelliğini kazandıran, fıtrat olarak property ile birebir aynı olan elemandır.
            MyClass myClass = new MyClass();
            //myClass[5] = 10;
            #endregion
            #endregion
        }
    }
    class MyClass
    {
        int a;//Field
        string b;

        //int yasi;

        #region Full Property
        //Property hangi türden bir field'ı temsil ediyorsa o türden olmalıdır...
        //Propertyler temsil ettikleri fied'ların isimlerinin baş harfi büyük olacak şekilde isimlendirilir.
        //public int Yasi
        //{
        //    get
        //    {
        //        //Property üzerinden değer talep edildiğinde bu blok tetiklenir.
        //        //Yani değer buradan gönderilir.
        //        return yasi;
        //    }
        //    set
        //    {
        //        yasi = value;
        //    }
        //}
        #endregion
        #region Prop Property
        //public int Yasi //Bu şekilde de kullanabiliriz fakat bu uzun yazım şeklidir.
        //{
        //    get
        //    {
        //        return yasi;
        //    }
        //    set
        //    {
        //        yasi = value;
        //    }
        //}

        //public int Yasi { get; set; }
        #endregion
        #region Auto Property Initializers Property
        //public int Yasi { get; set; } = 25;

        #endregion
        #region Ref Readonly Returns  
        //string adi = "Gençay Yıldız";
        //public ref readonly string Adi => ref adi;
        #endregion
        #region Computed(Hesaplanmış) Property
        //int sayi1 = 5;
        //int sayi2 = 10;
        //public int Topla
        //{
        //    get
        //    {
        //        return sayi1 + sayi2;
        //    }
        //}
        #endregion
        #region Expression-Bodied Property
        //Tanımlanan property’de Lambda Expression kullanmamızı sağlayan bir söz dizimidir.
        //Sadece readonly’ler de kullanılır.
        //Expression-Bodied propertyler, kısmi olarak Auto Property Initializers’ın akrabasıdır diyebiliriz.
        //public string Cinsiyet => "Erkek";
        #endregion
        #region Init-Only Properties ve Init Accessor
        //Init-Only Properties, nesnenin sadece ilk yaratılış anında propertylerine değer atamaktadır.
        //Böylece iş kuralı gereği runtime da değeri değişmemesi gereken nesneler için bir önlem alınmaktadır.
        //Init-Only properties, developer açısından süreç esnasında değiştirilmemesi gereken property değerlerinin -
        //“yanlışlıkla” değiştirilmesinin önüne geçmekte ve böylece olası hata ve buglardan yazılımı arındırmaktadır.
        #endregion


        #region Metot
        //Metotlarda illaha bir geri dönüş türü olmasına gerek yok fakat propertyler de illaha bir property türü olmak zorundadır.
        //Aralarında ki fark buradan çıkmıştır.
        //public int X()
        //{
        //    return 0;
        //}
        #endregion

        #region Indexer
        //public int this[int a]
        //{
        //    get
        //    {
        //        return a;
        //    }
        //    set
        //    {

        //    }
        //}
        #endregion

    }
}

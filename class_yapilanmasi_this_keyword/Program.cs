using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_yapilanmasi_this_keyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region this keywordü

            #region 1. Sınıfın Nesnesini Temsil Eder
            //İlgili sınıftan oluşturulmuş nesneyi sınıf modellemesinde temsil etmemizi sağlayan this keywordü'dür.
            //m1 nesnesi üzerinden X'i çağırdığımızda X metodu içerisinde ki this keywordü m1 nesnesini temsil edecektir.
            MyClass m1 = new MyClass();
            MyClass m2 = new MyClass();

            //m1.X();
            #endregion
            #region 2. Aynı İsimde Field İle Metot Parametrelerini Ayırmak İçin Kullanılır
            //Elimizdeki field, property veya metot isimleri bazen metot parametleri adları ile aynı olabiliyor.
            //Böyle durumlarda class'ın memberı olan yapılanma ile o anki metodun parametresini ayırmak için kullanıyoruz.
            #endregion

            //this keywordü ilgili class yapılanmasının o anki nesnesine karşılık gelir.
            //this kullanmak zorunda değiliz.

            #region 3. Constructer'dan Başka Bir Constructer'ı Çağırmak İçin Kullanılır

            #endregion

            #endregion
        }
    }
    class MyClass
    {
        //int a;
        //public void X(int a)
        //{
        //    this.a;
        //    a;
        //}
        
    }
}

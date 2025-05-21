using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
class NamespaceDışarısında
{

}

namespace oop_sinif
{
    class Namespaceİçerisinde
    {
        class ClassİçerisindeClass
        {

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Sınıf Nedir? Neden Sınıf Yapısı Kullanılır?
            //OOP’de bir object oluşturabilmek için öncelikle o objectin modellenmesi/tanımlanması gerekmektedir.
            //Bir objenin modelini tanımını oluşturabilmek için class yapısı kullanılır.
            #endregion
            #region Sınıf İle Nesne Arasındaki İlişki Nedir?
            //Sınıftan birden fazla nesne oluşturulabilir.
            //Class içerisine koyulan memberlar o classtan türetilen nesneler de ortak bulunmaktadır.Fakat değerler değişebilmektedir.
            //Bir modele karşı bir tane sınıf oluşturulur nesne ondan çoğul olarak türer.(Bire çok ilişki vardır)
            #endregion
            #region Sınıf Nasıl ve Nerede Oluşturulur?
            #region Namespace İçerisinde
            #endregion
            #region Namespace Dışarısında
            //Aynı namespace altında tanımlanan classlar birbirlerine isimleri üzerinden erişebilirler.
            //Farklı namespace altındaki classlar namespace ismi üzerinden birbirlerine erişebilirler.
            #endregion
            #region Class İçerisinde (Nested Type)
            #endregion
            //Bir class tanımlamasında tanımlanan yerde(namespace/dışı,class) aynı isimde birden fazla class tanımlanamaz!
            #endregion
            #region Sınıf İle Nesne Modeli Tasarlama
            #endregion
            #region Sınıf Modelinden Referans Noktası Oluşturma
            //Bir class tanımlandığında o class adı bir türdür. Haliyle o türü kullanabilmek için direkt olarak class adını kullanmamız yeterlidir.
            OrnekModel w;
            #endregion
        }
    }
    class OrnekModel
    {
        int a;
        int b;

        public void X()
        {
            Console.WriteLine(a + " " + b);
        }

        public int Y()
        {
            return a * b;
        }

    }
}

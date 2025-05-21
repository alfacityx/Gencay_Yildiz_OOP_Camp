using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_nesne_kopyalama_davranislari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Shallow Copy

            #region Örnek 1
            //MyClass m1 = new MyClass();
            //MyClass m2 = m1;
            //MyClass m3 = m2;
            //MyClass m4 = new MyClass();
            #endregion
            #region Örnek 2
            //MyClass m1 = null;
            //MyClass m2 = new MyClass();
            //MyClass m3 = m2;
            //m1 = m3;
            #endregion
            #region Örnek 3
            //MyClass m1 = new MyClass();
            //MyClass m2 = new MyClass();
            //MyClass m3 = m1;
            //m1 = m2;
            //m2 = m1;
            //m1 = m1;

            #endregion



            #endregion
            #region Deep Copy
            MyClass m1 = new MyClass();
            MyClass m2 = m1; //Shallow Copy
            MyClass m3 = m1.Clone(); //Deep Copy
            #endregion
        }
    }
    class MyClass
    {
        public MyClass Clone()
        {
            //MemberwiseClone bir sınıfın içerisinde o sınıftan üretilmiş olan o anki nesneyi klonlamamızı sağlayan bir fonksiyondur. Ve geriye object türünde değer döndürür.
            return (MyClass)this.MemberwiseClone();
        }
    }
}

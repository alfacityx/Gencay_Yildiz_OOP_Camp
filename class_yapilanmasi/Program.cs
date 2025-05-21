using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_yapilanmasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Class İçerisinde Tanımlanan Class Sınıf Elamanı Mıdır?
            //Bir class içerisinde tanımlanmış sınıflar kesinlikle sınıf elemanı değildir.
            MyClass m1 = new MyClass();
            #endregion
            #region Class Elemanlarına Açıklama Satırı Nasıl Eklenir?
            Random random = new Random();

            MyClass myClass = new MyClass();

            myClass.X();
            #endregion
        }
    }

    /// <summary>
    /// Bu bir Class açıklamasıdır.
    /// </summary>
    class MyClass
    {
        int a;
        /// <summary>
        /// Bu bir property'dir.
        /// </summary>
        public int MyProperty { get; set; }
        /// <summary>
        /// Bu bir metottur.
        /// </summary>
        public void X() { }
        /// <summary>
        /// Bu bir Örnek Metot Overloadıdır.
        /// </summary>
        /// <param name="a">a parametresi...</param>
        public void X(int a) { }
        public int this[int a]
        { 
            get{ return 0; }
        }
        public class MyClass2
        {
            
        }
    }
}

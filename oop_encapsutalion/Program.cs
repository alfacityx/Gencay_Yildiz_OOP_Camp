using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_encapsutalion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass m = new MyClass();
            //m.ASet(15);
            //Console.WriteLine(m.AGet());

            m.A = 1;
            Console.WriteLine(m.A);
            MyClass m2 = new();
            
        }
    }
    class MyClass
    {
        int a;
        #region Eskiden Encapsulation Nasıl Yapılırdı?
        //public int AGet()
        //{
        //    return this.a;
        //}
        //public void ASet(int value)
        //{
        //    this.a = value;
        //}
        #endregion
        //Full property kendi fieldımızı oluşturduğumuzda kullanırdık.
        public int A
        {
            get
            {
                return a;
            }
            set
            {
                a = value;
            }
        }

    }
}

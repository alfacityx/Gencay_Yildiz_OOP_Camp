using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_siniftan_nesne_üretme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            new MyClass();

            new Random();

            new MyClass();
            new MyClass();
            new MyClass();
            new MyClass();

            //MyClass myClass = new ();

        }
    }
    class MyClass
    {
        public int A { get; set; }
        public void X()
        {

        }

    }
}

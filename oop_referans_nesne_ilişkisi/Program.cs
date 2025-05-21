using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_referans_nesne_ilişkisi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //MyClass m = new MyClass();
            //m.MyProperty = 10;


            //MyClass m2 = null;
            //m2.MyProperty = 20;

            #region Referanssız Nesne Üzerindeki Elemanlara Nasıl Erişilir?
            new MyClass();

            //Referanssız nesne oluşturabiliriz.Lakin bu nesne sistemde/ memoryde lüzumsuz yer kaplayacağından dolayı belli bir süre sonra Garbage Collector -
            //dediğimiz çöp toplayıcısı tarafından temizlenecektir.
            //Garbage Collector: HEAP'te referanssız olan nesneleri imha etmekten/temizlemekten sorumlu bir yapılanmadır.
            #endregion
            #region Object Initializer İle Nesne Oluşturma Esnasında Propertylere İlk Değer Atama
            MyClass m = new MyClass()
            {
                //Bu nesne ilk oluşturulduğunda Object Initializer ile içerisindeki propertylerin değerleri verildiğinden dolayı verilen değerler ile oluşturulacaktır.
                MyProperty = 10,
                MyProperty2 = 30,
                MyProperty3 = 50,
            };

            //Bu nesne oluşturulduğunda ise içerisineki propertylerin değerleri default olarak verilecektir.
            MyClass m2 = new MyClass();
            m2.MyProperty = 10;

            //Eğer ki bir nesne referanssız olarak oluşturulacaksa ve içerisindeki propertylere değer atamak istersek aynı şekilde Object Initializer’ı kullanabiliriz.
            new MyClass()
            {
                MyProperty = 10,
                MyProperty2 = 30,
                MyProperty3 = 50,
            };


            #endregion

        }
    }
    class MyClass
    {
        public int MyProperty { get; set; }
        public int MyProperty2 { get; set; }
        public int MyProperty3 { get; set; }

    }
}

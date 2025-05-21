namespace oop_encapsutalion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Statik Çok Biçimlilik
            //Matematik m = new Matematik();
            //m.Topla(3, 1);
            #endregion
            #region Dinamik Çok Biçimlilik
            Arac arac = new Arac();
            arac.Calıstır();

            Taksi taksi = new Taksi();
            taksi.Calıstır();
            #endregion
            #region Polimorfizm Durumlarında Tür Dönüşümleri
            A a = new C();
            //D d = (D)a; //Hata
            D d = a as D; //Null

            #endregion

        }

    }
    #region Statik Çok Biçimlilik
    //class Matematik
    //{
    //    public long Topla(int s1, int s2)
    //    => s1 + s2;

    //    public long Topla(int s1, int s2, int s3)
    //   => s1 + s2 + s3;

    //    public long Topla(int s1, int s2, int s3, int s4)
    //   => s1 + s2 + s3 + s4;

    //}
    #endregion
    #region Dinamik Çok Biçimlilik
    class Arac
    {
        public virtual void Calıstır()
            => Console.WriteLine("Araç Çalıştı...");
    }

    class Taksi : Arac
    {
        public override void Calıstır()
        => Console.WriteLine("Taksi Çalıştı...");
    }
    #endregion

    #region Polimorfizm Durumlarında Tür Dönüşümleri
    class A { }
    class B:A { }
    class C:B { }
    class D:C { }
    #endregion
}
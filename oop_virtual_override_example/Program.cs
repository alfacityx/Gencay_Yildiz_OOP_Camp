namespace oop_virtual_override_example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Örnek - 1
            //Terlik terlik = new Terlik();
            //terlik.Bilgi();

            //Kalem kalem = new Kalem();
            //kalem.Bilgi();
            #endregion
            #region Örnek - 2
            //Maymun maymun = new Maymun();
            //maymun.Konus();

            //İnek inek = new İnek();
            //inek.Konus();          
            #endregion
            #region Örnek - 3
            Ucgen ucgen = new Ucgen(3, 4);
            Console.WriteLine(ucgen.AlanHesap());

            Dortgen dortgen = new Dortgen(3,4);
            Console.WriteLine(dortgen.AlanHesap());
            #endregion
        }
    }
    #region Örnek - 1
    //class Obje
    //{
    //    public virtual void Bilgi()
    //    {
    //        Console.WriteLine("Ben bir objeyim...");
    //    }

    //}
    //class Terlik : Obje
    //{
    //    public override void Bilgi()
    //    {
    //        Console.WriteLine("Ben bir terliğim");
    //    }
    //}
    //class Kalem : Obje
    //{
    //    public override void Bilgi()
    //    {
    //        Console.WriteLine("Ben bir Kalemim");
    //    }
    //}
    #endregion
    #region Örnek - 2
    //class Memeli
    //{
    //    public virtual void Konus()
    //    {
    //        Console.WriteLine("Ben konuşmuyorum...");
    //    }
    //}
    //class Maymun : Memeli 
    //{
    //    public override void Konus()
    //    {
    //        Console.WriteLine("Ben Bir Maymunum...");
    //    }
    //}
    //class İnek : Memeli
    //{
    //    public override void Konus()
    //    {
    //        Console.WriteLine("Ben Bir İneğim...");
    //    }
    //}
    #endregion
    #region Örnek - 3
    class Sekil
    {
        public int _boy;
        public int _en;
        public Sekil(int boy, int en)
        {
            _boy = boy;
            _en = en;
        }
        public virtual int AlanHesap()
        {
            return 0;
        }
    }
    class Ucgen : Sekil
    {
        public Ucgen(int boy, int en) : base(boy, en)
        {

        }
        public override int AlanHesap()
        {
            return _boy * _en / 2;
        }
    }
    class Dortgen : Sekil
    {
        public Dortgen(int boy, int en) : base(boy, en)
        {

        }
        public override int AlanHesap()
        {
            return _boy * _en;
        }
    }
    class Dikdortgen : Sekil
    {
        public Dikdortgen(int boy, int en) : base(boy, en)
        {

        }
        public override int AlanHesap()
        {
            return _boy * _en;
        }
    }
    #endregion
}
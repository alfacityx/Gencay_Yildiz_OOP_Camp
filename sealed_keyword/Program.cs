namespace sealed_keyword
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
    class A
    {
        virtual public void X()
        {
            Console.WriteLine("Merhaba Ben Ebu");
        }
    }

    class B : A
    {
        sealed override public void X()
        {
            Console.WriteLine("Merhaba Ben Gençay");
        }

    }
    class C : B
    {
        public override void X()
        {
            Console.WriteLine("Merhaba Ben Osman");
        }
    }  
}
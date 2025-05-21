namespace oop_polimorfizm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Örnek - 1
            //MyClass2 m = new MyClass();
            #endregion
            #region Örnek - 2
            //A a = new B(); //B nesnesini A referansıyla işaretlemek için A'dan B'ye kalıtım verilmelidir.
            //B b = new B();
            //C c = new B();
            #endregion
            #region Örnek - 3
            C c = new C();
            //c.
            B b = new C();
            //b.
            A a = new C();
            //a.
            #endregion

        }
    }
    #region Örnek - 1
    //class MyClass : MyClass2
    //{

    //}
    //class MyClass2
    //{

    //}
    #endregion
    #region Örnek - 2
    //class A:C
    //{

    //}
    //class B : A
    //{

    //}
    //class C
    //{
    //}
    #endregion
    #region Örnek - 3
    class A
    {
        public void X()
        {

        }
    }
    class B : A
    {
        public void Y()
        {

        }
    }
    class C : B
    {
        public void Z()
        {

        }
    }
    #endregion
}
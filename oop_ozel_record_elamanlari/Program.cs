namespace oop_ozel_record_elamanlari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyRecord m = new MyRecord();
            {
                var (n,s) = m;
            }
        }
    }
    record MyRecord(string name, string surname)
    {
        public MyRecord():this("sasa","sasaas")
        {
            
        }

    }
    #region Positional Record’lar da Ayrıca Constructor Tanımlayabilir Miyiz?
    #endregion
}
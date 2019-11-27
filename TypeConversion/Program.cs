using System;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            #region VeriKaybı
            int m = 444;
            byte k = (byte)m;

            Console.WriteLine(k);
            #endregion


            string sayi = "12321";
            int a = Convert.ToInt32(sayi);
            // byte a = Convert.ToByte(sayi); OverFlow
            int b = Int32.Parse(sayi);

            string yayinda = "true";
            bool c = Convert.ToBoolean(yayinda);
            bool d = Boolean.Parse(yayinda);

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);

        }
    }
}

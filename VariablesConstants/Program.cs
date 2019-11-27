using System;

namespace VariablesConstants
{
    class Program
    {
        static void Main(string[] args)
        {
            const decimal toplamFiyat = 55.5m;

            byte sayi = 4;
            short rakam = 7;
            int sira = 14;
            long tahta = 20;
            float indirim = 22.4f;
            double zam = 10;
            decimal fiyat = 43.5m;
            char karakter = 'M';
            string isim = "Murat";
            bool aktifMi = true;

            sayi = 5;
            // toplamFiyat = 75.5m; constants olduğu için değiştirelemez.

            Console.WriteLine(sayi);
            Console.WriteLine(toplamFiyat);
        }
    }
}

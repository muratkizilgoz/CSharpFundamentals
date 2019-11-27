using System;

namespace ConditionalStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            #region IfElse
            int hour = 9;

            if (hour > 6 && hour < 12)
            {
                Console.WriteLine("Günaydın");
            }
            else if (hour >= 12 && hour < 18)
            {
                Console.WriteLine("Tünaydın");
            }
            else if (hour >= 18 && hour < 24)
            {
                Console.WriteLine("İyi akşamlar");
            }
            else
            {
                Console.WriteLine("İyi geceler");
            }

            hour = 4;
            bool sabah;
            if (hour > 6 && hour < 12)
                sabah = true;
            else
                sabah = false;

            Console.WriteLine(sabah ? "Sabah" : "Sabah değil");
            #endregion


            var mevsim = Mevsimler.Ilkbahar;

            switch (mevsim)
            {
                case Mevsimler.Ilkbahar:
                    Console.WriteLine("ilkbahar");
                    break;
                case Mevsimler.Yaz:
                    Console.WriteLine("Yaz");
                    break;
                case Mevsimler.Sonbahar:
                    Console.WriteLine("Sonbahar");
                    break;
                case Mevsimler.Kıs:
                    Console.WriteLine("Kış");
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }


        }

    }
}

using System;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Veri giriniz :");
                var deger = Console.ReadLine();
                Console.WriteLine(FunctionString.ReverseValue(deger));
                Console.WriteLine("2. Method: "+  FunctionString.ReverseValue(deger, true) + " (Çıkmak için Esc tuşuna basınız)");

            } while (Console.ReadKey().Key != ConsoleKey.Escape);

        }

    }
}

using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 4;
            int b = 3;
            int c = 30;

            #region Arithmetic

            Console.WriteLine("Arithmetic");
            Console.WriteLine("topla: " + a + b + c);
            Console.WriteLine($"cikar: {a - (b - c)}");
            Console.WriteLine("bol: " + c / a / b);
            Console.WriteLine($"bol2: {(float)c / (float)a / (float)b}");
            Console.WriteLine("carp: " + a * b * c);
            Console.WriteLine("mod: " + c % 4);
            Console.WriteLine("birArttir: " + ++a);
            Console.WriteLine("birAzalt: " + --a);
            Console.WriteLine("---------Arithmetic End--------------");
            #endregion

            #region Comparison

            Console.WriteLine("Comparison");
            Console.WriteLine($"a > b:  {a > b}");
            Console.WriteLine($"a < b:  {a < b}");
            Console.WriteLine($"a <= c: {a <= c}");
            Console.WriteLine($"a >= c: {a >= c}");
            Console.WriteLine($"a == b: {a == b}");
            Console.WriteLine($"a != b: {a != b}");
            Console.WriteLine("--------------Comparison End ------");
            #endregion

            #region Logical

            Console.WriteLine("Logical");
            Console.WriteLine($"a > b && c > a: {a > b && c > a}");
            Console.WriteLine($"a < b || c > a: {a < b || c > a}");
            Console.WriteLine("----------Logical End-------------");
            #endregion


        }
    }
}

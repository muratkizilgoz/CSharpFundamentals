using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[3];
            sayilar[0] = 1;

            Console.WriteLine(sayilar[0]);
            Console.WriteLine(sayilar[1]);
            Console.WriteLine(sayilar[2]);

            Console.WriteLine();
            var kisiler = new string[3]
            {
                "Murat",
                "Elq",
                "Geralt"
            };

            Console.WriteLine(kisiler[0]);
            Console.WriteLine(kisiler[1]);
            Console.WriteLine(kisiler[2]);
            Console.WriteLine();

            int[] numbers = new int[] { 3, 1, 5, 6, 4, 9 };

            Console.WriteLine("index 3: " + Array.IndexOf(numbers, 3));

            Console.WriteLine("Clear()");
            Array.Clear(numbers, 0, 3);
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("Copy()");
            var numbers2 = new int[5];
            Array.Copy(numbers, numbers2, 5);
            foreach (var n in numbers2)
                Console.WriteLine(n);

            Console.WriteLine("Short()");
            Array.Sort(numbers);
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("Reverse()");
            Array.Reverse(numbers);
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }


        }
    }
}

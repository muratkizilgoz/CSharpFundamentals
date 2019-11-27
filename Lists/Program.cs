using System;
using System.Collections.Generic;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>() { 1, 2, 3, 4, 5, 6 };
            numbers.Add(3);
            numbers.AddRange(new int[3] { 7, 8, 9 });

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine();

            Console.WriteLine("Index 5: " + numbers.IndexOf(5));

            Console.WriteLine("Count: " + numbers.Count);
            Console.WriteLine();

            numbers.Remove(1);
            foreach (var n in numbers)
                Console.WriteLine(n);

            Console.WriteLine("Remove 3");
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == 3)
                    numbers.Remove(numbers[i]);
            }

            foreach (var n in numbers)
                Console.WriteLine(n);

            numbers.Clear();
            Console.WriteLine("Count: " + numbers.Count);

        }
    }
}

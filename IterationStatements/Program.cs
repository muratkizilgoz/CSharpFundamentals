using System;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            #region for
            for (int i = 0; i < 14; i++)
            {
                if (i % 5 == 1)
                    Console.WriteLine(i);
            }

            Console.WriteLine();

            for (int i = 14; i >= 0; i--)
            {
                if (i % 5 == 1)
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("----End For---------");
            #endregion

            #region Foreach
            string name = "Bruce Wayne";

            foreach (char c in name)
            {
                Console.WriteLine(c);
            }

            Console.WriteLine("------End Foreach----");
            #endregion

            #region While
            var k = 0;
            while (k <= 14)
            {
                if (k % 5 == 1)
                    Console.WriteLine(k);
                k++;
            }
            Console.WriteLine("");

            while (true)
            {
                Console.WriteLine("Whats ur name?");
                var input = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine($"Ad: {input}");
                    break;
                }
            }
            #endregion


        }
    }
}

using System;

namespace RandomClass
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(random.Next());
            }

            Console.WriteLine();

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(random.Next(1, 99999));
            }

            Console.WriteLine();

            const int passwordLength = 6;
            char[] passwordChars = new char[passwordLength];
            for (int i = 0; i < passwordLength; i++)
            {
                passwordChars[i] = (char)('a' + random.Next(0, 26));
            }
            var password = new string(passwordChars);

            Console.WriteLine(password);


        }
    }
}

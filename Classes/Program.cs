using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person
            {
                FirstName = "Elon",
                LastName = "Musk",
                Age = "45"
            };

            person.PrintPerson();

            #region Static
            var toplam = Math.Topla(3, 5);
            Console.WriteLine(toplam);
            #endregion

            var math = new Math();
            var carp = math.Carp(3, 5);
            Console.WriteLine(carp);

        }
    }
}

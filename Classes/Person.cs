using System;

namespace Classes
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Age { get; set; }

        public void PrintPerson()
        {
            Console.WriteLine("Ad: {0}, Soyad: {1}, Yaş: {2}", FirstName, LastName, Age);
        }

    }
}

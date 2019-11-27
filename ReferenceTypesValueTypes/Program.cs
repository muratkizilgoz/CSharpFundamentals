using System;

namespace ReferenceTypesValueTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            #region ValueTypes
            var a = 14;
            var b = a;
            b++;
            Console.WriteLine($"a: {a}, b: {b}");

            var number = 1;
            Increment(number);
            Console.WriteLine(number);
            #endregion

            #region ReferenceTypes
            var array1 = new int[3] { 1, 2, 3 };
            var array2 = array1;
            array2[0] = 0;
            Console.WriteLine($"array1[0]: {array1[0]} - array2[0]: {array2[0]}");

            var person = new Person { Age = 30 };
            Increment2(person);
            Console.WriteLine(person.Age);
            #endregion

        }

        public static void Increment(int number)
        {
            number += 10;
        }

        public class Person
        {
            public int Age { get; set; }
        }

        public static void Increment2(Person person)
        {
            person.Age += 10;
        }
    }
}

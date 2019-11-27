using System;
using System.Text;


namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.OutputEncoding = System.Text.Encoding.UTF8;

            string firstName = "Bruce";
            string lastName = "Wayne ";

            string fullName = firstName + " " + lastName;
            string fullName1 = $"{firstName} {lastName}";

            Console.WriteLine("fullName: " + fullName);
            Console.WriteLine("fullName1: " + fullName1);

            string[] names = new string[3]
            {
                "Elon",
                "Bruce",
                "Gerald"
            };

            var formattedNames = string.Join(",", names);
            Console.WriteLine("formattedNames: " + formattedNames);

            var desc = "Lorem \nipsum \t tab text \\Elon \'Will\' \"Smith\" ";
            Console.WriteLine("desc: " + desc);
            Console.WriteLine();

            var desc2 = @"Lorem
ipsum   tab \Elon 'Will' ";
            Console.WriteLine("desc2: " + desc2);
            Console.WriteLine();

            Console.WriteLine($"Trim: '{fullName.Trim()}'");
            Console.WriteLine($"ToUpper: '{fullName.Trim().ToUpper()}'");

            var index = fullName.IndexOf(' ');
            Console.WriteLine("IndexOf: " + index);
            var firstName1 = fullName.Substring(0, index);
            var lastName1 = fullName.Substring(index + 1);
            Console.WriteLine("Substring(): " + firstName1 +" " + lastName1);

            var names1 = fullName1.Split(' ');
            Console.WriteLine($"Split(): {names1[0]} {names1[1]}");
            Console.WriteLine();

            Console.WriteLine("Replace(): " + fullName1.Replace("Bruce", "Thomas"));
            Console.WriteLine();

            if (string.IsNullOrWhiteSpace(" "))
                Console.WriteLine("String null or white space");
            Console.WriteLine();

            float price = 9.99f;
            Console.WriteLine("Currency: " + price.ToString("C"));
            Console.WriteLine();

            string lorem =
                "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.";

            Console.WriteLine("Short Text: " + Function.ShortText(lorem, 30));
            Console.WriteLine();

            var stringBuilder = new StringBuilder("StringBuilder ");
            stringBuilder
                .Append("text")
                .AppendLine()
                .Append("text again");
            Console.WriteLine(stringBuilder);

        }
    }
}

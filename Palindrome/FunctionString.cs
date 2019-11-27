using System.Linq;

namespace Palindrome
{
    public class FunctionString
    {
        public static string ReverseValue(string value)
        {
            if (string.IsNullOrWhiteSpace(value)) return "Boş veri girdiniz";
            char[] array = value.ToCharArray().Reverse().ToArray();
            string reversed = new string(array);
            return value == reversed ? $"{value} palindrome '{reversed}'" : $"{value} palindrome değil '{reversed}'";
        }
        //overload
        public static string ReverseValue(string value, bool alternatif)
        {
            if (string.IsNullOrWhiteSpace(value)) return "Boş veri girdiniz";
            char[] array = new char[value.Length];

            for (int i = value.Length - 1; i >= 0; i--)
            {
                array[value.Length - i - 1] = value[i];
            }

            string reversed = new string(array);
            return value == reversed ? $"{value} palindrome '{reversed}'" : $"{value} palindrome değil '{reversed}'";
        }
    }
}

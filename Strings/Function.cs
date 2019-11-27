using System;
using System.Collections.Generic;
using System.Text;

namespace Strings
{
    public class Function
    {
        public static string ShortText(string text, int length=14)
        {
            if (text.Length < length)
                return text;

            string[] words = text.Split(' ');
            List<string> shortText = new List<string>();
            int counter = 0;

            foreach (var word in words)
            {
                counter += word.Length + 1;
                shortText.Add(word);
                if (counter > length)
                    break;
            }

            return string.Join(" ", shortText) + "...";
        }
    }
}

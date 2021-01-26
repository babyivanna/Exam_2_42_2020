using System;

namespace CourseApp
{
    public class Program
    {
        public static string ReversedString(string str)
        {
            string[] words = str.Split(new char[] { ' ' });
            int wordsLength = words.Length;
            string[] reversedWords = new string[wordsLength];

            for (int i = 0; i < wordsLength; i++)
            {
                reversedWords[wordsLength - i - 1] = words[i];
            }

            string reversedStr;
            reversedStr = string.Join(" ", reversedWords);

            return reversedStr;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine(ReversedString("Mama myla ramu"));
        }
    }
}

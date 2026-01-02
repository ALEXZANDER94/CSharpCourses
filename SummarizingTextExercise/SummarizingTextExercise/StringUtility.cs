using System;
using System.Collections.Generic;
using System.Text;

namespace SummarizingTextExercise
{
    public class StringUtility
    {
        public static string SummarizeText(string text, int maxLength = 20)
        {
            if (text.Length < maxLength)
            {
                return text;
            }

            string[] words = text.Split(' ');
            int totalCharacters = 0;
            var summaryWords = new List<string>();
            foreach (string word in words)
            {
                summaryWords.Add(word);
                totalCharacters += word.Length + 1; // add 1 for the space

                if (totalCharacters > maxLength)
                {
                    break;
                }
            }

            return String.Join(" ", summaryWords) + "...";
        }
    }
}

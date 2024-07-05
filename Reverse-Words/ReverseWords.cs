using System;

namespace challenges_and_data_structures1
{
    public static class ReverseWords
    {
        public static string ReverseOrder(string input)
        {
            if (string.IsNullOrWhiteSpace(input)) return input;
            
            string[] words = input.Split(' ');
            string[] strings = new string[words.Length];    

            for (int i = words.Length - 1; i >= 0 ; i--)
              strings[i] = words[words.Length - 1 - i];
            
            string result = string.Join(' ', strings);
            return result;
        }
    }
}


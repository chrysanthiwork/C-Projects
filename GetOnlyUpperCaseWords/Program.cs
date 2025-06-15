using System;

namespace Coding.Exercise
{
    public class Exercise
    {
        public List<string> GetOnlyUpperCaseWords(List<string> words)
        {
            List<string> result = new List<string>();
            foreach (var word in words)
            {
                bool isUppercase = word == word.ToUpper();
                bool onlyLetters = word.All(Char.IsLetter);
                if (isUppercase && !result.Contains(word) && onlyLetters)
                {
                    result.Add(word);
                }
            }
            return result;
        }
    }
}
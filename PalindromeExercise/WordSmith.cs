using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeExercise
{
    public class WordSmith
    {

        public bool IsAPalindrome(string word)
        {
            if (string.IsNullOrEmpty(word))
            {
                return false;
            }

            string cleanWord = word.Replace(" ", "").ToLower();

            int left = 0;
            int right = cleanWord.Length - 1;

            while (left < right)
            {
                if (cleanWord[left] != cleanWord[right])
                {
                    return false;
                }
                left++;
                right--;
            }
            return true;
        }


    }
}

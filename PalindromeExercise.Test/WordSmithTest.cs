using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeExercise.Test
{
    public class WordSmithTest
    {

        [Theory]
        [InlineData("racecar", true)]
        [InlineData("Jon", false)]
        [InlineData("radar", true)]
        [InlineData("TrueCoder", false)]
        [InlineData("Madam", true)]
        [InlineData("Rotor", true)]
        [InlineData("Level", true)]
        [InlineData("", false)]
        [InlineData(null, false)]
        public void IsAPalindrome_Test(string word, bool expected)
        {
            var ws = new WordSmith();

            var actual = ws.IsAPalindrome(word);

            Assert.Equal(expected, actual);
        }
    }
}

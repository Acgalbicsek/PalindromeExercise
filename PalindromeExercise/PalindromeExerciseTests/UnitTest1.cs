using Microsoft.VisualStudio.TestPlatform.CoreUtilities.Extensions;
using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("level", true)]
        [InlineData("Barrow", false)]
        public void PalindromeTest(string word, bool expected)
        {
            //arrange
            var tester = new WordSmith();

            //act
            var actual = tester.IsAPalindrome(word);

            //assert
            Assert.Equal(expected, actual);


        }

        
    }
}

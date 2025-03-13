using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("moon", false)]
        [InlineData("clock", false)]
        [InlineData("playopalp", false)]
        [InlineData("zone", false)]// ? you will need to put some test data and expected result here.  

        // For example [InlineData(“racecar”, true)]

        public void Test1(string word, bool expected)
        {
            //Arrange
            var testWord = new WordSmith();
            //Act
            var actual = testWord.IsAPalindrome(word);
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}

using System.Linq;
using PalindromeExercise;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("hello", false)]
        [InlineData("wow", true)]
        [InlineData ("hat",false)]
        [InlineData("radar", true)]
        [InlineData("soccer",false)]


        public void PalodromeTest(string word, bool expected)
        {
            var wordsmith = new WordSmith();

            var actual = wordsmith.IsAPalindrome(word);

            Assert.Equal(expected, actual);
            
        }
    }
}

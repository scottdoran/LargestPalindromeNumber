using PalindromeSolution;

namespace LargestPalindromeNumberTests
{
    public class PalindromeScenarios
    {
        [Fact]
        public void LargestPalindromeIsReturned()
        {
            //Arrange
            var palindrome = new Palindrome();

            //Act
            var result = palindrome.GetLargestPalindrome();
            var testNumber = 906609;

            //Assert
            Assert.Equal(testNumber, result);
        }

        [Fact]
        public void NumberIsReversed()
        {
            //Arrange
            var palindrome = new Palindrome();
            var testNumber = 123456;

            //Act
            var result = palindrome.Reverse(testNumber);
            var reverseNumber = 654321;

            //Assert
            Assert.Equal(reverseNumber, result);
        }
    }
}
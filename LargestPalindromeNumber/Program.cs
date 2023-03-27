/*
A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
Find the largest palindrome made from the product of two 3-digit numbers.
*/

namespace PalindromeSolution
{
    class Program
    {
        static void Main()
        {
            Palindrome palindrome = new();
            int result = palindrome.GetLargestPalindrome();
            palindrome.OutputResult(result);
        }
    }

    public class Palindrome
    {
        public int GetLargestPalindrome()
        {
            int palindrome = 0;           
            for (int i = 999; i >= 100; i--)  // start with higher numbers that decrement
            {
                for (int j = i; j >= 100; j--) // second loop to begin from the integer of the first loop to avoid duplicates
                {
                    int result;
                    result = i * j; //calculate the product from two 3 digit numbers
                    if (result == Reverse(result)) //check product against reversed product
                    {
                        if (result > palindrome) //check if highest palindrome
                        {
                            palindrome = result;
                        }
                    }
                }
            }
            return palindrome;
        }

        // Iterative function to reverse digits of number
        public int Reverse(int num)
        {
            int rev_num = 0;
            while (num > 0)
            {
                rev_num = rev_num * 10 + num % 10;
                num /= 10;
            }
            return rev_num;
        }

        // Function to output result to console
        public void OutputResult(int result)
        {
            Console.Write(result);
            Console.Read();
        }
    }
}

/*
Comments On Code
================
- Added ReadLine after Write so that output remains on screen to read.
- Removed the need to convert number to string and used calculation instead to reverse number to optimize performance time.
- Start the loops from 999 to 100 instead of 100 to 999. As the objective is to find the largest number and if starting 
  from largest three-digit numbers, you can expect to reach the result faster and sooner.
- To avoid checking duplicates, changed second loop to begin from the integer of the first loop. This reduces the
  number of comparisions by half.
- Use more meaningful variable names e.g. 'result' instead of 'yb'.
- Refactored code into classes to assist with unit testing.
- Broke the code down into functions to make it more extensible and unit tested.
*/



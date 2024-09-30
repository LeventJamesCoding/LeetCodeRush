//Write an algorithm to determine if a number n is happy.

//A happy number is a number defined by the following process:

//Starting with any positive integer, replace the number by the sum of the squares of its digits.
//Repeat the process until the number equals 1 (where it will stay), or it loops endlessly in a cycle which does not include 1.
//Those numbers for which this process ends in 1 are happy.
//Return true if n is a happy number, and false if not.

 

//Example 1:

//Input: n = 19
//Output: true
//Explanation:
//12 + 92 = 82
//82 + 22 = 68
//62 + 82 = 100
//12 + 02 + 02 = 1
//Example 2:

//Input: n = 2
//Output: false



//Constraints:

//1 <= n <= 231 - 1
namespace Happy_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.ReadLine();
        }
        public class Solution
        {
            private int n1 = 19, n2 = 2;
            public Solution()
            {
                Console.WriteLine($"Inputs: n = {n1}; Output = {IsHappy(n1)}, Expected = True");
                Console.WriteLine($"Inputs: n = {n2}; Output = {IsHappy(n2)}, Expected = False");
            }
            public bool IsHappy(int n)
            {
                int iterations = 0;

                while (iterations < 7) //7 repetitions are enough for a number to be a happy number.
                {
                    if (SumOfSquareDigits(n) == 1)
                    {
                        return true;
                    }
                    else
                    {
                        n = SumOfSquareDigits(n);
                        iterations++;
                    }
                }
                return false;
            }
            public int SumOfSquareDigits(int number)
            {
                int theSum = 0;
                while (number > 0)
                {
                    int lastDigit = number % 10;
                    theSum += lastDigit * lastDigit;
                    number /= 10;
                }
                return theSum;
            }
        }
    }
}

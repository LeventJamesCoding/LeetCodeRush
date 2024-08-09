using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Palindrome Number
//Difficulty: Easy
//Given an integer x, return true if x is a 
//palindrome
//, and false otherwise.



//Example 1:

//Input: x = 121
//Output: true
//Explanation: 121 reads as 121 from left to right and from right to left.
//Example 2:

//Input: x = -121
//Output: false
//Explanation: From left to right, it reads -121. From right to left, it becomes 121-. Therefore it is not a palindrome.
//Example 3:

//Input: x = 10
//Output: false
//Explanation: Reads 01 from right to left.Therefore it is not a palindrome.


//Constraints:

//-231 <= x <= 231 - 1
namespace Palindrome_Number
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
            private int x1 = 121;
            private int x2 = -121;
            private int x3 = 10;

            public Solution()
            {
                Console.WriteLine($"Input value: {x1}; Output: {IsPalindrome(x1).ToString()}, Expected: True");
                Console.WriteLine($"Input value: {x2}; Output: {IsPalindrome(x2).ToString()}, Expected: False");
                Console.WriteLine($"Input value: {x3}; Output: {IsPalindrome(x3).ToString()}, Expected: False");
            }
            public bool IsPalindrome(int x)
            {
                string _x = x.ToString();
                int j = _x.Length - 1;
                for (int i = 0; i < _x.Length; i++)
                {
                    if (_x[i] != Convert.ToString(x)[j])
                    {
                        return false;
                    }
                    j--;
                }
                return true;
            }
        }
    }
}

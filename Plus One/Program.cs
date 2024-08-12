using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Plus One
//Difficulty: Easy
//You are given a large integer represented as an integer array digits, where each digits[i] is the ith digit of the integer. The digits are ordered from most significant to least significant in left-to-right order. The large integer does not contain any leading 0's.

//Increment the large integer by one and return the resulting array of digits.

 

//Example 1:

//Input: digits = [1,2,3]
//Output: [1,2,4]
//Explanation: The array represents the integer 123.
//Incrementing by one gives 123 + 1 = 124.
//Thus, the result should be [1,2,4].
//Example 2:

//Input: digits = [4,3,2,1]
//Output: [4,3,2,2]
//Explanation: The array represents the integer 4321.
//Incrementing by one gives 4321 + 1 = 4322.
//Thus, the result should be [4,3,2,2].
//Example 3:

//Input: digits = [9]
//Output: [1,0]
//Explanation: The array represents the integer 9.
//Incrementing by one gives 9 + 1 = 10.
//Thus, the result should be [1,0].
 

//Constraints:

//1 <= digits.length <= 100
//0 <= digits[i] <= 9
//digits does not contain any leading 0's.You are given a large integer represented as an integer array digits, where each digits[i] is the ith digit of the integer. The digits are ordered from most significant to least significant in left-to-right order. The large integer does not contain any leading 0's.

//Increment the large integer by one and return the resulting array of digits.

 

//Example 1:

//Input: digits = [1,2,3]
//Output: [1,2,4]
//Explanation: The array represents the integer 123.
//Incrementing by one gives 123 + 1 = 124.
//Thus, the result should be [1,2,4].
//Example 2:

//Input: digits = [4,3,2,1]
//Output: [4,3,2,2]
//Explanation: The array represents the integer 4321.
//Incrementing by one gives 4321 + 1 = 4322.
//Thus, the result should be [4,3,2,2].
//Example 3:

//Input: digits = [9]
//Output: [1,0]
//Explanation: The array represents the integer 9.
//Incrementing by one gives 9 + 1 = 10.
//Thus, the result should be [1,0].
 

//Constraints:

//1 <= digits.length <= 100
//0 <= digits[i] <= 9
//digits does not contain any leading 0's.
namespace PlusOne
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
            private int[] digits1 = new int[] { 1, 2, 3 };
            private int[] digits2 = new int[] { 4, 3, 2, 1 };
            private int[] digits3 = new int[] { 9 };

            public Solution()
            {
                Console.WriteLine("Digits1: " + ArrayToString(digits1) + "; Output: " + ArrayToString(PlusOne(digits1)) + ", expected: [1,2,4]");
                Console.WriteLine("Digits2: " + ArrayToString(digits2) + "; Output: " + ArrayToString(PlusOne(digits2)) + ", expected: [4,3,2,2]");
                Console.WriteLine("Digits3: " + ArrayToString(digits3) + "; Output: " + ArrayToString(PlusOne(digits3)) + ", expected: [1, 0]");
            }

            public int[] PlusOne(int[] digits)
            {
                if (digits[digits.Length - 1] != 9)
                {
                    digits[digits.Length - 1]++;
                    return digits;
                }

                List<int> _digits = new List<int>();
                int lastIndex = digits.Length - 1;
                while (lastIndex >= 0)
                {
                    int lastElement = digits[lastIndex];
                    lastElement++;
                    if (lastElement == 10)
                    {
                        _digits.Insert(0, 0);
                    }
                    else
                    {
                        _digits.Insert(0, lastElement);
                        for (int i = lastIndex - 1; i >= 0; i--)
                        {
                            _digits.Insert(0, digits[i]);
                        }
                        break;
                    }
                    lastIndex--;
                }
                if (_digits[0] == 0)
                    _digits.Insert(0, 1);

                return _digits.ToArray();

            }
            private string ArrayToString(int[] arr)
            {
                if (arr == null)
                {
                    return null;
                }
                return "[" + string.Join(",", arr) + "]";
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Sqrt(x)
//Diffsiculty: Easy
//Given a non-negative integer x, return the square root of x rounded down to the nearest integer. The returned integer should be non-negative as well.

//You must not use any built-in exponent function or operator.

//For example, do not use pow(x, 0.5) in c++ or x ** 0.5 in python.


//Example 1:

//Input: x = 4
//Output: 2
//Explanation: The square root of 4 is 2, so we return 2.
//Example 2:

//Input: x = 8
//Output: 2
//Explanation: The square root of 8 is 2.82842..., and since we round it down to the nearest integer, 2 is returned.


//Constraints:

//0 <= x <= 231 - 1

namespace Sqrt_x_
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
            private int x1 = 4, x2 = 8;
            public Solution()
            {
                Console.WriteLine($"Input: {x1}; Output: {MySqrt(x1)}, Expected: 2");
                Console.WriteLine($"Input: {x2}; Output: {MySqrt(x2)}, Expected: 2");
            }
            public int MySqrt(int x) // using binary search algorithm
            {
                if (x < 2) return x;
                int left = 1, right = x / 2;

                while (left <= right)
                {
                    int mid = left + (right - left) / 2;
                    long square = (long)mid * mid;

                    if (square == x)
                    {
                        return mid;
                    }
                    else if (square < x)
                    {
                        left = mid + 1;
                    }
                    else
                    {
                        right = mid - 1;
                    }
                }

                return right;
            }
        }
    }
}
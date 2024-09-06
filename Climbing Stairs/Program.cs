using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
//Climbing Stairs
//Difficulty: Easy
//You are climbing a staircase. It takes n steps to reach the top.

//Each time you can either climb 1 or 2 steps. In how many distinct ways can you climb to the top?

 

//Example 1:

//Input: n = 2
//Output: 2
//Explanation: There are two ways to climb to the top.
//1. 1 step + 1 step
//2. 2 steps
//Example 2:

//Input: n = 3
//Output: 3
//Explanation: There are three ways to climb to the top.
//1. 1 step + 1 step + 1 step
//2. 1 step + 2 steps
//3. 2 steps + 1 step
 

//Constraints:

//1 <= n <= 45
namespace Climbing_Stairs
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
            private int n1 = 2, n2 = 3;
            public Solution()
            {
                Console.WriteLine($"Input: n = {n1}; Output = {ClimbStairs(n1)}, Expected = 2");
                Console.WriteLine($"Input: n = {n2}; Output = {ClimbStairs(n2)}, Expected = 3");
            }
            public int ClimbStairs(int n)
            {
                List<int> fibonacciNumbers = new List<int>() { 1, 1 };

                if (n == 1)
                    return 1;

                if (n == 2)
                    return 2;


                for (int i = 2; i <= n; i++)
                {
                    fibonacciNumbers.Add(fibonacciNumbers[i - 2] + fibonacciNumbers[i - 1]);
                }
                return fibonacciNumbers[n];
            }
        }
    }
}
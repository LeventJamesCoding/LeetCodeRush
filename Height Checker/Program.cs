using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Height Checker
//Difficulty: Easy
//A school is trying to take an annual photo of all the students. The students are asked to stand in a single file line in non-decreasing order by height. Let this ordering be represented by the integer array expected where expected[i] is the expected height of the ith student in line.

//You are given an integer array heights representing the current order that the students are standing in. Each heights[i] is the height of the ith student in line (0-indexed).

//Return the number of indices where heights[i] != expected[i].



//Example 1:

//Input: heights = [1,1,4,2,1,3]
//Output: 3
//Explanation: 
//heights:  [1,1,4,2,1,3]
//expected: [1,1,1,2,3,4]
//Indices 2, 4, and 5 do not match.
//Example 2:

//Input: heights = [5,1,2,3,4]
//Output: 5
//Explanation:
//heights:  [5,1,2,3,4]
//expected: [1,2,3,4,5]
//All indices do not match.
//Example 3:

//Input: heights = [1,2,3,4,5]
//Output: 0
//Explanation:
//heights:  [1,2,3,4,5]
//expected: [1,2,3,4,5]
//All indices match.


//Constraints:

//1 <= heights.length <= 100
//1 <= heights[i] <= 100A school is trying to take an annual photo of all the students. The students are asked to stand in a single file line in non-decreasing order by height. Let this ordering be represented by the integer array expected where expected[i] is the expected height of the ith student in line.

//You are given an integer array heights representing the current order that the students are standing in. Each heights[i] is the height of the ith student in line (0-indexed).

//Return the number of indices where heights[i] != expected[i].



//Example 1:

//Input: heights = [1,1,4,2,1,3]
//Output: 3
//Explanation: 
//heights:  [1,1,4,2,1,3]
//expected: [1,1,1,2,3,4]
//Indices 2, 4, and 5 do not match.
//Example 2:

//Input: heights = [5,1,2,3,4]
//Output: 5
//Explanation:
//heights:  [5,1,2,3,4]
//expected: [1,2,3,4,5]
//All indices do not match.
//Example 3:

//Input: heights = [1,2,3,4,5]
//Output: 0
//Explanation:
//heights:  [1,2,3,4,5]
//expected: [1,2,3,4,5]
//All indices match.


//Constraints:

//1 <= heights.length <= 100
//1 <= heights[i] <= 100
namespace Height_Checker
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
            private int[] heights1 = new int[] { 1, 1, 4, 2, 1, 3 };
            private int[] heights2 = new int[] { 5, 1, 2, 3, 4 };
            public Solution()
            {
                Console.WriteLine($"Input = [1,1,4,2,1,3]; Output = {HeightChecker(heights1)}, Expected = 3");
                Console.WriteLine($"Input = [5,1,2,3,4]; Output = {HeightChecker(heights2)}, Expected = 5");
            }
            public int HeightChecker(int[] heights)
            {
                int[] _heights = new int[heights.Length];

                for (int i = 0; i < heights.Length; i++)
                    _heights[i] = heights[i];

                Array.Sort(heights);
                int counter = 0;

                for (int i = 0; i < heights.Length; i++)
                {
                    if (_heights[i] != heights[i])
                        counter++;
                }
                return counter;
            }
        }
    }
}

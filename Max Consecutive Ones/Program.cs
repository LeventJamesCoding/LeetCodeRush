using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Max Consecutive Ones
//Difficulty: Easy
//Given a binary array nums, return the maximum number of consecutive 1's in the array.



//Example 1:

//Input: nums = [1, 1, 0, 1, 1, 1]
//Output: 3
//Explanation: The first two digits or the last three digits are consecutive 1s. The maximum number of consecutive 1s is 3.
//Example 2:

//Input: nums = [1, 0, 1, 1, 0, 1]
//Output: 2



//Constraints:

//1 <= nums.length <= 105
//nums[i] is either 0 or 1.
namespace Max_Consecutive_Ones
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
            private int[] nums1 = new int[] { 1, 1, 0, 1, 1, 1 };
            private int[] nums2 = new int[] { 1, 0, 1, 1, 0, 1 };
            public Solution()
            {
                Console.WriteLine($"Input: [1, 1, 0, 1, 1, 1]; Output: {FindMaxConsecutiveOnes(nums1)}, Expected: 3");
                Console.WriteLine($"Input: [1, 0, 1, 1, 0, 1]; Output: {FindMaxConsecutiveOnes(nums2)}, Expected: 2");
            }
            public int FindMaxConsecutiveOnes(int[] nums)
            {
                int counter = 0;
                int _counter = counter;
                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] == 1)
                    {
                        _counter++;
                    }

                    if (counter < _counter)
                        counter = _counter;

                    if (nums[i] == 0)
                    {
                        _counter = 0;
                    }
                }
                return counter;
            }
        }
    }
}
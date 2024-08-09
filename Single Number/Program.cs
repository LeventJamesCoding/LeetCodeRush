using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Single Number
//Difficulty: Easy
//Given a non-empty array of integers nums, every element appears twice except for one. Find that single one.

//You must implement a solution with a linear runtime complexity and use only constant extra space.



//Example 1:

//Input: nums = [2, 2, 1]
//Output: 1
//Example 2:

//Input: nums = [4, 1, 2, 1, 2]
//Output: 4
//Example 3:

//Input: nums = [1]
//Output: 1



//Constraints:

//1 <= nums.length <= 3 * 104
//- 3 * 104 <= nums[i] <= 3 * 104
//Each element in the array appears twice except for one element which appears only once.

namespace Single_Number
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
            private int[] _nums = new int[] { 4, 1, 2, 1, 2 };
            private int[] nums1 = new int[] { 2, 2, 1 };
            public Solution()
            {
                Console.WriteLine($"nums = [4,1,2,1,2]; Output: {SingleNumber(_nums)}, Expected: 4");
                Console.WriteLine($"nums = [2,2,1]; Output: {SingleNumber(nums1)}, Expected: 1");
            }
            public int SingleNumber(int[] nums)
            {
                int returnValue = 0;
                int frequency = 0;
                if (nums.Length < 2)
                {
                    return nums[0];
                }
                for (int i = 0; i < nums.Length; i++)
                {
                    for (int j = 0; j < nums.Length; j++)
                    {
                        if (nums[i] == nums[j])
                        {
                            frequency++;
                        }
                    }
                    if (frequency == 1)
                    {
                        returnValue = nums[i];
                    }
                    frequency = 0;
                }
                return returnValue;
            }
        }
    }
}
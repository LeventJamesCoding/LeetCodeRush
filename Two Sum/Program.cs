using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Two Sum 
//Difficulty: Easy
//Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

//You may assume that each input would have exactly one solution, and you may not use the same element twice.

//You can return the answer in any order.



//Example 1:

//Input: nums = [2,7,11,15], target = 9
//Output: [0,1]
//Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
//Example 2:

//Input: nums = [3,2,4], target = 6
//Output: [1,2]
//Example 3:

//Input: nums = [3,3], target = 6
//Output: [0,1]


//Constraints:

//2 <= nums.length <= 104
//-109 <= nums[i] <= 109
//-109 <= target <= 109Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

//You may assume that each input would have exactly one solution, and you may not use the same element twice.

//You can return the answer in any order.



//Example 1:

//Input: nums = [2,7,11,15], target = 9
//Output: [0,1]
//Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
//Example 2:

//Input: nums = [3,2,4], target = 6
//Output: [1,2]
//Example 3:

//Input: nums = [3,3], target = 6
//Output: [0,1]


//Constraints:

//2 <= nums.length <= 104
//-109 <= nums[i] <= 109
//-109 <= target <= 109
namespace Two_Sum
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
            private int[] nums1 = new int[] { 2, 7, 11, 15 };
            private int target1 = 9;

            private int[] nums2 = new int[] { 3, 2, 4 };
            private int target2 = 6;

            private int[] nums3 = new int[] { 3, 3 };
            private int target3 = 6;
            public Solution()
            {
                Console.WriteLine($"nums1: [2, 7, 11, 15], target: 9 ; Output: " + ArrayToString(TwoSum(nums1, target1)) + ", Expected: [0,1]");
                Console.WriteLine("nums1: 3, 2, 4 , target: 6 ; Output: " + ArrayToString(TwoSum(nums2, target2)) + ", Expected: [1,2]");
                Console.WriteLine("nums1: [3, 3], target: 6 ; Output: " + ArrayToString(TwoSum(nums3, target3)) + ", Expected: [0,1]");
            }

            public int[] TwoSum(int[] nums, int target)
            {
                int[] outputArr = new int[2];
                for (int i = 0; i < nums.Length; i++)
                {
                    for (int j = 0; j < nums.Length; j++)
                    {
                        if (i == j)
                        {
                            j++;
                            if (j == nums.Length) break;
                        }
                        if (nums[i] + nums[j] == target)
                        {
                            outputArr[0] = j;
                            outputArr[1] = i;
                        }
                    }
                }
                return outputArr;
            }
            private string ArrayToString(int[] arr) // just for printing the array in string format by order.
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

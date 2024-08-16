using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Maximum Average Subarray I
//Difficulty: Easy
//You are given an integer array nums consisting of n elements, and an integer k.

//Find a contiguous subarray whose length is equal to k that has the maximum average value and return this value. Any answer with a calculation error less than 10-5 will be accepted.



//Example 1:

//Input: nums = [1, 12, -5, -6, 50, 3], k = 4
//Output: 12.75000
//Explanation: Maximum average is (12 - 5 - 6 + 50) / 4 = 51 / 4 = 12.75
//Example 2:

//Input: nums = [5], k = 1
//Output: 5.00000



//Constraints:

//n == nums.length
//1 <= k <= n <= 105
//- 104 <= nums[i] <= 104
namespace MaximumAverageSubarrayI
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
            private int[] nums1 = new int[] { 1, 12, -5, -6, 50, 3 };
            private int[] nums2 = new int[] { 5 };
            private int k1 = 4, k2 = 1;
            public Solution()
            {
                Console.WriteLine($"nums = [1, 12, -5, -6, 50, 3], k = 4; Output = {FindMaxAverage(nums1, k1)}, Expected = 12.75000");
                Console.WriteLine($"nums = [5], k = 1; Output = {FindMaxAverage(nums2, k2)}, Expected = 5.00000");
            }

            public double FindMaxAverage(int[] nums, int k)
            {
                double theSum = 0;
                for (int i = 0; i < k; i++)
                {
                    theSum += nums[i];
                }
                double maxAverage = theSum / k;
                for (int i = k; i < nums.Length; i++)
                {
                    theSum += nums[i] - nums[i - k];
                    double currentAverage = theSum / k;
                    maxAverage = Math.Max(maxAverage, currentAverage);
                }
                return maxAverage;
            }
        }
    }
}

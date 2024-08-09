using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Find All Numbers Disappeared in an Array
//Difficulty: Easy
//Given an array nums of n integers where nums[i] is in the range [1, n], return an array of all the integers in the range [1, n] that do not appear in nums.



//Example 1:

//Input: nums = [4,3,2,7,8,2,3,1]
//Output: [5,6]
//Example 2:

//Input: nums = [1,1]
//Output: [2]


//Constraints:

//n == nums.length
//1 <= n <= 105
//1 <= nums[i] <= n


//Follow up: Could you do it without extra space and in O(n) runtime? You may assume the returned list does not count as extra space.Given an array nums of n integers where nums[i] is in the range [1, n], return an array of all the integers in the range [1, n] that do not appear in nums.



//Example 1:

//Input: nums = [4,3,2,7,8,2,3,1]
//Output: [5,6]
//Example 2:

//Input: nums = [1,1]
//Output: [2]


//Constraints:

//n == nums.length
//1 <= n <= 105
//1 <= nums[i] <= n


//Follow up: Could you do it without extra space and in O(n) runtime? You may assume the returned list does not count as extra space.
namespace Find_All_Numbers_Disappeared_In_Array
{
    internal class Programs
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.ReadLine();
        }
        public class Solution
        {
            private int[] nums1 = new int[] { 4, 3, 2, 7, 8, 2, 3, 1 };
            private int[] nums2 = new int[] { 1, 1 };
            public Solution()
            {
                Console.WriteLine($"Nums: [4, 3, 2, 7, 8, 2, 3, 1]; Output: {FindDisappearedNumbers(nums1)}, Expected: [5,6]");
            }
            public IList<int> FindDisappearedNumbers(int[] nums)
            {
                List<int> list = new List<int>();
                HashSet<int> numsSet = new HashSet<int>(nums);

                for (int i = 1; i <= nums.Length; i++)
                {
                    if (!numsSet.Contains(i))
                    {
                        list.Add(i);
                    }
                }
                return list;
            }
        }
    }
}

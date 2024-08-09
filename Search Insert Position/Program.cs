using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Search Insert Position
//Difficulty: Easy
//Given a sorted array of distinct integers and a target value, return the index if the target is found. If not, return the index where it would be if it were inserted in order.

//You must write an algorithm with O(log n) runtime complexity.



//Example 1:

//Input: nums = [1, 3, 5, 6], target = 5
//Output: 2
//Example 2:

//Input: nums = [1, 3, 5, 6], target = 2
//Output: 1
//Example 3:

//Input: nums = [1, 3, 5, 6], target = 7
//Output: 4



//Constraints:

//1 <= nums.length <= 104
//- 104 <= nums[i] <= 104
//nums contains distinct values sorted in ascending order.
//-104 <= target <= 104
namespace Search_Insert_Position
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
            private int[] nums1 = new int[] { 1, 3, 5, 6 };
            private int target1 = 5, target2 = 2, target3 = 7;
            public Solution()
            {
                Console.WriteLine($"nums = [1, 3, 5, 6], target = {target1}; Output {SearchInsert(nums1, target1)}, Expected: 2");
                Console.WriteLine($"nums = [1, 3, 5, 6], target = {target2}; Output {SearchInsert(nums1, target2)}, Expected: 1");
                Console.WriteLine($"nums = [1, 3, 5, 6], target = {target3}; Output {SearchInsert(nums1, target3)}, Expected: 4");
            }
            public int SearchInsert(int[] nums, int target)
            {
                if (nums.Contains(target))
                {
                    for (int i = 0; i < nums.Length; i++)
                    {
                        if (nums[i] == target)
                        {
                            return i;
                        }
                    }
                }

                int indexOfTarget = 0;

                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[j] < target)
                    {
                        indexOfTarget++;
                    }
                    else break;
                }

                return indexOfTarget;
            }
        }
    }
}
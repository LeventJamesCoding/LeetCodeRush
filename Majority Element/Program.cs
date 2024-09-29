//Given an array nums of size n, return the majority element.

//The majority element is the element that appears more than ⌊n / 2⌋ times. You may assume that the majority element always exists in the array.

 

//Example 1:

//Input: nums = [3, 2, 3]
//Output: 3
//Example 2:

//Input: nums = [2, 2, 1, 1, 1, 2, 2]
//Output: 2



//Constraints:

//n == nums.length
//1 <= n <= 5 * 104
//- 109 <= nums[i] <= 109

namespace Majority_Element
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
            private int[] nums1 = new int[] { 3, 2, 3 }, nums2 = new int[] { 2, 2, 1, 1, 1, 2, 2 };
            public Solution()
            {
                Console.WriteLine($"Inputs: nums = {{ 3, 2, 3 }}; Output = {MajorityElement(nums1).ToString()}, Expected = 3");
                Console.WriteLine($"Inputs: nums = {{ 2, 2, 1, 1, 1, 2, 2 }}; Output = {MajorityElement(nums2).ToString()}, Expected = 2");
            }
            public int MajorityElement(int[] nums)
            {
                Dictionary<int, int> hashTable = new Dictionary<int, int>();

                for (int i = 0; i < nums.Length; i++)
                {
                    if (hashTable.ContainsKey(nums[i]))
                    {
                        hashTable[nums[i]]++;
                    }
                    else
                    {
                        hashTable.Add(nums[i], 1);
                    }
                }

                int maxValue = int.MinValue;
                int maxKey = 0;

                foreach (var entry in hashTable)
                {
                    if (entry.Value > maxValue)
                    {
                        maxValue = entry.Value;
                        maxKey = entry.Key;
                    }
                }

                return maxKey;
                //Complexity: O(n)
            }
        }
    }
}
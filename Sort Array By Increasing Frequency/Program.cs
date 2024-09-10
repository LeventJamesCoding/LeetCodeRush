using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Given an array of integers nums, sort the array in increasing order based on the frequency of the values. If multiple values have the same frequency, sort them in decreasing order.

//Return the sorted array.

 

//Example 1:

//Input: nums = [1, 1, 2, 2, 2, 3]
//Output: [3, 1, 1, 2, 2, 2]
//Explanation: '3' has a frequency of 1, '1' has a frequency of 2, and '2' has a frequency of 3.
//Example 2:

//Input: nums = [2, 3, 1, 3, 2]
//Output: [1, 3, 3, 2, 2]
//Explanation: '2' and '3' both have a frequency of 2, so they are sorted in decreasing order.
//Example 3:

//Input: nums = [-1, 1, -6, 4, 5, -6, 1, 4, 1]
//Output: [5, -1, 4, 4, -6, -6, 1, 1, 1]



//Constraints:

//1 <= nums.length <= 100
//- 100 <= nums[i] <= 100
namespace SortArrayByIncreasingFrequency
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
            private int[] nums1 = { 1, 1, 2, 2, 2, 3 }, nums2 = { 2, 3, 1, 3, 2 }, nums3 = { -1, 1, -6, 4, 5, -6, 1, 4, 1 };
            public Solution()
            {
                Console.WriteLine($"Inputs: nums = [1,1,2,2,2,3]; Output = {FrequencySort(nums1)}, Expected = [3,1,1,2,2,2]");
                Console.WriteLine($"Inputs: nums = [2,3,1,3,2]; Output = {FrequencySort(nums2)}, Expected = [1,3,3,2,2]");
                Console.WriteLine($"Inputs: nums = [-1,1,-6,4,5,-6,1,4,1]; Output = {FrequencySort(nums3)}, Expected = [5,-1,4,4,-6,-6,1,1,1]");
            }

            public int[] FrequencySort(int[] nums)
            {
                Dictionary<int, int> dictionary = new Dictionary<int, int>();
                //creating a map Values - Frequencies
                for (int i = 0; i < nums.Length; i++)
                {
                    int frequency = 0;
                    for (int j = i; j < nums.Length; j++)
                    {
                        if (nums[i] == nums[j])
                            frequency++;
                    }

                    if (!dictionary.ContainsKey(nums[i]))
                    {
                        dictionary.Add(nums[i], frequency);
                    }
                }

                List<int> result = new List<int>();
                //Sort the dictionary by correct order(sort frequencies first than key values by descending order)
                var sortedDictionary = dictionary.OrderBy(x => x.Value)
                    .ThenByDescending(x => x.Key)
                    .ToDictionary(kvp => kvp.Key, kvp => kvp.Value);


                foreach (var number in sortedDictionary)
                {
                    for (int i = 0; i < number.Value; i++)
                    {
                        result.Add(number.Key);
                    }
                }

                return result.ToArray();
            }
        }
    }
}

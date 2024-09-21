using System;
//There are n mountains in a row, and each mountain has a height. You are given an integer array height where height[i] represents the height of mountain i, and an integer threshold.

//A mountain is called stable if the mountain just before it (if it exists) has a height strictly greater than threshold. Note that mountain 0 is not stable.

//Return an array containing the indices of all stable mountains in any order.



//Example 1:

//Input: height = [1, 2, 3, 4, 5], threshold = 2

//Output: [3, 4]

//Explanation:

//Mountain 3 is stable because height[2] == 3 is greater than threshold == 2.
//Mountain 4 is stable because height[3] == 4 is greater than threshold == 2.
//Example 2:

//Input: height = [10, 1, 10, 1, 10], threshold = 3

//Output: [1, 3]

//Example 3:

//Input: height = [10, 1, 10, 1, 10], threshold = 10

//Output: []



//Constraints:

//2 <= n == height.length <= 100
//1 <= height[i] <= 100
//1 <= threshold <= 100
namespace Find_Indices_of_Stable_Mountains
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.ReadLine();
        }
        public class Solution
        {

            private int[] height1 = new int[] { 1, 2, 3, 4, 5 };
            private int[] height2 = new int[] { 10, 1, 10, 1, 10 };
            int threshold1 = 2, threshold2 = 3, threshold3 = 10;
            public Solution()
            {
                Console.WriteLine($"Inputs: height = [1,2,3,4,5], threshold = 2; Output = {StableMountains(height1, threshold1)}, Expected = [3,4]");
                Console.WriteLine($"Inputs: height = [10,1,10,1,10], threshold = 3; Output = {StableMountains(height2, threshold2)}, Expected = [1,3]");
                Console.WriteLine($"Inputs: height = [10,1,10,1,10], threshold = 10; Output = {StableMountains(height2, threshold3)}, Expected = []");
            }
            public IList<int> StableMountains(int[] height, int threshold)
            {
                List<int> result = new List<int>();
                for (int i = 1; i < height.Length; i++) // i = index of mountain
                {
                    if (height[i - 1] > threshold)
                    {
                        result.Add(i);
                    }
                }
                return result;
            }
        }
    }
}
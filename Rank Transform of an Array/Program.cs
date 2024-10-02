using System.Xml.Linq;

//Given an array of integers arr, replace each element with its rank.

//The rank represents how large the element is. The rank has the following rules:

//Rank is an integer starting from 1.
//The larger the element, the larger the rank. If two elements are equal, their rank must be the same.
//Rank should be as small as possible.


//Example 1:

//Input: arr = [40, 10, 20, 30]
//Output: [4, 1, 2, 3]
//Explanation: 40 is the largest element. 10 is the smallest. 20 is the second smallest. 30 is the third smallest.
//Example 2:

//Input: arr = [100, 100, 100]
//Output: [1, 1, 1]
//Explanation: Same elements share the same rank.
//Example 3:

//Input: arr = [37, 12, 28, 9, 100, 56, 80, 5, 12]
//Output: [5, 3, 4, 2, 8, 6, 7, 1, 3]



//Constraints:

//0 <= arr.length <= 105
//- 109 <= arr[i] <= 109
namespace Rank_Transform_of_an_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solt = new Solution();
            Console.ReadLine();
        }
        public class Solution
        {
            private int[] arr1 = new int[] { 40, 10, 20, 30 }, arr2 = new int[] { 100, 100, 100 }, arr3 = new int[] { 37, 12, 28, 9, 100, 56, 80, 5, 12 };
            public Solution()
            {
                Console.WriteLine($"Inputs: arr = [40,10,20,30]; Output = {ArrayRankTransform(arr1)}, Expected = [4,1,2,3]");
                Console.WriteLine($"Inputs: arr = [100,100,100]; Output = {ArrayRankTransform(arr1)}, Expected = [1,1,1]");
                Console.WriteLine($"Inputs: arr = [37,12,28,9,100,56,80,5,12]; Output = {ArrayRankTransform(arr1)}, Expected = [5,3,4,2,8,6,7,1,3]");
            }
            public int[] ArrayRankTransform(int[] arr)
            {
                List<int> list = new List<int>(arr);
                list.Sort();

                int theRank = 1;
                Dictionary<int, int> numberRankDictionary = new Dictionary<int, int>();

                for (int i = 0; i < list.Count; i++)
                {
                    if (!numberRankDictionary.ContainsKey(list[i]))
                    {
                        numberRankDictionary[list[i]] = theRank;
                        theRank++;
                    }
                }

                List<int> result = new List<int>();
                foreach (int value in arr)
                {
                    result.Add(numberRankDictionary[value]);
                }

                return result.ToArray();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

//Sort the People
//Difficulty: Easy
//You are given an array of strings names, and an array heights that consists of distinct positive integers. Both arrays are of length n.

//For each index i, names[i] and heights[i] denote the name and height of the ith person.

//Return names sorted in descending order by the people's heights.



//Example 1:

//Input: names = ["Mary", "John", "Emma"], heights = [180, 165, 170]
//Output: ["Mary", "Emma", "John"]
//Explanation: Mary is the tallest, followed by Emma and John.
//Example 2:

//Input: names = ["Alice", "Bob", "Bob"], heights = [155, 185, 150]
//Output: ["Bob", "Alice", "Bob"]
//Explanation: The first Bob is the tallest, followed by Alice and the second Bob.


//Constraints:

//n == names.length == heights.length
//1 <= n <= 103
//1 <= names[i].length <= 20
//1 <= heights[i] <= 105
//names[i] consists of lower and upper case English letters.
//All the values of heights are distinct.


namespace Sort_the_People
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
            private string[] names1 = new string[] { "Mary", "John", "Emma" };
            private string[] names2 = new string[] { "Alice", "Bob", "Bob" };
            private int[] heights1 = new int[] { 180, 165, 170 };
            private int[] heights2 = new int[] { 155, 185, 150 };
            public Solution()
            {
                Console.WriteLine($"Inputs: names = [\"Mary\",\"John\",\"Emma\"], heights = {ArrayToString(heights1)}; Output: {SortPeople(names1, heights1)}, Expected: [\"Mary\",\"Emma\",\"John\"]");
                Console.WriteLine($"Inputs: names = [\"Alice\",\"Bob\",\"Bob\"], heights = {ArrayToString(heights2)}; Output: {SortPeople(names2, heights2)}, Expected: [\"Bob\",\"Alice\",\"Bob\"]");
            }
            public string[] SortPeople(string[] names, int[] heights)
            {
                Array.Sort(heights, names);
                var name = names.ToList();
                name.Reverse();
                return name.ToArray();
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
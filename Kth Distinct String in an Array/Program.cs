using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Kth Distinct String in an Array
//Difficulty: Easy
//A distinct string is a string that is present only once in an array.

//Given an array of strings arr, and an integer k, return the kth distinct string present in arr. If there are fewer than k distinct strings, return an empty string "".

//Note that the strings are considered in the order in which they appear in the array.

 

//Example 1:

//Input: arr = ["d", "b", "c", "b", "c", "a"], k = 2
//Output: "a"
//Explanation:
//The only distinct strings in arr are "d" and "a".
//"d" appears 1st, so it is the 1st distinct string.
//"a" appears 2nd, so it is the 2nd distinct string.
//Since k == 2, "a" is returned. 
//Example 2:

//Input: arr = ["aaa", "aa", "a"], k = 1
//Output: "aaa"
//Explanation:
//All strings in arr are distinct, so the 1st string "aaa" is returned.
//Example 3:

//Input: arr = ["a", "b", "a"], k = 3
//Output: ""
//Explanation:
//The only distinct string is "b". Since there are fewer than 3 distinct strings, we return an empty string "".
 

//Constraints:

//1 <= k <= arr.length <= 1000
//1 <= arr[i].length <= 5
//arr[i] consists of lowercase English letters.
namespace Kth_Distinct_String_in_an_Array
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
            private string[] arr1 = { "d", "b", "c", "b", "c", "a" };
            private string[] arr2 = { "aaa", "aa", "a" };
            private string[] arr3 = { "a", "b", "a" };
            int k1 = 2, k2 = 1, k3 = 3;
            public Solution()
            {
                Console.WriteLine($"Inputs: arr = [\"d\",\"b\",\"c\",\"b\",\"c\",\"a\"], k = 2; Output = \"{KthDistinct(arr1, k1)}\", Expected = \"a\"");
                Console.WriteLine($"Inputs: arr = [\"aaa\",\"aa\",\"a\"], k = 1; Output = {KthDistinct(arr2, k2)}, Expected = \"aaa\"");
                Console.WriteLine($"Inputs: arr = [\"a\",\"b\",\"a\"], k = 3; Output = {KthDistinct(arr3, k3)}, Expected = \"\"");
            }
            public string KthDistinct(string[] arr, int k)
            {
                List<string> list = new List<string>();

                for (int i = 0; i < arr.Length; i++)
                {
                    int frequency = 0;
                    for (int j = 0; j < arr.Length; j++)
                    {
                        if (arr[i] == arr[j])
                            frequency++;
                    }
                    if (frequency == 1)
                    {
                        list.Add(arr[i]);
                    }
                }
                if (k > list.Count)
                    return "";

                return list[k - 1];
            }
        }
    }
}
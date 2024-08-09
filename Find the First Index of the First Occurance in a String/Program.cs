using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
//Find the Index of the First Occurrence in a String
//Difficulty: Easy
//Given two strings needle and haystack, return the index of the first occurrence of needle in haystack, or -1 if needle is not part of haystack.



//Example 1:

//Input: haystack = "sadbutsad", needle = "sad"
//Output: 0
//Explanation: "sad" occurs at index 0 and 6.
//The first occurrence is at index 0, so we return 0.
//Example 2:

//Input: haystack = "leetcode", needle = "leeto"
//Output: -1
//Explanation: "leeto" did not occur in "leetcode", so we return -1.


//Constraints:

//1 <= haystack.length, needle.length <= 104
//haystack and needle consist of only lowercase English characters.
namespace Find_the_First_Index_of_the_First_Occurance_in_a_String
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
            private string haystack1 = "sadbutsad", needle1 = "sad";
            private string haystack2 = "leetcode", needle2 = "leeto";
            public Solution()
            {
                Console.WriteLine($"Inputs = haystack: sadbutsad, needle: sad; Output {StrStr(haystack1, needle1)}, Expected: 0");
                Console.WriteLine($"Inputs = haystack: sadbutsad, needle: sad; Output {StrStr(haystack2, needle2)}, Expected: -1");
            }
            public int StrStr(string haystack, string needle)
            {
                return haystack.IndexOf(needle);
            }
        }
    }
}
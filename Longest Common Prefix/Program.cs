using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Longest Common Prefix
//Difficulty: Easy
//Write a function to find the longest common prefix string amongst an array of strings.

//If there is no common prefix, return an empty string "".



//Example 1:

//Input: strs = ["flower", "flow", "flight"]
//Output: "fl"
//Example 2:

//Input: strs = ["dog", "racecar", "car"]
//Output: ""
//Explanation: There is no common prefix among the input strings.


//Constraints:

//1 <= strs.length <= 200
//0 <= strs[i].length <= 200
//strs[i] consists of only lowercase English letters.
namespace Longest_Common_Prefix
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
            private string[] input1 = new string[] { "flower", "flow", "flight" };
            private string[] input2 = new string[] { "dog", "racecar", "car" };
            public Solution()
            {
                Console.WriteLine($"Input is: \"flower\", \"flow\", \"flight\", Output: {LongestCommonPrefix(input1)} Expected: fl");
                Console.WriteLine($"Input is: \"dog\", \"racecar\", \"car\", Output: {LongestCommonPrefix(input2)} Expected: ");
            }
            public string LongestCommonPrefix(string[] strs)
            {
                string prefix = strs[0];
                string _prefix = "";

                for (int i = 1; i < strs.Length; i++)
                {
                    int j = 0;
                    while (j < strs[i].Length && j < prefix.Length && strs[i][j] == prefix[j])
                    {
                        _prefix = _prefix + strs[i][j];
                        j++;
                    }
                    prefix = _prefix;
                    _prefix = "";
                }
                return prefix;
            }
        }
    }
}
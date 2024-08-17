using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
//Valid Parantheses
//Difficulty: Easy
//Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

//An input string is valid if:

//Open brackets must be closed by the same type of brackets.
//Open brackets must be closed in the correct order.
//Every close bracket has a corresponding open bracket of the same type.
 

//Example 1:

//Input: s = "()"
//Output: true
//Example 2:

//Input: s = "()[]{}"
//Output: true
//Example 3:

//Input: s = "(]"
//Output: false



//Constraints:

//1 <= s.length <= 104
//s consists of parentheses only '()[]{}'.
namespace ValidParentheses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.Read();
        }
        public class Solution
        {
            private string s1 = "()", s2 = "()[]{}", s3 = "(]";
            public Solution()
            {
                Console.WriteLine($"Inputs: s = \"()\"; Output = {IsValid(s1)}, Expected = True");
                Console.WriteLine($"Inputs: s = \"()[]{{}}\"; Output = {IsValid(s2)}, Expected = True");
                Console.WriteLine($"Inputs: s = \"(]\"; Output = {IsValid(s3)}, Expected = False");
            }
            public bool IsValid(string s)
            {
                while (s.Contains("()") || s.Contains("[]") || s.Contains("{}"))
                {
                    s = s.Replace("()", "").Replace("[]", "").Replace("{}", "");
                }

                return s.Length == 0;
            }
        }
    }
}

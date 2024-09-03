using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Sum of Digits of String After Convert
//Difficulty: Easy
//You are given a string s consisting of lowercase English letters, and an integer k.

//First, convert s into an integer by replacing each letter with its position in the alphabet (i.e., replace 'a' with 1, 'b' with 2, ..., 'z' with 26). Then, transform the integer by replacing it with the sum of its digits. Repeat the transform operation k times in total.

//For example, if s = "zbax" and k = 2, then the resulting integer would be 8 by the following operations:

//Convert: "zbax" ➝ "(26)(2)(1)(24)" ➝ "262124" ➝ 262124
//Transform #1: 262124 ➝ 2 + 6 + 2 + 1 + 2 + 4 ➝ 17
//Transform #2: 17 ➝ 1 + 7 ➝ 8
//Return the resulting integer after performing the operations described above.

 

//Example 1:

//Input: s = "iiii", k = 1
//Output: 36
//Explanation: The operations are as follows:
//-Convert: "iiii" ➝ "(9)(9)(9)(9)" ➝ "9999" ➝ 9999
//- Transform #1: 9999 ➝ 9 + 9 + 9 + 9 ➝ 36
//Thus the resulting integer is 36.
//Example 2:

//Input: s = "leetcode", k = 2
//Output: 6
//Explanation: The operations are as follows:
//-Convert: "leetcode" ➝ "(12)(5)(5)(20)(3)(15)(4)(5)" ➝ "12552031545" ➝ 12552031545
//- Transform #1: 12552031545 ➝ 1 + 2 + 5 + 5 + 2 + 0 + 3 + 1 + 5 + 4 + 5 ➝ 33
//- Transform #2: 33 ➝ 3 + 3 ➝ 6
//Thus the resulting integer is 6.
//Example 3:

//Input: s = "zbax", k = 2
//Output: 8



//Constraints:

//1 <= s.length <= 100
//1 <= k <= 10
//s consists of lowercase English letters.
namespace Sum_of_Digits_of_String_After_Convert
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
            private string s1 = "iiii", s2 = "leetcode", s3 = "zbax";
            private int k1 = 1, k2 = 2, k3 = 2;
            public Solution()
            {
                Console.WriteLine($"Inputs: s = {s1}, k = {k1}; Output = {GetLucky(s1, k1)}, Expected = 36");
                Console.WriteLine($"Inputs: s = {s2}, k = {k2}; Output = {GetLucky(s2, k2)}, Expected = 6");
                Console.WriteLine($"Inputs: s = {s3}, k = {k3}; Output = {GetLucky(s3, k3)}, Expected = 8");
            }
            public int GetLucky(string s, int k)
            {
                string theNumberVer = "";

                for (int i = 0; i < s.Length; i++)
                {
                    theNumberVer += Convert.ToInt16(s[i]) - 96;
                }

                int sumOfDigits = 0;
                for (int i = 0; i < k; i++)
                {
                    for (int j = 0; j < theNumberVer.Length; j++)
                    {
                        sumOfDigits += int.Parse(theNumberVer[j].ToString());
                    }
                    theNumberVer = sumOfDigits.ToString();
                    sumOfDigits = 0;
                }
                return Convert.ToInt16(theNumberVer);
            }
        }
    }
}


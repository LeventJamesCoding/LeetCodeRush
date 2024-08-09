using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Length of Last Word
//Difficulty: Easy
//Given a string s consisting of words and spaces, return the length of the last word in the string.

//A word is a maximal 
//substring
// consisting of non-space characters only.

 

//Example 1:

//Input: s = "Hello World"
//Output: 5
//Explanation: The last word is "World" with length 5.
//Example 2:

//Input: s = "   fly me   to   the moon  "
//Output: 4
//Explanation: The last word is "moon" with length 4.
//Example 3:

//Input: s = "luffy is still joyboy"
//Output: 6
//Explanation: The last word is "joyboy" with length 6.
 

//Constraints:

//1 <= s.length <= 104
//s consists of only English letters and spaces ' '.
//There will be at least one word in s.
namespace Length_of_Last_Word
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
            private string s1 = "Hello World";
            private string s2 = "   fly me   to   the moon  ";
            private string s3 = "luffy is still joyboy";
            public Solution()
            {
                Console.WriteLine($"s = {s1}; Output = {LengthOfLastWord(s1)}, Expected = 5");
                Console.WriteLine($"s = {s2}; Output = {LengthOfLastWord(s2)}, Expected = 4");
                Console.WriteLine($"s = {s3}; Output = {LengthOfLastWord(s3)}, Expected = 6");
            }
            public int LengthOfLastWord(string s)
            {
                int counter = 0;
                int i;
                for (i = s.Length - 1; i >= 0; i--)
                {
                    if (s[i] != ' ')
                    {
                        break;
                    }
                }

                for (int j = i; j >= 0; j--)
                {
                    if (s[j] != ' ')
                    {
                        counter++;
                    }
                    else break;
                }
                return counter;
            }
        }
    }
}
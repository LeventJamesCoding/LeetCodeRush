//You are given a string allowed consisting of distinct characters and an array of strings words. A string is consistent if all characters in the string appear in the string allowed.

//Return the number of consistent strings in the array words.



//Example 1:

//Input: allowed = "ab", words = ["ad", "bd", "aaab", "baa", "badab"]
//Output: 2
//Explanation: Strings "aaab" and "baa" are consistent since they only contain characters 'a' and 'b'.
//Example 2:

//Input: allowed = "abc", words = ["a", "b", "c", "ab", "ac", "bc", "abc"]
//Output: 7
//Explanation: All strings are consistent.
//Example 3:

//Input: allowed = "cad", words = ["cc", "acd", "b", "ba", "bac", "bad", "ac", "d"]
//Output: 4
//Explanation: Strings "cc", "acd", "ac", and "d" are consistent.


//Constraints:

//1 <= words.length <= 104
//1 <= allowed.length <= 26
//1 <= words[i].length <= 10
//The characters in allowed are distinct.
//words[i] and allowed contain only lowercase English letters.
namespace Count_The_Number_Of_Consistent_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.ReadLine();
        }
    }
    public class Solution
    {
        private string allowed1 = "ab", allowed2 = "abc", allowed3 = "cad";
        private string[] words1 = { "ad", "bd", "aaab", "baa", "badab" },
            words2 = { "a", "b", "c", "ab", "ac", "bc", "abc" },
            words3 = { "cc", "acd", "b", "ba", "bac", "bad", "ac", "d" };
        public Solution()
        {
            Console.WriteLine($"Inputs: allowed = {allowed1}, words = [\"ad\",\"bd\",\"aaab\",\"baa\",\"badab\"]" +
                $"; Output = {CountConsistentStrings(allowed1, words1)}, Expected = 2");
            Console.WriteLine($"Inputs: allowed = {allowed2}, words = [\"a\",\"b\",\"c\",\"ab\",\"ac\",\"bc\",\"abc\"   ]" +
                $"; Output = {CountConsistentStrings(allowed2, words2)}, Expected = 7");
            Console.WriteLine($"Inputs: allowed = {allowed3}, words = [\"cc\",\"acd\",\"b\",\"ba\",\"bac\",\"bad\",\"ac\",\"d\"]" +
                $"; Output = {CountConsistentStrings(allowed3, words3)}, Expected = 4");
        }
        public int CountConsistentStrings(string allowed, string[] words)
        {
            int counter = words.Length;
            List<char> allowedChars = new List<char>();

            for (int i = 0; i < allowed.Length; i++)
            {
                allowedChars.Add(allowed[i]);
            }

            foreach (string word in words)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    if (!allowedChars.Contains(word[i]))
                    {
                        counter--;
                        break;
                    }
                }
            }
            return counter;
        }
    }
}

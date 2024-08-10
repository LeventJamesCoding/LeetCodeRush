using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Minimum Number of Pushes to Type Word I
//Difficulty: Easy
//You are given a string word containing distinct lowercase English letters.

//Telephone keypads have keys mapped with distinct collections of lowercase English letters, which can be used to form words by pushing them. For example, the key 2 is mapped with ["a","b","c"], we need to push the key one time to type "a", two times to type "b", and three times to type "c" .

//It is allowed to remap the keys numbered 2 to 9 to distinct collections of letters. The keys can be remapped to any amount of letters, but each letter must be mapped to exactly one key. You need to find the minimum number of times the keys will be pushed to type the string word.

//Return the minimum number of pushes needed to type word after remapping the keys.

//An example mapping of letters to keys on a telephone keypad is given below. Note that 1, *, #, and 0 do not map to any letters.




//Example 1:


//Input: word = "abcde"
//Output: 5
//Explanation: The remapped keypad given in the image provides the minimum cost.
//"a" -> one push on key 2
//"b" -> one push on key 3
//"c" -> one push on key 4
//"d" -> one push on key 5
//"e" -> one push on key 6
//Total cost is 1 + 1 + 1 + 1 + 1 = 5.
//It can be shown that no other mapping can provide a lower cost.
//Example 2:


//Input: word = "xycdefghij"
//Output: 12
//Explanation: The remapped keypad given in the image provides the minimum cost.
//"x" -> one push on key 2
//"y" -> two pushes on key 2
//"c" -> one push on key 3
//"d" -> two pushes on key 3
//"e" -> one push on key 4
//"f" -> one push on key 5
//"g" -> one push on key 6
//"h" -> one push on key 7
//"i" -> one push on key 8
//"j" -> one push on key 9
//Total cost is 1 + 2 + 1 + 2 + 1 + 1 + 1 + 1 + 1 + 1 = 12.
//It can be shown that no other mapping can provide a lower cost.


//Constraints:

//1 <= word.length <= 26
//word consists of lowercase English letters.
//All letters in word are distinct.You are given a string word containing distinct lowercase English letters.

//Telephone keypads have keys mapped with distinct collections of lowercase English letters, which can be used to form words by pushing them. For example, the key 2 is mapped with ["a","b","c"], we need to push the key one time to type "a", two times to type "b", and three times to type "c" .

//It is allowed to remap the keys numbered 2 to 9 to distinct collections of letters. The keys can be remapped to any amount of letters, but each letter must be mapped to exactly one key. You need to find the minimum number of times the keys will be pushed to type the string word.

//Return the minimum number of pushes needed to type word after remapping the keys.

//An example mapping of letters to keys on a telephone keypad is given below. Note that 1, *, #, and 0 do not map to any letters.




//Example 1:


//Input: word = "abcde"
//Output: 5
//Explanation: The remapped keypad given in the image provides the minimum cost.
//"a" -> one push on key 2
//"b" -> one push on key 3
//"c" -> one push on key 4
//"d" -> one push on key 5
//"e" -> one push on key 6
//Total cost is 1 + 1 + 1 + 1 + 1 = 5.
//It can be shown that no other mapping can provide a lower cost.
//Example 2:


//Input: word = "xycdefghij"
//Output: 12
//Explanation: The remapped keypad given in the image provides the minimum cost.
//"x" -> one push on key 2
//"y" -> two pushes on key 2
//"c" -> one push on key 3
//"d" -> two pushes on key 3
//"e" -> one push on key 4
//"f" -> one push on key 5
//"g" -> one push on key 6
//"h" -> one push on key 7
//"i" -> one push on key 8
//"j" -> one push on key 9
//Total cost is 1 + 2 + 1 + 2 + 1 + 1 + 1 + 1 + 1 + 1 = 12.
//It can be shown that no other mapping can provide a lower cost.


//Constraints:

//1 <= word.length <= 26
//word consists of lowercase English letters.
//All letters in word are distinct.
namespace Minimum_Number_of_Pushes_to_Type_Word_II
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
            private string word1 = "abcde";
            private string word2 = "xycdefghij";
            public Solution()
            {
                Console.WriteLine($"Input: word = {word1}; Output = {MinimumPushes(word1)}, Expected = 5");
                Console.WriteLine($"Input: word = {word2}; Output = {MinimumPushes(word2)}, Expected = 12");
            }
            public int MinimumPushes(string word)
            {
                Dictionary<char, int> map = new Dictionary<char, int>();
                int tvalues = 1;
                int minimumPushes = 0;

                for (int j = 0; j < word.Length; j++)
                {
                    if (!map.ContainsKey(word[j]))
                    {
                        map.Add(word[j], tvalues);
                    }
                    if (map.Count % 8 == 0)
                    {
                        tvalues++;
                    }
                }

                for (int i = 0; i < word.Length; i++)
                {
                    minimumPushes += map[word[i]];
                }
                return minimumPushes;
            }
        }
    }
}

//A sentence is a string of single-space separated words where each word consists only of lowercase letters.

//A word is uncommon if it appears exactly once in one of the sentences, and does not appear in the other sentence.

//Given two sentences s1 and s2, return a list of all the uncommon words. You may return the answer in any order.



//Example 1:

//Input: s1 = "this apple is sweet", s2 = "this apple is sour"

//Output: ["sweet", "sour"]

//Explanation:

//The word "sweet" appears only in s1, while the word "sour" appears only in s2.

//Example 2:

//Input: s1 = "apple apple", s2 = "banana"

//Output: ["banana"]




//Constraints:

//1 <= s1.length, s2.length <= 200
//s1 and s2 consist of lowercase English letters and spaces.
//s1 and s2 do not have leading or trailing spaces.
//All the words in s1 and s2 are separated by a single space.
namespace Uncommon_Words_From_Two_Sentences
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
        private string s1 = "this apple is sweet", s2 = "this apple is sour";
        public Solution()
        {
            Console.WriteLine($"Inputs: s1 = {s1}, s2 = {s2}; Output = {UncommonFromSentences(s1, s2)}, Expected = \"sweet\",\"sour\"");
        }

        public string[] UncommonFromSentences(string s1, string s2)
        {
            List<string> listOfWordsInFirst = s1.Split(' ').ToList();
            List<string> listOfWordsInSecond = s2.Split(' ').ToList();
            List<string> allWords = listOfWordsInFirst.Concat(listOfWordsInSecond).ToList();
            Dictionary<string, int> wordFrequencyMap = new Dictionary<string, int>();

            //creating HashMap Word-Frequency
            foreach (string word in allWords)
            {
                if (!wordFrequencyMap.ContainsKey(word))
                {
                    wordFrequencyMap.Add(word, 1);
                }
                else
                {
                    wordFrequencyMap[word]++;
                }
            }

            List<string> result = wordFrequencyMap.Where(wfv => wfv.Value == 1).Select(kvp => kvp.Key).ToList();
            return result.ToArray();
        }
    }
}

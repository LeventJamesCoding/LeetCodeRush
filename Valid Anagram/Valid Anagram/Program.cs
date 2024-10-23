namespace Valid_Anagram
{
    public class Solution
    {
        public bool IsAnagram(string s, string t)
        {
            //map of char-frequency string s
            Dictionary<char,int> charFrequencyMapS = new Dictionary<char,int>();
            foreach (char c in s)
            {
                if(!charFrequencyMapS.ContainsKey(c))
                {
                    charFrequencyMapS.Add(c, 1);
                }
                else
                {
                    charFrequencyMapS[c]++;
                }
            }
            //map of char-frequency string t
            Dictionary<char, int> charFrequencyMapT = new Dictionary<char, int>();
            foreach (char c in t)
            {
                if (!charFrequencyMapT.ContainsKey(c))
                {
                    charFrequencyMapT.Add(c, 1);
                }
                else
                {
                    charFrequencyMapT[c]++;
                }
            }

            return charFrequencyMapT.Count == charFrequencyMapS.Count && charFrequencyMapT
                .OrderBy(kvp => kvp.Key).SequenceEqual(charFrequencyMapS.OrderBy(kvp => kvp.Key));
        }
    }
}

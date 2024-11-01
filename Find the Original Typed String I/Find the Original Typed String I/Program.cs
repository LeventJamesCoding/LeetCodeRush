namespace Find_the_Original_Typed_String_I
{
    public class Solution
    {
        public int PossibleStringCount(string word)
        {
            int result = 0;
            int count = 1;
            char previous = word[0];

            for (int i = 1; i < word.Length; i++)
            {   
                if(previous != word[i]) 
                {
                    if(count > 1)
                    {
                        result += count - 1;
                    }
                    count = 1;
                }
                else 
                {
                    count++;
                }
                previous = word[i];
            }

            if(count > 1)
            {
                result += count - 1;
            }

            return result + 1;
        }
    }
}
using System.Text;
namespace Delete_Characters_to_Make_Fancy_String
{
    public class Solution
    {
        public string MakeFancyString(string s)
        {
            var result = new StringBuilder();
            int counter = 1;  
            char previous = s[0];
            result.Append(previous);

            for (int i = 1; i < s.Length; i++)
            {
                if (s[i] == previous)
                {
                    if (counter < 2)  
                    {
                        result.Append(s[i]);
                    }
                    counter++;
                }
                else
                {
                    previous = s[i];
                    result.Append(s[i]);
                    counter = 1;
                }
            }

            return result.ToString();
        }
    }

}

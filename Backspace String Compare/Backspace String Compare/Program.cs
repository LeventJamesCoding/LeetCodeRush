namespace Backspace_String_Compare
{
    internal class Program
    {
        public class Solution
        {
            public bool BackspaceCompare(string s, string t)
            {
                string concreteS = "", concreteT = "";

                foreach(char c in s)
                {
                    if(c != '#')
                    {
                        concreteS += c;
                    }
                    else if(concreteS != "" && c == '#')
                    {
                        //concreteS' in son elemanın sil
                        concreteS = concreteS.Remove(concreteS.Length - 1);
                    }
                }

                foreach (char c in t)
                {
                    if (c != '#')
                    {
                        concreteT += c;
                    }
                    else if (concreteT != "" && c == '#')
                    {
                        //concreteT' nin son elemanın sil
                        concreteT = concreteT.Remove(concreteT.Length - 1);
                    }
                }

                return concreteS.Equals(concreteT);
            }
        }
    }
}

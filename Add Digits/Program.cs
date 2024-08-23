using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Add Digits
//Difficulty: Easy
//Given an integer num, repeatedly add all its digits until the result has only one digit, and return it.

 

//Example 1:

//Input: num = 38
//Output: 2
//Explanation: The process is
//38-- > 3 + 8-- > 11
//11-- > 1 + 1-- > 2
//Since 2 has only one digit, return it.
//Example 2:

//Input: num = 0
//Output: 0



//Constraints:

//0 <= num <= 231 - 1
namespace Add_Digits
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
        private int num1 = 38, num2 = 0;
        public Solution()
        {
            Console.WriteLine($"Inputs: num = {num1}; Output = {AddDigits(num1)}, Expected = 2");
            Console.WriteLine($"Inputs: num = {num2}; Output = {AddDigits(num2)}, Expected = 0");
        }
        public int AddDigits(int num)
        {
            string strnum = num.ToString();
            int theSum = 10;

            while (theSum.ToString().Length > 1)
            {
                theSum = 0;
                for (int i = 0; i < strnum.Length; i++)
                {
                    theSum += int.Parse(strnum[i].ToString());
                }
                strnum = theSum.ToString();
            }
            return theSum;
        }
    }
}

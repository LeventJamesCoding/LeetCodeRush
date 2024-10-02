using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Given two binary strings a and b, return their sum as a binary string.



//Example 1:

//Input: a = "11", b = "1"
//Output: "100"
//Example 2:

//Input: a = "1010", b = "1011"
//Output: "10101"



//Constraints:

//1 <= a.length, b.length <= 104
//a and b consist only of '0' or '1' characters.
//Each string does not contain leading zeros except for the zero itself.
namespace AddBinary
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
            private string input1 = "11";
            private string input2 = "1";

            private string input3 = "1010";
            private string input4 = "1011";
            public Solution()
            {
                Console.WriteLine($"Inputs are: {input1}, {input2} -----> Output is: {AddBinary(input1, input2)}, Expected: 100");
                Console.WriteLine($"Inputs are: {input3}, {input4} -----> Output is: {AddBinary(input3, input4)}, Expected: 10101");
            }
            public string AddBinary(string a, string b)
            {
                int carry = 0;
                List<int> digitList = new List<int>();

                if (a.Length > b.Length)
                {
                    for (int i = 0; i < a.Length - b.Length; i++)
                    {
                        b = "0" + b;
                    }
                }
                else
                {
                    for (int i = 0; i < b.Length - a.Length; i++)
                    {
                        a = "0" + a;
                    }
                }

                for (int i = a.Length - 1; i >= 0; i--)
                {
                    int bitA = a[i] - '0';
                    int bitB = b[i] - '0';

                    int digitResult = (bitA + bitB + carry) % 2;
                    digitList.Add(digitResult);

                    carry = (bitA + bitB + carry) / 2;
                }

                if (carry == 1)
                {
                    digitList.Add(carry);
                }

                digitList.Reverse();
                string result = "";

                foreach (int digit in digitList)
                {
                    result += digit.ToString();
                }

                return result;
            }
        }
    }
}

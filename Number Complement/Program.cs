using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Number Complement
//Difficulty: Easy
//The complement of an integer is the integer you get when you flip all the 0's to 1's and all the 1's to 0's in its binary representation.

//For example, The integer 5 is "101" in binary and its complement is "010" which is the integer 2.
//Given an integer num, return its complement.

 

//Example 1:

//Input: num = 5
//Output: 2
//Explanation: The binary representation of 5 is 101 (no leading zero bits), and its complement is 010. So you need to output 2.
//Example 2:

//Input: num = 1
//Output: 0
//Explanation: The binary representation of 1 is 1 (no leading zero bits), and its complement is 0. So you need to output 0.
 

//Constraints:

//1 <= num < 231
namespace Number_Complement
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
            private int num1 = 5, num2 = 1;
            public Solution()
            {
                Console.WriteLine($"Input: num = {num1}; Output = {FindComplement(num1)}, Expected = 2");
                Console.WriteLine($"Input: num = {num2}; Output = {FindComplement(num2)}, Expected = 0");
            }
            public int FindComplement(int num)
            {
                //Convert the parameter num into binary number
                string binaryNum = Convert.ToString(num, 2);

                //Taking complement of the binaryNum
                List<char> complementBinaryNum = new List<char>();
                for (int i = 0; i < binaryNum.Length; i++)
                {
                    if (binaryNum[i] == '0')
                        complementBinaryNum.Add('1');
                    else if (binaryNum[i] == '1')
                        complementBinaryNum.Add('0');
                }
                string complementOfBinaryNum = new string(complementBinaryNum.ToArray());

                //Convert the complementOfBinaryNum to decimal number
                int decimalNum = Convert.ToInt32(complementOfBinaryNum, 2);
                return decimalNum;
            }
        }
    }
}

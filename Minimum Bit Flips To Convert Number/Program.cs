//A bit flip of a number x is choosing a bit in the binary representation of x and flipping it from either 0 to 1 or 1 to 0.

//For example, for x = 7, the binary representation is 111 and we may choose any bit (including any leading zeros not shown) and flip it. We can flip the first bit from the right to get 110, flip the second bit from the right to get 101, flip the fifth bit from the right (a leading zero) to get 10111, etc.
//Given two integers start and goal, return the minimum number of bit flips to convert start to goal.



//Example 1:

//Input: start = 10, goal = 7
//Output: 3
//Explanation: The binary representation of 10 and 7 are 1010 and 0111 respectively. We can convert 10 to 7 in 3 steps:
//-Flip the first bit from the right: 1010-> 1011.
//- Flip the third bit from the right: 1011-> 1111.
//- Flip the fourth bit from the right: 1111-> 0111.
//It can be shown we cannot convert 10 to 7 in less than 3 steps. Hence, we return 3.
//Example 2:

//Input: start = 3, goal = 4
//Output: 3
//Explanation: The binary representation of 3 and 4 are 011 and 100 respectively. We can convert 3 to 4 in 3 steps:
//-Flip the first bit from the right: 011-> 010.
//- Flip the second bit from the right: 010-> 000.
//- Flip the third bit from the right: 000-> 100.
//It can be shown we cannot convert 3 to 4 in less than 3 steps. Hence, we return 3.


//Constraints:

//0 <= start, goal <= 109
namespace Minimum_Bit_Flips_To_Convert_Number
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
            private int start1 = 10, start2 = 3, goal1 = 7, goal2 = 4;
            public Solution()
            {
                Console.WriteLine($"Inputs: start = {start1}, goal = {goal1}; " +
                    $"Output = {MinBitFlips(start1, goal1)}, Expected = 3");

                Console.WriteLine($"Inputs: start = {start2}, goal = {goal2}; " +
                    $"Output = {MinBitFlips(start2, goal2)}, Expected = 3");
            }
            public int MinBitFlips(int start, int goal)
            {
                int result = 0;
                string binaryOfStart = Convert.ToString(start, 2);
                string binaryOfGoal = Convert.ToString(goal, 2);
                EqualizeLength(ref binaryOfStart, ref binaryOfGoal);

                for (int i = 0; i < binaryOfStart.Length; i++)
                {
                    if (binaryOfStart[i] != binaryOfGoal[i])
                    {
                        result++;
                    }
                }
                return result;
            }
            public void EqualizeLength(ref string binary1, ref string binary2)
            {
                int lengthDiff = Math.Abs(binary1.Length - binary2.Length);
                if (binary1.Length > binary2.Length)
                {
                    for (int i = 0; i < lengthDiff; i++)
                    {
                        binary2 = "0" + binary2;
                    }
                }
                else
                {
                    for (int i = 0; i < lengthDiff; i++)
                    {
                        binary1 = "0" + binary1;
                    }
                }
            }
        }
    }
}


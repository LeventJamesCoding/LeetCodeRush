using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Defuse The Bomb
//Difficulty: Easy
//You have a bomb to defuse, and your time is running out! Your informer will provide you with a circular array code of length of n and a key k.

//To decrypt the code, you must replace every number. All the numbers are replaced simultaneously.

//If k > 0, replace the ith number with the sum of the next k numbers.
//If k < 0, replace the ith number with the sum of the previous k numbers.
//If k == 0, replace the ith number with 0.
//As code is circular, the next element of code[n-1] is code[0], and the previous element of code[0] is code[n-1].

//Given the circular array code and an integer key k, return the decrypted code to defuse the bomb!

 

//Example 1:

//Input: code = [5,7,1,4], k = 3
//Output: [12,10,16,13]
//Explanation: Each number is replaced by the sum of the next 3 numbers. The decrypted code is [7+1+4, 1+4+5, 4+5+7, 5+7+1]. Notice that the numbers wrap around.
//Example 2:

//Input: code = [1,2,3,4], k = 0
//Output: [0,0,0,0]
//Explanation: When k is zero, the numbers are replaced by 0. 
//Example 3:

//Input: code = [2,4,9,3], k = -2
//Output: [12,5,6,13]
//Explanation: The decrypted code is [3+9, 2+3, 4+2, 9+4]. Notice that the numbers wrap around again. If k is negative, the sum is of the previous numbers.
 

//Constraints:

//n == code.length
//1 <= n <= 100
//1 <= code[i] <= 100
//-(n - 1) <= k <= n - 1You have a bomb to defuse, and your time is running out! Your informer will provide you with a circular array code of length of n and a key k.

//To decrypt the code, you must replace every number. All the numbers are replaced simultaneously.

//If k > 0, replace the ith number with the sum of the next k numbers.
//If k < 0, replace the ith number with the sum of the previous k numbers.
//If k == 0, replace the ith number with 0.
//As code is circular, the next element of code[n-1] is code[0], and the previous element of code[0] is code[n-1].

//Given the circular array code and an integer key k, return the decrypted code to defuse the bomb!

 

//Example 1:

//Input: code = [5,7,1,4], k = 3
//Output: [12,10,16,13]
//Explanation: Each number is replaced by the sum of the next 3 numbers. The decrypted code is [7+1+4, 1+4+5, 4+5+7, 5+7+1]. Notice that the numbers wrap around.
//Example 2:

//Input: code = [1,2,3,4], k = 0
//Output: [0,0,0,0]
//Explanation: When k is zero, the numbers are replaced by 0. 
//Example 3:

//Input: code = [2,4,9,3], k = -2
//Output: [12,5,6,13]
//Explanation: The decrypted code is [3+9, 2+3, 4+2, 9+4]. Notice that the numbers wrap around again. If k is negative, the sum is of the previous numbers.
 

//Constraints:

//n == code.length
//1 <= n <= 100
//1 <= code[i] <= 100
//-(n - 1) <= k <= n - 1
namespace Defuse_the_Bomb
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
            private int[] code1 = { 5, 7, 1, 4 };
            private int[] code2 = { 1, 2, 3, 4 };
            private int[] code3 = { 2, 4, 9, 3 };
            int k1 = 3, k2 = 0, k3 = -2;
            public Solution()
            {
                Console.WriteLine($"Code = [5, 7, 1, 4], k = 3; Output: {ArrayToString(Decrypt(code1, k1))}, Expected: [12,10,16,13]");
                Console.WriteLine($"Code = [1, 2, 3, 4], k = 0; Output: {ArrayToString(Decrypt(code2, k2))}, Expected: [0,0,0,0]");
                Console.WriteLine($"Code = [2,4,9,3], k = -2; Output: {ArrayToString(Decrypt(code3, k3))}, Expected: [12,5,6,13]");
            }
            public int[] Decrypt(int[] code, int k)
            {
                int[] returnArr = new int[code.Length];

                if (k == 0)
                {
                    foreach (var value in returnArr)
                    {
                        returnArr[value] = 0;
                    }
                }

                if (k > 0)
                {
                    for (int i = 0; i < code.Length; i++)
                    {
                        int index = i + 1;
                        int sum = 0;
                        for (int j = 0; j < k; j++)
                        {
                            if (index == code.Length)
                                index = 0;

                            sum += code[index];
                            index++;
                        }
                        returnArr[i] = sum;
                    }
                }
                if (k < 0)
                {
                    for (int i = 0; i < code.Length; i++)
                    {
                        int index = i - 1;
                        int sum = 0;
                        for (int j = 0; j < Math.Abs(k); j++)
                        {
                            if (index < 0)
                                index = code.Length - 1;

                            sum += code[index];
                            index--;

                        }
                        returnArr[i] = sum;
                    }
                }
                return returnArr;
            }
            private string ArrayToString(int[] arr)
            {
                if (arr == null)
                {
                    return null;
                }
                return "[" + string.Join(",", arr) + "]";
            }
        }
    }
}

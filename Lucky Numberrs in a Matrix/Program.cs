using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Given an m x n matrix of distinct numbers, return all lucky numbers in the matrix in any order.

//A lucky number is an element of the matrix such that it is the minimum element in its row and maximum in its column.

 

//Example 1:

//Input: matrix = [[3, 7, 8], [9, 11, 13], [15, 16, 17]]
//Output: [15]
//Explanation: 15 is the only lucky number since it is the minimum in its row and the maximum in its column.
//Example 2:

//Input: matrix = [[1, 10, 4, 2], [9, 3, 8, 7], [15, 16, 17, 12]]
//Output: [12]
//Explanation: 12 is the only lucky number since it is the minimum in its row and the maximum in its column.
//Example 3:

//Input: matrix = [[7, 8], [1, 2]]
//Output: [7]
//Explanation: 7 is the only lucky number since it is the minimum in its row and the maximum in its column.
 

//Constraints:

//m == mat.length
//n == mat[i].length
//1 <= n, m <= 50
//1 <= matrix[i][j] <= 105.
//All elements in the matrix are distinct.
namespace Lucky_Numbers_in_a_Matrix
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
            private int[][] matrix1 = new int[][]
            {
                new int[] { 3, 7, 8 },
                new int[] { 9, 11, 13 },
                new int[] { 15, 16, 17 }
            };

            private int[][] matrix2 = new int[][]
            {
                new int[] { 1, 10, 4, 2 },
                new int[] { 9, 3, 8, 7 },
                new int[] { 15, 16, 17, 12 }
            };
            private int[][] matrix3 = new int[][]
            {
                new int[] { 7, 8 },
                new int[] { 1, 2 }
            };
            public Solution()
            {
                Console.WriteLine($"Inputs: matrix = [[3,7,8],[9,11,13],[15,16,17]]; Output = " +
                    $"{LuckyNumbers(matrix1)}, Expected = [15]");

                Console.WriteLine($"Inputs: matrix = [[1,10,4,2],[9,3,8,7],[15,16,17,12]]; Output = " +
                    $"{LuckyNumbers(matrix2)}, Expected = [12]");
                Console.WriteLine($"Inputs: matrix = [[7,8],[1,2]]; Output = " +
                    $"{LuckyNumbers(matrix3)}, Expected = [7]");
            }

            public IList<int> LuckyNumbers(int[][] matrix)
            {
                List<int> luckyNumbers = new List<int>();
                for (int i = 0; i < matrix.Length; i++)
                {
                    int _luckyNumber = matrix[i].Min();
                    int indexOfMin = Array.IndexOf(matrix[i], _luckyNumber);

                    List<int> columnNumbers = new List<int>();

                    for (int j = 0; j < matrix.Length; j++)
                    {
                        columnNumbers.Add(matrix[j][indexOfMin]);
                    }

                    if (_luckyNumber == columnNumbers.Max())
                    {
                        luckyNumbers.Add(_luckyNumber);
                    }
                }
                return luckyNumbers;
            }
        }
    }

}
using System;
//You are given a n x n 2D array grid containing distinct elements in the range [0, n2 - 1].

//Implement the NeighborSum class:

//NeighborSum(int [][]grid) initializes the object.
//int adjacentSum(int value) returns the sum of elements which are adjacent neighbors of value, that is either to the top, left, right, or bottom of value in grid.
//int diagonalSum(int value) returns the sum of elements which are diagonal neighbors of value, that is either to the top-left, top-right, bottom-left, or bottom-right of value in grid.You are given a n x n 2D array grid containing distinct elements in the range [0, n2 - 1].

//Implement the NeighborSum class:

//NeighborSum(int [][]grid) initializes the object.
//int adjacentSum(int value) returns the sum of elements which are adjacent neighbors of value, that is either to the top, left, right, or bottom of value in grid.
//int diagonalSum(int value) returns the sum of elements which are diagonal neighbors of value, that is either to the top-left, top-right, bottom-left, or bottom-right of value in grid.
//Example 1:

//Input:

//["NeighborSum", "adjacentSum", "adjacentSum", "diagonalSum", "diagonalSum"]

//[[[[0, 1, 2], [3, 4, 5], [6, 7, 8]]], [1], [4], [4], [8]]

//Output: [null, 6, 16, 16, 4]
//Constraints:

//3 <= n == grid.length == grid[0].length <= 10
//0 <= grid[i][j] <= n2 - 1
//All grid[i][j] are distinct.
//value in adjacentSum and diagonalSum will be in the range [0, n2 - 1].
//At most 2 * n2 calls will be made to adjacentSum and diagonalSum.Constraints:

//3 <= n == grid.length == grid[0].length <= 10
//0 <= grid[i][j] <= n2 - 1
//All grid[i][j] are distinct.
//value in adjacentSum and diagonalSum will be in the range [0, n2 - 1].
//At most 2 * n2 calls will be made to adjacentSum and diagonalSum.
namespace Design_Neighbor_Sum_Service
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //testcase
            int[][] grid = new int[4][]
            {
                new int[] { 1, 2, 0, 3 },
                new int[] { 4, 7, 15, 6 },
                new int[] { 8, 9, 10, 11 },
                new int[] { 12, 13, 14, 5 }
            };

            NeighborSum obj = new NeighborSum(grid);
            int param_1 = obj.AdjacentSum(15);
            int param_2 = obj.DiagonalSum(9);
            Console.ReadLine();
        }
        public class NeighborSum
        {
            int[][] _grid;
            public NeighborSum(int[][] grid)
            {
                _grid = grid;
            }

            public int AdjacentSum(int value)
            {
                int theSum = 0;
                int xindexOfValue = 0, yindexOfValue = 0;

                for (int i = 0; i < _grid.Length; i++) // taking indexes of value in grid
                {
                    for (int j = 0; j < _grid[i].Length; j++)
                    {
                        if (_grid[i][j] == value)
                        {
                            xindexOfValue = i;
                            yindexOfValue = j;
                            break;
                        }
                    }
                }

                string indexesOfValue = $"{xindexOfValue}{yindexOfValue}";

                for (int i = 0; i < _grid.Length; i++)
                {
                    for (int j = 0; j < _grid[i].Length; j++)
                    {
                        if ($"{i - 1}{j}" == indexesOfValue || $"{i + 1}{j}" == indexesOfValue || $"{i}{j - 1}" == indexesOfValue || $"{i}{j + 1}" == indexesOfValue)
                        {
                            theSum += _grid[i][j];
                        }
                    }
                }
                return theSum;
            }

            public int DiagonalSum(int value)
            {
                int theSum = 0;
                int xindexOfValue = 0, yindexOfValue = 0;

                for (int i = 0; i < _grid.Length; i++) // taking indexes of value in grid
                {
                    for (int j = 0; j < _grid[i].Length; j++)
                    {
                        if (_grid[i][j] == value)
                        {
                            xindexOfValue = i;
                            yindexOfValue = j;
                            break;
                        }
                    }
                }
                string indexesOfValue = $"{xindexOfValue}{yindexOfValue}";
                for (int i = 0; i < _grid.Length; i++)
                {
                    for (int j = 0; j < _grid[i].Length; j++)
                    {
                        if ($"{i - 1}{j - 1}" == indexesOfValue || $"{i - 1}{j + 1}" == indexesOfValue || $"{i + 1}{j - 1}" == indexesOfValue || $"{i + 1}{j + 1}" == indexesOfValue)
                        {
                            theSum += _grid[i][j];
                        }
                    }
                }
                return theSum;
            }
        }
    }
}

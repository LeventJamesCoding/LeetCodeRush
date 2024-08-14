using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Snake in Matrix
//Difficulty: Easy
//There is a snake in an n x n matrix grid and can move in four possible directions. Each cell in the grid is identified by the position: grid[i][j] = (i * n) + j.

//The snake starts at cell 0 and follows a sequence of commands.

//You are given an integer n representing the size of the grid and an array of strings commands where each command[i] is either "UP", "RIGHT", "DOWN", and "LEFT". It's guaranteed that the snake will remain within the grid boundaries throughout its movement.

//Return the position of the final cell where the snake ends up after executing commands.There is a snake in an n x n matrix grid and can move in four possible directions. Each cell in the grid is identified by the position: grid[i][j] = (i * n) + j.

//The snake starts at cell 0 and follows a sequence of commands.

//You are given an integer n representing the size of the grid and an array of strings commands where each command[i] is either "UP", "RIGHT", "DOWN", and "LEFT". It's guaranteed that the snake will remain within the grid boundaries throughout its movement.

//Return the position of the final cell where the snake ends up after executing commands.
//Constraints:

//2 <= n <= 10
//1 <= commands.length <= 100
//commands consists only of "UP", "RIGHT", "DOWN", and "LEFT".
//The input is generated such the snake will not move outside of the boundaries.
namespace Snake_in_Matrix
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
            private int n1 = 2, n2 = 3;
            private List<string> commands1 = new List<string>() { "RIGHT", "DOWN" };
            private List<string> commands2 = new List<string>() { "DOWN", "RIGHT", "UP" };
            public Solution()
            {
                Console.WriteLine($"Input: n = {n1}, commands = [\"RIGHT\",\"DOWN\"]; Output = {FinalPositionOfSnake(n1, commands1)}, Expected = 3");
                Console.WriteLine($"Input: n = {n2}, commands = [\"DOWN\",\"RIGHT\",\"UP\"]; Output = {FinalPositionOfSnake(n2, commands2)}, Expected = 1");
            }

            public int FinalPositionOfSnake(int n, IList<string> commands)
            {
                int[,] grid = new int[n, n];
                int gridNumber = 0;

                for (int i = 0; i < n; i++) // creating a grid
                {
                    for (int j = 0; j < n; j++)
                    {
                        grid[i, j] = gridNumber;
                        gridNumber++;
                    }
                }

                gridNumber = 0;

                for (int i = 0; i < commands.Count; i++)
                {
                    if (commands[i] == "LEFT")
                    {
                        if (((gridNumber + n) % n) != 0)
                            gridNumber--;
                    }
                    else if (commands[i] == "RIGHT")
                    {
                        if (((gridNumber + 1) % n) != 0)
                            gridNumber++;
                    }
                    else if (commands[i] == "UP")
                    {
                        if (gridNumber >= n)
                            gridNumber -= n;
                    }
                    else if (commands[i] == "DOWN")
                    {
                        if (gridNumber < ((n * n) - n))
                            gridNumber += n;
                    }
                }
                return gridNumber;
            }

        }
    }
}

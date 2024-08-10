using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Can Place Flowers
//Difficulty: Easy
//You have a long flowerbed in which some of the plots are planted, and some are not. However, flowers cannot be planted in adjacent plots.

//Given an integer array flowerbed containing 0's and 1's, where 0 means empty and 1 means not empty, and an integer n, return true if n new flowers can be planted in the flowerbed without violating the no-adjacent-flowers rule and false otherwise.



//Example 1:

//Input: flowerbed = [1, 0, 0, 0, 1], n = 1
//Output: true
//Example 2:

//Input: flowerbed = [1, 0, 0, 0, 1], n = 2
//Output: false



//Constraints:

//1 <= flowerbed.length <= 2 * 104
//flowerbed[i] is 0 or 1.
//There are no two adjacent flowers in flowerbed.
//0 <= n <= flowerbed.length
namespace CanPlaceFlowers
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
            private int[] flowerbed1 = new int[] { 1, 0, 0, 0, 1 };
            private int[] flowerbed2 = new int[] { 1, 0, 0, 0, 1 };
            int n1 = 1, n2 = 2;
            public Solution()
            {
                Console.WriteLine($"Flowerbed: {flowerbed1}, n: {n1}; Output: {CanPlaceFlowers(flowerbed1, n1)}, Expected: True");
                Console.WriteLine($"Flowerbed: {flowerbed2}, n: {n2}; Output: {CanPlaceFlowers(flowerbed2, n2)}, Expected: False");
            }
            public bool CanPlaceFlowers(int[] flowerbed, int n)
            {
                int plantCounter = 0;
                for (int i = 0; i < flowerbed.Length; i++)
                {
                    int altsinir = i - 1;
                    int ustsinir = i + 1;

                    if (altsinir < 0) altsinir = 0;
                    if (ustsinir >= flowerbed.Length) ustsinir = flowerbed.Length - 1;

                    if (flowerbed[altsinir] == 0 && flowerbed[ustsinir] == 0 && flowerbed[i] == 0)
                    {
                        flowerbed[i] = 1;
                        plantCounter++;
                    }
                }

                if (plantCounter >= n)
                    return true;

                return false;
            }
        }
    }
}

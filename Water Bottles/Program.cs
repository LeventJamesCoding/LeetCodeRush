using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Water Bottles
//Difficulty: Easy
//There are numBottles water bottles that are initially full of water. You can exchange numExchange empty water bottles from the market with one full water bottle.

//The operation of drinking a full water bottle turns it into an empty bottle.

//Given the two integers numBottles and numExchange, return the maximum number of water bottles you can drink.



//Example 1:


//Input: numBottles = 9, numExchange = 3
//Output: 13
//Explanation: You can exchange 3 empty bottles to get 1 full water bottle.
//Number of water bottles you can drink: 9 + 3 + 1 = 13.
//Example 2:


//Input: numBottles = 15, numExchange = 4
//Output: 19
//Explanation: You can exchange 4 empty bottles to get 1 full water bottle. 
//Number of water bottles you can drink: 15 + 3 + 1 = 19.


//Constraints:

//1 <= numBottles <= 100
//2 <= numExchange <= 100
namespace Water_Bottles
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
            private int numBottles1 = 9, numExchange1 = 3;
            private int numBottles2 = 15, numExchange2 = 4;
            public Solution()
            {
                Console.WriteLine($"numBottles: 9, numExchange: 3; Output: {NumWaterBottles(numBottles1, numExchange1)}, Expected: 13");
                Console.WriteLine($"numBottles: 15, numExchange: 4; Output: {NumWaterBottles(numBottles2, numExchange2)}, Expected: 19");
            }
            public int NumWaterBottles(int numBottles, int numExchange)
            {
                int bottlesDrank = 0;
                int fullBottlesLeft = numBottles;
                int emptyBottlesLeft = 0;

                while (true)
                {
                    bottlesDrank += fullBottlesLeft;
                    emptyBottlesLeft = numBottles;
                    fullBottlesLeft = 0;
                    if (numBottles < numExchange) break;
                    fullBottlesLeft = numBottles / numExchange;
                    emptyBottlesLeft = numBottles % numExchange;
                    numBottles = fullBottlesLeft + emptyBottlesLeft;
                }
                return bottlesDrank;
            }
        }
    }
}
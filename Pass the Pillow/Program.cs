using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Pass the Pillow
//Difficulty: Easy
//There are n people standing in a line labeled from 1 to n. The first person in the line is holding a pillow initially. Every second, the person holding the pillow passes it to the next person standing in the line. Once the pillow reaches the end of the line, the direction changes, and people continue passing the pillow in the opposite direction.

//For example, once the pillow reaches the nth person they pass it to the n - 1th person, then to the n - 2th person and so on.
//Given the two positive integers n and time, return the index of the person holding the pillow after time seconds.



//Example 1:

//Input: n = 4, time = 5
//Output: 2
//Explanation: People pass the pillow in the following way: 1-> 2-> 3-> 4-> 3-> 2.
//After five seconds, the 2nd person is holding the pillow.
//Example 2:

//Input: n = 3, time = 2
//Output: 3
//Explanation: People pass the pillow in the following way: 1-> 2-> 3.
//After two seconds, the 3rd person is holding the pillow.


//Constraints:

//2 <= n <= 1000
//1 <= time <= 1000
namespace Pass_the_Pillow
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
            private int n1 = 4, time1 = 5;
            private int n2 = 3, time2 = 2;
            public Solution()
            {
                Console.WriteLine($"n: 4, time: 5; Output: {PassThePillow(n1, time1)}, Expected: 2");
                Console.WriteLine($"n: 3, time: 2; Output: {PassThePillow(n2, time2)}, Expected: 3");
            }
            public int PassThePillow(int n, int time)
            {
                bool direction = true; // means to the right
                int pillowHolder = 1;

                for (int i = 1; i <= time; i++)
                {
                    if (direction) // to the right
                    {
                        pillowHolder++;
                        if (pillowHolder == n)
                            direction = false;
                    }
                    else if (!direction) // to the left
                    {
                        pillowHolder--;
                        if (pillowHolder == 1)
                            direction = true;
                    }
                }
                return pillowHolder;
            }
        }
    }
}
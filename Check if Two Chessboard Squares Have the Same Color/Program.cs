//You are given two strings, coordinate1 and coordinate2, representing the coordinates of a square on an 8 x 8 chessboard.

//Below is the chessboard for reference.



//Return true if these two squares have the same color and false otherwise.

//The coordinate will always represent a valid chessboard square. The coordinate will always have the letter first (indicating its column), and the number second (indicating its row).
namespace Check_if_Two_Chessboard_Squares_Have_the_Same_Color
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
            private string coordinate1 = "a1", coordinate2 = "c3", coordinate3 = "a1", coordinate4 = "h3";
            public Solution()
            {
                Console.WriteLine($"Inputs: coordinate1 = {coordinate1}, coordinate2 = {coordinate2}; " +
                    $"Output = {CheckTwoChessboards(coordinate1, coordinate2)}, Expected = True");
                Console.WriteLine($"Inputs: coordinate1 = {coordinate3}, coordinate2 = {coordinate4}; " +
                    $"Output = {CheckTwoChessboards(coordinate3, coordinate4)}, Expected = False");
            }
            public bool CheckTwoChessboards(string coordinate1, string coordinate2)
            {
                Dictionary<char, int> coordinateValuePairs = new Dictionary<char, int>();
                coordinateValuePairs.Add('a', 1);
                coordinateValuePairs.Add('b', 2);
                coordinateValuePairs.Add('c', 3);
                coordinateValuePairs.Add('d', 4);
                coordinateValuePairs.Add('e', 5);
                coordinateValuePairs.Add('f', 6);
                coordinateValuePairs.Add('g', 7);
                coordinateValuePairs.Add('h', 8);

                if ((coordinateValuePairs[coordinate1[0]] + coordinate1[1]) % 2 == (coordinateValuePairs[coordinate2[0]] + coordinate2[1]) % 2)
                {
                    return true;
                }
                return false;
            }
        }
    }
}

//The Leetcode file system keeps a log each time some user performs a change folder operation.

//The operations are described below:

//"../" : Move to the parent folder of the current folder. (If you are already in the main folder, remain in the same folder).
//"./" : Remain in the same folder.
//"x/" : Move to the child folder named x (This folder is guaranteed to always exist).
//You are given a list of strings logs where logs[i] is the operation performed by the user at the ith step.

//The file system starts in the main folder, then the operations in logs are performed.

//Return the minimum number of operations needed to go back to the main folder after the change folder operations.The Leetcode file system keeps a log each time some user performs a change folder operation.

//The operations are described below:

//"../" : Move to the parent folder of the current folder. (If you are already in the main folder, remain in the same folder).
//"./" : Remain in the same folder.
//"x/" : Move to the child folder named x (This folder is guaranteed to always exist).
//You are given a list of strings logs where logs[i] is the operation performed by the user at the ith step.

//The file system starts in the main folder, then the operations in logs are performed.

//Return the minimum number of operations needed to go back to the main folder after the change folder operations.
namespace CrawlerLogFolder
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
    public class Solution
    {
        public int MinOperations(string[] logs)
        {
            int layer = 0;
            for (int i = 0; i < logs.Length; i++) 
            {
                string operation = "";
                for (int j = 0; j < logs[i].Length - 1; j++) 
                {
                    operation += logs[i][j];
                }

                if (operation != "." && operation != "..")
                    layer++;
                else if (operation == "..")
                    layer--;

                if (layer < 0)
                    layer = 0;
            }

            return layer;
        }
    }
}

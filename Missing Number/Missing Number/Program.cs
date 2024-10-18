namespace Missing_Number
{
    internal class Program
    {

    }
    public class Solution
    {
        public int MissingNumber(int[] nums)
        {
            Stack<int> stack = new Stack<int>();
            int result = 0;
            for(int i = 0; i < nums.Length+1; i++) 
            {
                stack.Push(i);
            }

            foreach(int number in stack)
            {
                if(!nums.Contains(number))
                {
                    result = number; 
                    break;
                }
            }
            return result;  
        }
    }
}


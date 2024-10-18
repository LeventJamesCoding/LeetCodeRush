namespace ContainsDuplicate
{
    internal class Program
    {

    }
    public class Solution
    {
        public bool ContainsDuplicate(int[] nums) 
        {
            Stack<int> stack = new Stack<int>();
            foreach (int x in nums)
            {
                if(!stack.Contains(x))
                {
                    stack.Push(x);
                }
                else
                {
                    return true;
                }
            }
            return false;
        }
}
}

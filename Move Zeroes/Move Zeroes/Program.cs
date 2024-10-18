namespace MoveZeroes
{
    internal class Program
    {

    }
    public class Solution
    {
        public void MoveZeroes(int[] nums)
        {
            int zeroCount = 0;
            for (int i = 0; i < nums.Length; i++) 
            {
                if (nums[i] == 0)
                {
                    zeroCount++; 
                }
                else if (zeroCount > 0)
                {
                    nums[i - zeroCount] = nums[i];
                }
            }
            int right = nums.Length - 1; 
            while (zeroCount > 0)
            {
                nums[right] = 0;
                zeroCount--; 
                right--; 
            }
        }
    }
}
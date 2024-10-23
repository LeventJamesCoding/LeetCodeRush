namespace MoveZeroes
{
    internal class Program
    {

    }
    public class Solution
    {
        public void MoveZeroes(int[] nums)
        {
            List<int> dummyNums = new List<int>();
            int zeroCounts = 0;

            foreach (int x in nums)
            {
                if (x != 0)
                {
                    dummyNums.Add(x);
                }
                else
                {
                    zeroCounts++;
                }
            }

            for (int i = 0; i < zeroCounts; i++)
            {
                dummyNums.Add(0);
            }
            
            for(int i = 0; i < nums.Length; i++)
            {
                nums[i] = dummyNums[i];
            }
        }
    }
}
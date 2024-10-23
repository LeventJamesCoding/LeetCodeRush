namespace Find_the_Pivot_Integer
{
    internal class Program
    {

    }
    public class Solution
    {
        public int PivotInteger(int n)
        {
            for(int pivotNumber = 1; pivotNumber <= n; pivotNumber++)
            {
                int lowerSum = 0;
                int upperSum = 0;
                //calculate lowerSum
                for(int i = 1; i <= pivotNumber; i++)
                {
                    lowerSum += i;
                }
                //calculate upperSum
                for(int i = pivotNumber;i <= n; i++)
                {
                    upperSum += i;  
                }
                if(upperSum == lowerSum)
                {
                    return pivotNumber;
                }
            }
            return -1;
        }
    }
}
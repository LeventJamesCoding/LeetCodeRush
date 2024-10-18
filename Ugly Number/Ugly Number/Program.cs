namespace UglyNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
        public class Solution
        {
            public bool IsUgly(int n)
            {
                if (n <= 0)
                    return false;

                int[] limits = { 2, 3, 5 };

                foreach (int limit in limits)
                {
                    while (n % limit == 0)
                    {
                        n /= limit;
                    }
                }

                return n == 1;
            }
        }

    }
}

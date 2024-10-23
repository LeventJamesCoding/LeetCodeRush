namespace Power_of_Two
{
    internal class Program
    {

    }
    public class Solution
    {
        public bool IsPowerOfTwo(int n)
        {
            if (n <= 0) return false;
            var result = Math.Log2(n);
            return result == (int)result;
        }
    }
}

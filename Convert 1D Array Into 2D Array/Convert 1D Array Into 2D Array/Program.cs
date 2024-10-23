namespace Convert_1D_Array_Into_2D_Array
{
    internal class Program
    {

    }
    public class Solution
    {
        public int[][] Construct2DArray(int[] original, int m, int n)
        {
            List<List<int>> list = new List<List<int>>();
            if (original.Length != m * n)
            {
                return new int[0][];
            }

            for (int i = 0; i < original.Length; i += n)
            {
                List<int> temp = new List<int>();
                for (int j = i; j < n + i; j++)
                {
                    temp.Add(original[j]);
                }
                list.Add(temp);
            }
            return list.Select(innerList => innerList.ToArray()).ToArray();
        }
    }
}
namespace Pascals_Triangle
{
    public class Solution
    {
        public IList<IList<int>> Generate(int numRows)
        {
            IList<IList<int>> result = new List<IList<int>>(); 
            List<int> temp = new List<int>();

            for(int i = 0; i < numRows; i++)
            {
                List<int> row = new List<int>();
                int size = i + 1;

                for (int j = 0; j < size; j++) 
                {
                    if (j == 0 || j == size - 1)
                    {
                        row.Add(1);
                        continue;
                    }
                    int numberToAdd = temp[j] + temp[j - 1];
                    row.Add(numberToAdd);
                }
                result.Add(row);
                temp = row;
            }

            return result;
        }
    }
}
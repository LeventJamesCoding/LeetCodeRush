namespace Find_XSum_of_All_KLong_Subarrays_I
{
    public class Solution
    {
        public int[] FindXSum(int[] nums, int k, int x)
        {
            int[] result = new int[nums.Length - k + 1]; 
            for (int i = 0; i <= nums.Length - k; i++)
            {
                List<int> list = new List<int>();
                for (int j = i; j < i + k; j++)
                {
                    list.Add(nums[j]);
                }
                result[i] = XSum(list.ToArray(), x); 
            }
            return result;
        }

        public int XSum(int[] nums, int n)
        {
            Dictionary<int, int> elementFrequencyMap = new Dictionary<int, int>();

            foreach (int num in nums)
            {
                if (!elementFrequencyMap.ContainsKey(num))
                {
                    elementFrequencyMap.Add(num, 1);
                }
                else
                {
                    elementFrequencyMap[num]++;
                }
            }

            var sortedElements = elementFrequencyMap
                .OrderByDescending(kv => kv.Value)
                .ThenByDescending(kv => kv.Key)
                .Take(n);

            int sum = 0;
            foreach(var element in sortedElements)
            {
                sum += element.Key * element.Value;
            }
            return sum;
        }
    }

}

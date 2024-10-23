namespace First_Bad_Version
{
    /* The isBadVersion API is defined in the parent class VersionControl.
      bool IsBadVersion(int version); */

    public class Solution : VersionControl
    {
        public int FirstBadVersion(int n)
        {
            //binary search
            int low = 1;
            int high = n;

            while (Math.Abs(high - low) > 1)
            {
                int mid = low + ((high - low) / 2);
                bool status = IsBadVersion(mid);
                if (status == false)
                {
                    low = mid;
                }
                else
                {
                    if (!IsBadVersion(mid - 1))
                    {
                        return mid;
                    }
                    high = mid;
                }
            }
            for (int i = 1; i <= n; i++)
            {
                if (IsBadVersion(i))
                {
                    return i;
                }
            }
            return -1;
        }
    }
}

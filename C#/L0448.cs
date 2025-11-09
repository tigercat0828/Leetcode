// Time O(n)
// Space O(1)
public class Solution1
{
    public IList<int> FindDisappearedNumbers(int[] nums)
    {
        List<int> result = [];
        for (int i = 0; i < nums.Length; i++)
        {
            int index = Math.Abs(nums[i]) - 1;
            if (nums[index] > 0)
            {
                nums[index] *= -1;
            }
        }
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] > 0)
            {   // not processed
                result.Add(i + 1);
            }
        }
        return result;
    }
}

public class Solution2
{
    public IList<int> FindDisappearedNumbers(int[] nums)
    {
        List<int> result = [];
        for (int i = 0; i < nums.Length; i++)
        {
            int index = Math.Abs(nums[i]) - 1;
            if (nums[index] > 0)
            {
                nums[index] *= -1;
            }
        }
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] > 0)
            {   // not processed
                result.Add(i + 1);
            }
        }
        return result;
    }
}

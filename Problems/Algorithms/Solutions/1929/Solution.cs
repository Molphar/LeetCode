public class Solution
{
    public int[] GetConcatenation(int[] nums)
    {
        // My solution
        int[] ans = new int[2 * nums.Length];

        for (int i = 0; i < nums.Length; i++)
        {
            ans[i] = nums[i];
            ans[nums.Length + i] = nums[i];
        }

        return ans;
    }
}
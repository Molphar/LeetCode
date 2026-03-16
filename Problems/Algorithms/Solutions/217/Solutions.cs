public class Solution
{
    public bool ContainsDuplicate(int[] nums)
    {
        /* Original implementation, a solution, but slow
        Array.Sort(nums);

        for(int i = 1; i < nums.Length; i++)       
        {
            if(nums[i-1] == nums[i])
            return true;            
        }

        return false;
        */

        return nums.Length > new HashSet<int>(nums).Count();
    }
}
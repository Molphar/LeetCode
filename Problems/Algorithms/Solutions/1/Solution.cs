public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        /*
        // My solution
        for(int i =0; i< nums.Length- 1; i++)
            for(int j = i + 1; j < nums.Length; j++)
            if(target - nums[i] == nums[j]){
                return [i,j];
            }
        return [0,0];
        */

        var hashMap = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int indexHash;

            // Try to get index of a original array by the key of a value of a original array
            if (hashMap.TryGetValue(nums[i], out indexHash))
                return [indexHash, i];

            // this is a value that we are looking to for index i value
            int increment = target - nums[i];

            // we will try to add to dictionary value that we are looking for value with index i
            hashMap.TryAdd(increment, i);
        }

        return [-1, -1];
    }
}
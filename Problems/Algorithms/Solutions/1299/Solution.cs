public class Solution
{
    public int[] ReplaceElements(int[] arr)
    {

        // My solution
        // int maxValue = 0;
        // int prevValue = 0;

        // for(int i = arr.Length - 1; i >= 0; i--)
        // {
        //     maxValue = Math.Max(maxValue, prevValue);
        //     prevValue = arr[i];
        //     arr[i] = maxValue;
        // }

        // arr[arr.Length - 1] = -1;

        // return arr;

        int maxValue = -1;

        for (int i = arr.Length - 1; i >= 0; i--)
        {
            int currentValue = arr[i];
            arr[i] = maxValue;
            maxValue = Math.Max(maxValue, currentValue);
        }

        return arr;
    }
}
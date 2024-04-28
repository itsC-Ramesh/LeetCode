namespace LeetCode.Problems;
public class _1480_RunningSumOfArray
{
    //Problems:https://leetcode.com/problems/running-sum-of-1d-array/
    //Solution:https://leetcode.com/problems/running-sum-of-1d-array/submissions/1060671808/
    public int[] RunningSum(int[] nums)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] += nums[i - 1];
        }

        var ans = new int[nums.Length];
        ans[0] = nums[0];
        for (int i = 1; i < nums.Length; i++)
        {
            ans[i] = nums[i] + ans[i - 1];
        }
        return ans;
    }

    //Solution:https://leetcode.com/problems/running-sum-of-1d-array/submissions/1060676058/
    public int[] RunningSum_2(int[] nums)
    {
        int c = 0;
        return nums.Select(x => c += x).ToArray();
    }

    //Solution: https://leetcode.com/problems/running-sum-of-1d-array/submissions/1061337157/
    public int[] RunningSum_3(int[] nums)
    {
        for (int i = 1; i < nums.Length; i++) nums[i] += nums[i - 1];
        return nums;
    }
}

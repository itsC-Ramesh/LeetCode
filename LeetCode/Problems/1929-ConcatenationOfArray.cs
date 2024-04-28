namespace LeetCode.Problems;
internal class _1929_ConcatenationOfArray
{
    //Problem : https://leetcode.com/problems/concatenation-of-array/
    //Solution : https://leetcode.com/problems/concatenation-of-array/submissions/1060665087/
    public int[] GetConcatenation(int[] nums)
    {
        var ans = new int[nums.Length * 2];
        for (int i = 0; i < nums.Length; i++)
        {
            ans[i] = nums[i];
            ans[i + nums.Length] = nums[i];
        }
        return ans;
    }
}

namespace LeetCode.Problems;
internal class _1920_BuildArrayfromPermutation
{
    //Problems : https://leetcode.com/problems/build-array-from-permutation/
    //Solution : https://leetcode.com/problems/build-array-from-permutation/submissions/1060653937/
    public int[] BuildArray(int[] nums)
    {
        nums.Select(x => nums[x]).ToArray();

        var ans = new int[nums.Length];
        for (int i = 0; i < nums.Length; i++)
        {
            ans[i] = nums[nums[i]];
        }
        return ans;
    }

    //Solution : https://leetcode.com/problems/build-array-from-permutation/submissions/1060655901/
    public int[] BuildArray2(int[] nums)
    {
        return nums.Select(x => nums[x]).ToArray();
    }
}

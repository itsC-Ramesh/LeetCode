namespace LeetCode.Problems;
internal class _001_TwoSum
{
    //Problems: https://leetcode.com/problems/two-sum/

    //Solution-1:https://leetcode.com/problems/two-sum/submissions/1059560520/

    public int[] TwoSum(int[] nums, int target)
    {
        var op = new int[2];

        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if ((nums[i] + nums[j] == target)) return new int[] { i, j };
            }
        }
        return op;
    }

    //Solution-2 :https://leetcode.com/problems/two-sum/submissions/1059650211/
    public int[] TwoSum2(int[] nums, int target)
    {
        var dict = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            var diff = target - nums[i];
            if (dict.ContainsKey(diff))
            {
                return new int[] { dict[diff], i };
            }
            else
            {
                dict[nums[i]] = i;
            }
        }
        return new int[] { 0, 0 };
    }

}

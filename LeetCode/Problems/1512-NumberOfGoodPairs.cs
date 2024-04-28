namespace LeetCode.Problems;
public class _1512_NumberOfGoodPairs
{
    //Problems: https://leetcode.com/problems/number-of-good-pairs/
    //Solution: https://leetcode.com/problems/number-of-good-pairs/submissions/1061302280
    public int NumIdenticalPairs(int[] nums)
    {
        var goodPairs = 0;
        for (int i = 0; i < nums.Length - 1; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] == nums[j]) goodPairs++;
            }
        }
        return goodPairs;
    }

    //Solution: https://leetcode.com/problems/number-of-good-pairs/submissions/1061302280/
    public int NumIdenticalPairs_1(int[] nums)
    {

        int[] count = new int[101];
        int goodPairs = 0;

        foreach (int num in nums)
        {
            goodPairs += count[num];
            count[num]++;
        }

        return goodPairs;
    }




}

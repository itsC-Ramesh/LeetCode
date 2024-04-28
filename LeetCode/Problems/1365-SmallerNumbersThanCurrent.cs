using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems;
public class _1365_SmallerNumbersThanCurrent
{
    //Problems: https://leetcode.com/problems/how-many-numbers-are-smaller-than-the-current-number/

    //Solution: https://leetcode.com/problems/how-many-numbers-are-smaller-than-the-current-number/submissions/1061311902/

    public int[] SmallerNumbersThanCurrent(int[] nums)
    {
        var result = new int[nums.Length];

        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = 0; j < nums.Length; j++)
            {
                if (nums[i] > nums[j]) result[i]++;
            }
        }
        return result;
    }

    public int[] SmallerNumbersThanCurrent_1(int[] nums)
    {
        var count = new int[101];
        var result = new int[nums.Length];

        foreach (var num in nums) count[num]++;

        for (int i = 1; i < count.Length; i++) count[i] += count[i - 1];

        for (int i = 0; i < nums.Length; i++) result[i] = (nums[i] == 0) ? 0 : count[nums[i] - 1];

        return result;
    }
}
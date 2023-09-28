using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems;
public class _1470_ShuffleArray
{
    //Problem: https://leetcode.com/problems/shuffle-the-array/
    //Solution: https://leetcode.com/problems/shuffle-the-array/submissions/1061183801/
    public int[] Shuffle(int[] nums, int n)
    {
        var shuffledArray = new int[nums.Length];
        for (int i = 0, j = 0; i < n; i++, j++)
        {
            shuffledArray[j] = nums[i];
            shuffledArray[++j] = nums[i + n];
        }

        return shuffledArray;

    }
}

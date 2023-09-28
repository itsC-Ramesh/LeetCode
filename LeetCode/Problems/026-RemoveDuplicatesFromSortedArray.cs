using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems;
internal class _026_RemoveDuplicatesFromSortedArray
{
    //Problems: https://leetcode.com/problems/remove-duplicates-from-sorted-array/
    //Solution: https://leetcode.com/problems/remove-duplicates-from-sorted-array/submissions/1059700977/
    public int RemoveDuplicates(int[] nums)
    {
        var k = 1;
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i - 1] != nums[i])
            {
                nums[k] = nums[i];
                k++;
            }
        }
        return k;
    }
}

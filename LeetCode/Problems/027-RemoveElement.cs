using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems;
internal class _027_RemoveElement
{
    //Problem : https://leetcode.com/problems/remove-element
    //Solution : https://leetcode.com/problems/remove-element/submissions/1059796041/
    public int RemoveElement(int[] nums, int val)
    {
        var k = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != val)
            {
                nums[k] = nums[i];
                k++;
            }
        }
        return k;
    }
}

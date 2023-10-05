using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems;
public class _153_FindMinimumInRotatedSortedArray
{
    public int FindMin(int[] nums)
    {
        int left = 0;
        int right = nums.Length - 1;


        while (left < right)
        {
            int mid = left + (right - left) / 2;

            if (nums[mid] >= nums[left])
            {
                if (nums[left] < nums[right])
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }
            else
            {
                right = mid;
            }
        }
        return nums[left];
    }


    public int FindMin_1(int[] nums)
    {
        int left = 0;
        int right = nums.Length - 1;

        while (left < right)
        {
            int mid = left + (right - left) / 2;

            if (nums[mid] > nums[right]) left = mid + 1;
            else right = mid;
        }
        return nums[left];
    }
}

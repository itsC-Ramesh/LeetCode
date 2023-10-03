using System.Globalization;
using System.Xml.Linq;
using System.Xml.Schema;

namespace LeetCode.Problems;
public class _540_SingleElementInSortedArray
{
    //Problem: https://leetcode.com/problems/single-element-in-a-sorted-array/description/
    //You are given a sorted array consisting of only integers where every element appears exactly twice, except for one element which appears exactly once.
    //Return the single element that appears only once.


    //Your solution must run in O(log n) time and O(1) space.

    //Example 1: Input: nums = [1,1,2,3,3,4,4,8,8] Output: 2
    //Example 2: Input: nums = [3,3,7,7,10,11,11] Output: 10

    //Solution: https://leetcode.com/problems/single-element-in-a-sorted-array/submissions/1066013913/
    public int SingleNonDuplicate(int[] nums)
    {
        int start = 0;
        int end = nums.Length - 1;

        if (nums.Length < 2)
        {
            return nums[start];
        }
        else if (nums[start] != nums[start + 1])
        {
            return nums[start];
        }
        else if (nums[end] != nums[end - 1])
        {
            return nums[end];
        }

        while (start <= end)
        {
            int mid = start + (end - start) / 2;

            if (nums[mid] > nums[mid - 1] && nums[mid] < nums[mid + 1])
            {
                return nums[mid];
            }
            else if ((nums[mid] == nums[mid + 1] && mid % 2 == 0) || (nums[mid] == nums[mid - 1] && mid % 2 != 0))
            {
                start = mid + 1;
            }
            else
            {
                end = mid - 1;
            }
        }
        return nums[end];
    }

    //Solution: https://leetcode.com/problems/single-element-in-a-sorted-array/submissions/1066021425/
    public int SingleNonDuplicate_1(int[] nums)
    {
        int start = 0;
        int end = nums.Length - 1;

        while (start < end)
        {
            int mid = start + ((end - start) / 2);

            if (mid % 2 != 0) mid--;

            if (nums[mid] != nums[mid + 1]) end = mid;
            else start = mid + 2;
        }
        return nums[start];
    }
}


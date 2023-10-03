namespace LeetCode.Problems;
public class _34_FindFirstAndLastPositionOfElementInSortedArray
{
    //Problem: https://leetcode.com/problems/find-first-and-last-position-of-element-in-sorted-array/

    /*
    Given an array of integers nums sorted in non-decreasing order, find the starting and ending position of a given target value.

    If target is not found in the array, return [-1, -1].
    You must write an algorithm with O(log n) runtime complexity.

    Example 1:    
        Input: nums = [5,7,7,8,8,10], target = 8
        Output: [3,4]
    
    Example 2:    
        Input: nums = [5,7,7,8,8,10], target = 6
        Output: [-1,-1]
    
    Example 3:
        Input: nums = [], target = 0
        Output: [-1,-1]
     
    
    Constraints:
        0 <= nums.length <= 105
        -109 <= nums[i] <= 109
        nums is a non-decreasing array.
        -109 <= target <= 109    
     */

    //Solution: https://leetcode.com/problems/find-first-and-last-position-of-element-in-sorted-array/submissions/1065917258/
    public int[] SearchRange(int[] nums, int target)
    {
        int start = 0; int end = nums.Length - 1;

        int i = -1; int j = -1;

        while (start <= end)
        {
            int mid = start + (end - start) / 2;
            if (nums[mid] == target)
            {
                i = mid;
                end = mid - 1;
            }
            else if (nums[mid] > target)
            {
                end = mid - 1;
            }
            else
            {
                start = mid + 1;
            }
        }

        start = 0;
        end = nums.Length - 1;

        while (start <= end)
        {
            int mid = start + (end - start) / 2;
            if (nums[mid] == target)
            {
                j = mid;
                start = mid + 1;
            }
            else if (nums[mid] > target)
            {
                end = mid - 1;
            }
            else
            {
                start = mid + 1;
            }
        }
        return new int[] { i, j };
    }
}

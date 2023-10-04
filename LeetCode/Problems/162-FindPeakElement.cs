namespace LeetCode.Problems;
public class _162_FindPeakElement
{
    //Problem: https://leetcode.com/problems/find-peak-element/description/
    /* Description:
     
        A peak element is an element that is strictly greater than its neighbors.

        Given a 0-indexed integer array nums, find a peak element, and return its index. If the array contains multiple peaks, return the index to any of the peaks.

        You may imagine that nums[-1] = nums[n] = -∞. In other words, an element is always considered to be strictly greater than a neighbor that is outside the array.

       Examples,
        Example 1: Input: nums = [1,2,3,1]  Output: 2
        Explanation: 3 is a peak element and your function should return the index number 2.

        Example 2: Input: nums = [1,2,1,3,5,6,4] Output: 5
        Explanation: Your function can return either index number 1 where the peak element is 2, or index number 5 where the peak element is 6.
     */

    //Solution: https://leetcode.com/problems/find-peak-element/submissions/1066514036/
    public int FindPeakElement(int[] nums)
    {
        int start = 0;
        int end = nums.Length - 1;

        while (start < end)
        {
            int mid = start + (end - start) / 2;

            if (nums[mid] > nums[mid + 1])
            {
                end = mid;
            }
            else
            {
                start = mid + 1;
            }
        }
        return start;
    }
}

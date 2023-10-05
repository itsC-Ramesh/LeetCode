namespace LeetCode.Problems;
public class _33_SearchInRotatedSortedArray
{
    //public int Search(int[] nums, int target)
    //{
    //    int start = 0;
    //    int end = nums.Length - 1;

    //    while (start <= end)
    //    {
    //        int mid = start + (end - start) / 2;

    //        if (nums[mid] == target)
    //        {
    //            return mid;
    //        }

    //        if (nums[start] <= nums[mid])
    //        {
    //            if (nums[start] <= target && target < nums[mid])
    //            {
    //                end = mid - 1;
    //            }
    //            else
    //            {
    //                start = mid + 1;
    //            }
    //        }
    //        else
    //        {
    //            if (nums[mid] < target && target <= nums[end])
    //            {
    //                start = mid + 1;
    //            }
    //            else
    //            {
    //                end = mid - 1;
    //            }
    //        };
    //    }
    //    return -1;
    //}


    public int Search(int[] nums, int target)
    {
        int left = 0;
        int right = nums.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (nums[mid] == target) return mid;

            if (nums[left] <= nums[mid])
            {
                if (nums[left] <= target && target < nums[mid])
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
                if (nums[right] >= target && target > nums[mid])
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
        }
        return -1;
    }
}

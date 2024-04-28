namespace LeetCode.Problems;
public class _2089_FindTargetIndicesAfterSortingArray
{
    //BruteForceSolution
    //TimeComplexity O(N)
    public IList<int> TargetIndices_1(int[] nums, int target)
    {
        Array.Sort(nums);
        List<int> result = new List<int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == target) result.Add(i);
            else if (nums[i] > target) break;
        }
        return result;
    }

    //Binary Search Solution..
    public IList<int> TargetIndices(int[] nums, int target)
    {
        Array.Sort(nums); // Sort the array

        int left = 0;
        int right = nums.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (nums[mid] == target)
            {
                int lowerSide = mid - 1;
                while (lowerSide >= left && nums[lowerSide] == target) lowerSide--;

                int upperSide = mid + 1;
                while (upperSide <= right && nums[upperSide] == target) upperSide++;

                List<int> result = new();

                for (int i = lowerSide + 1; i < upperSide; i++) result.Add(i);
                return result;
            }
            else if (nums[mid] < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }
        return new List<int>(); //Return th list
    }
}

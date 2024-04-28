namespace LeetCode.Problems;
public class _905_SortArrayByParity
{
    //Problems: https://leetcode.com/problems/sort-array-by-parity/

    //Solution: https://leetcode.com/problems/sort-array-by-parity/submissions/1062173779/
    public int[] SortArrayByParity_1(int[] nums)
    {
        var result = new int[nums.Length];

        for (int i = 0, k = 0, j = nums.Length - 1; i < nums.Length; i++)
        {
            if (nums[i] % 2 == 0)
            {
                result[k] = nums[i];
                k++;
            }
            else
            {
                result[j] = nums[i];
                j--;
            }
        }
        return result;

    }

    //Solution: https://leetcode.com/problems/sort-array-by-parity/submissions/1062184240/
    public int[] SortArrayByParity(int[] nums)
    {

        var left = 0;
        var right = nums.Length - 1;

        while (left < right)
        {
            while (left < right && nums[left] % 2 == 0)
            {
                left++;
            }

            while (left < right && nums[right] % 2 != 0)
            {
                right--;
            }

            if (left < right)
            {
                nums[left] += nums[right];
                nums[right] = nums[left] - nums[right];
                nums[left] -= nums[right];
            }
        }
        return nums;
    }

}

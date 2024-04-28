namespace LeetCode.Problems;
public class _1295_FindNumbersWithEvenNumberDigits
{
    //Problem: https://leetcode.com/problems/find-numbers-with-even-number-of-digits/
    //Solution: https://leetcode.com/problems/find-numbers-with-even-number-of-digits/submissions/1061598073/
    public int FindNumbers(int[] nums)
    {
        var count = 0;
        foreach (var num in nums)
        {
            int numCount = 1;
            var x = num;
            while (x >= 10)
            {
                numCount++;
                x /= 10;
            }
            if (numCount % 2 == 0) count++;
        }
        return count;
    }

    public int FindNumbers_1(int[] nums)
    {
        return nums.Count(x => x.ToString().Length % 2 == 0);
    }

}

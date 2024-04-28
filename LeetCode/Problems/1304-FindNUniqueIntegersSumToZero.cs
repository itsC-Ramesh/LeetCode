namespace LeetCode.Problems;
public class _1304_FindNUniqueIntegersSumToZero
{
    public int[] SumZero(int n)
    {
        var result = new int[n];

        int x = n / 2;

        if (n % 2 != 0) result[x] = 0;

        for (int i = 0, j = n - 1; i < n / 2; i++, j--)
        {
            result[i] = -x;
            result[j] = x;
            x--;
        }
        return result;
    }
}

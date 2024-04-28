namespace LeetCode.Problems;
public class _1351_CountNegativeNumbersSortedMatrix
{
    //Binary Search
    public int CountNegatives(int[][] grid)
    {
        throw new NotImplementedException();
    }
    //Brute Force
    public int CountNegatives_2(int[][] grid)
    {
        int negativeCount = 0;

        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[i].Length; j++)
            {
                if (grid[i][j] < 0) negativeCount++;
            }
        }
        return negativeCount;
    }
}

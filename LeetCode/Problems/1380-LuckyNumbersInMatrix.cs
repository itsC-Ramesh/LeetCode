namespace LeetCode.Problems;
public class _1380_LuckyNumbersInMatrix
{
    //Problem: https://leetcode.com/problems/lucky-numbers-in-a-matrix/
    //Solution: https://leetcode.com/problems/lucky-numbers-in-a-matrix/submissions/1062156231/
    public IList<int> LuckyNumbers(int[][] matrix)
    {
        int rows = matrix.Length;
        int cols = matrix[0].Length;

        int[] rowMin = new int[rows];
        Array.Fill(rowMin, int.MaxValue);
        int[] colMax = new int[cols];


        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                rowMin[i] = Math.Min(rowMin[i], matrix[i][j]);
                colMax[j] = Math.Max(colMax[j], matrix[i][j]);
            }
        }

        var luckyNumbers = new List<int>();

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (matrix[i][j] == rowMin[i] && matrix[i][j] == colMax[j])
                    luckyNumbers.Add(matrix[i][j]);
            }
        }
        return luckyNumbers;
    }

}

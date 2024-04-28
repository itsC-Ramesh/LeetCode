using LeetCode.Problems;

namespace LeetCode.Test.Misc;
public class _1380_LuckyNumbersInMatrix_Test
{
    private _1380_LuckyNumbersInMatrix solution;

    [SetUp]
    public void SetUp()
    {
        solution = new _1380_LuckyNumbersInMatrix();
    }

    [Test]
    public void Test1()
    {
        // Arrange
        int[][] matrix = new int[][]
        {
            new int[] { 3, 7, 8 },
            new int[] { 9, 11, 13 },
            new int[] { 15, 16, 17 }
        };

        // Act
        IList<int> result = solution.LuckyNumbers(matrix);

        // Assert
        CollectionAssert.AreEqual(new int[] { 15 }, result);
    }

    [Test]
    public void Test2()
    {
        // Arrange
        int[][] matrix = new int[][]
        {
            new int[] { 1, 10, 4, 2 },
            new int[] { 9, 3, 8, 7 },
            new int[] { 15, 16, 17, 12 }
        };

        // Act
        IList<int> result = solution.LuckyNumbers(matrix);

        // Assert
        CollectionAssert.AreEqual(new int[] { 12 }, result);
    }

    [Test]
    public void Test3()
    {
        // Arrange
        int[][] matrix = new int[][]
        {
            new int[] { 7, 8 },
            new int[] { 1, 2 }
        };

        // Act
        IList<int> result = solution.LuckyNumbers(matrix);

        // Assert
        CollectionAssert.AreEqual(new int[] { 7 }, result);
    }
}

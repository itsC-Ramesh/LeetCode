using LeetCode.Problems;

namespace LeetCode.Test._1301_1400;
[TestFixture]
public class _1351_CountNegativeNumbersSortedMatrix_Test
{
    private _1351_CountNegativeNumbersSortedMatrix solution;

    [SetUp]
    public void Setup()
    {
        solution = new _1351_CountNegativeNumbersSortedMatrix();
    }

    [Test]
    public void CountNegatives_1()
    {
        int[][] matrix1 = new int[][] {
            new int[] { 4, 3, 2, -1 },
            new int[] { 3, 2, 1, -1 },
            new int[] { 1, 1, -1, -2 },
            new int[] { -1, -1, -2, -3 }
        };
        Assert.That(solution.CountNegatives(matrix1), Is.EqualTo(8));
    }

    [Test]
    public void CountNegatives_2()
    {
        int[][] matrix2 = new int[][] {
            new int[] { 3, 2 },
            new int[] { 1, 0 }
        };
        Assert.That(solution.CountNegatives(matrix2), Is.EqualTo(0));
    }

    [Test]
    public void CountNegatives_3()
    {
        int[][] matrix3 = new int[][] {
            new int[] { 1, -1 },
            new int[] { -1, -1 }
        };
        Assert.That(solution.CountNegatives(matrix3), Is.EqualTo(3));
    }

    [Test]
    public void CountNegatives_4()
    {
        int[][] matrix4 = new int[][] { };
        Assert.That(solution.CountNegatives(matrix4), Is.EqualTo(0));
    }
}

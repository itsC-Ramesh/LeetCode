using LeetCode.Problems;

namespace LeetCode.Test.Misc;
[TestFixture]
public class _1854_MaximumPopulationYear_Test
{
    private _1854_MaximumPopulationYear solution;

    [SetUp]
    public void SetUp()
    {
        solution = new _1854_MaximumPopulationYear();
    }

    [Test]
    public void Test1()
    {
        // Arrange
        int[][] logs = new int[][] {
            new int[] { 1993, 1999 },
            new int[] { 2000, 2010 },
            new int[] { 1990, 2001 }
        };

        // Act
        int result = solution.MaximumPopulationYear(logs);

        // Assert
        Assert.That(result, Is.EqualTo(1993));
    }

    [Test]
    public void Test2()
    {
        // Arrange
        int[][] logs = new int[][] {
            new int[] { 1950, 1961 },
            new int[] { 1960, 1971 },
            new int[] { 1970, 1981 }
        };

        // Act
        int result = solution.MaximumPopulationYear(logs);

        // Assert
        Assert.That(result, Is.EqualTo(1960));
    }

    [Test]
    public void Test3()
    {
        // Arrange
        int[][] logs = new int[][] {
            new int[] { 1955, 1961 },
            new int[] { 1960, 1971 },
            new int[] { 1970, 1981 }
        };

        // Act
        int result = solution.MaximumPopulationYear(logs);

        // Assert
        Assert.That(result, Is.EqualTo(1960));
    }

    [Test]
    public void Test4()
    {
        // Arrange
        int[][] logs = new int[][] {
                new int[] {2008,2026},
                new int[] {2004,2008},
                new int[] {2034,2035},
                new int[] {1999,2050},
                new int[] {2049,2050},
                new int[] {2011,2035},
                new int[] {1966,2033},
                new int[] {2044,2049}
        };

        // Act
        int result = solution.MaximumPopulationYear(logs);

        // Assert
        Assert.That(result, Is.EqualTo(2011));
    }
}


using LeetCode.Problems;

namespace LeetCode.Test.Misc;

[TestFixture]
public class _1732_FindHighestAltitude_Test
{
    private _1732_LargestAltitude solution;

    [SetUp]
    public void SetUp()
    {
        solution = new _1732_LargestAltitude();
    }

    [Test]
    public void Test1()
    {
        // Arrange
        int[] gain = { -5, 1, 5, 0, -7 };

        // Act
        int result = solution.LargestAltitude(gain);

        // Assert
        Assert.That(result, Is.EqualTo(1));
    }

    [Test]
    public void Test2()
    {
        // Arrange
        int[] gain = { -4, -3, -2, -1, 4, 3, 2 };

        // Act
        int result = solution.LargestAltitude(gain);

        // Assert
        Assert.That(result, Is.EqualTo(0));
    }

    [Test]
    public void Test_1_1()
    {
        // Arrange
        int[] gain = { -5, 1, 5, 0, -7 };

        // Act
        int result = solution.LargestAltitude_1(gain);

        // Assert
        Assert.That(result, Is.EqualTo(1));
    }

    [Test]
    public void Test_1_2()
    {
        // Arrange
        int[] gain = { -4, -3, -2, -1, 4, 3, 2 };

        // Act
        int result = solution.LargestAltitude_1(gain);

        // Assert
        Assert.That(result, Is.EqualTo(0));
    }
}

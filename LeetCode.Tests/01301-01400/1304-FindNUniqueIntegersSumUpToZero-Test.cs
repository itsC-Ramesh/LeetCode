using LeetCode.Problems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Test.Misc;
public class _1304_FindNUniqueIntegersSumUpToZero_Test
{
    private _1304_FindNUniqueIntegersSumToZero solution;

    [SetUp]
    public void SetUp()
    {
        solution = new _1304_FindNUniqueIntegersSumToZero();
    }

    [Test]
    public void Test1()
    {
        // Arrange
        int n = 5;

        // Act
        int[] result = solution.SumZero(n);

        // Assert
        Assert.That(result.Sum(), Is.EqualTo(0)); // Verify that the sum is zero
        CollectionAssert.AreEqual(new int[] { -2, -1, 0, 1, 2 }, result); // Verify unique integers
    }

    [Test]
    public void Test2()
    {
        // Arrange
        int n = 3;

        // Act
        int[] result = solution.SumZero(n);

        // Assert
        Assert.That(result.Sum(), Is.EqualTo(0)); // Verify that the sum is zero
        CollectionAssert.AreEqual(new int[] { -1, 0, 1 }, result); // Verify unique integers
    }

    [Test]
    public void Test3()
    {
        // Arrange
        int n = 1;

        // Act
        int[] result = solution.SumZero(n);

        // Assert
        Assert.That(result.Sum(), Is.EqualTo(0)); // Verify that the sum is zero
        CollectionAssert.AreEqual(new int[] { 0 }, result); // Verify unique integers
    }
    [Test]
    public void Test4()
    {
        // Arrange
        int n = 4;

        // Act
        int[] result = solution.SumZero(n);

        // Assert
        Assert.That(result.Sum(), Is.EqualTo(0)); // Verify that the sum is zero
        CollectionAssert.AreEqual(new int[] { -2, -1, 1, 2 }, result); // Verify unique integers
    }
}

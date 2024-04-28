using LeetCode.Problems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Test.Misc;
public class _905_SortArrayByParity_Test
{
    private _905_SortArrayByParity solution;

    [SetUp]
    public void SetUp()
    {
        solution = new _905_SortArrayByParity();
    }

    [Test]
    public void Test1()
    {
        // Arrange
        int[] A = new int[] { 3, 1, 2, 4 };

        // Act
        int[] result = solution.SortArrayByParity(A);

        // Assert
        Assert.IsTrue(result.SequenceEqual(new int[] { 4, 2, 1, 3 }), "The order of elements should be maintained.");
    }

    [Test]
    public void Test2()
    {
        // Arrange
        int[] A = new int[] { 2, 4, 6, 8 };

        // Act
        int[] result = solution.SortArrayByParity(A);

        // Assert
        Assert.IsTrue(result.SequenceEqual(new int[] { 2, 4, 6, 8 }), "The order of elements should be maintained.");
    }

    [Test]
    public void Test3()
    {
        // Arrange
        int[] A = new int[] { 1, 3, 5, 7 };

        // Act
        int[] result = solution.SortArrayByParity(A);

        // Assert
        Assert.IsTrue(result.SequenceEqual(new int[] { 1, 3, 5, 7 }), "The order of elements should be maintained.");
    }
}

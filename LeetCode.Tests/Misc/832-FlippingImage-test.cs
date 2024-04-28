using LeetCode.Problems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Test.Misc;
[TestFixture]
internal class _832_FlippingImage_Test
{
    private _832_FlippingImage solution;
    public _832_FlippingImage_Test()
    {
        solution = new _832_FlippingImage();
    }

    [Test]
    public void FlipAndInvertImage_1()
    {
        // Arrange
        int[][] A = {
            new int[] { 1, 1, 0 },
            new int[] { 1, 0, 1 },
            new int[] { 0, 0, 0 }
        };

        // Act
        int[][] result = solution.FlipAndInvertImage(A);

        // Assert
        int[][] expected = {
            new int[] { 1, 0, 0 },
            new int[] { 0, 1, 0 },
            new int[] { 1, 1, 1 }
        };

        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void FlipAndInvertImage_2()
    {
        // Arrange
        int[][] image = new int[][] {
            new int[] { 1, 1, 0, 0 },
            new int[] { 1, 0, 0, 1 },
            new int[] { 0, 1, 1, 1 },
            new int[] { 1, 0, 1, 0 }
        };

        // Act
        int[][] result = solution.FlipAndInvertImage(image);

        // Assert
        int[][] expected = new int[][] {
            new int[] { 1, 1, 0, 0 },
            new int[] { 0, 1, 1, 0 },
            new int[] { 0, 0, 0, 1 },
            new int[] { 1, 0, 1, 0 }
        };

        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void FlipAndInvertImage_1_1()
    {
        // Arrange
        int[][] A = {
            new int[] { 1, 1, 0 },
            new int[] { 1, 0, 1 },
            new int[] { 0, 0, 0 }
        };

        // Act
        int[][] result = solution.FlipAndInvertImage_1(A);

        // Assert
        int[][] expected = {
            new int[] { 1, 0, 0 },
            new int[] { 0, 1, 0 },
            new int[] { 1, 1, 1 }
        };

        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void FlipAndInvertImage_1_2()
    {
        // Arrange
        int[][] image = new int[][] {
            new int[] { 1, 1, 0, 0 },
            new int[] { 1, 0, 0, 1 },
            new int[] { 0, 1, 1, 1 },
            new int[] { 1, 0, 1, 0 }
        };

        // Act
        int[][] result = solution.FlipAndInvertImage_1(image);

        // Assert
        int[][] expected = new int[][] {
            new int[] { 1, 1, 0, 0 },
            new int[] { 0, 1, 1, 0 },
            new int[] { 0, 0, 0, 1 },
            new int[] { 1, 0, 1, 0 }
        };

        CollectionAssert.AreEqual(expected, result);
    }
}

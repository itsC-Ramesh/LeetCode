using LeetCode.Problems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Test.Misc;
[TestFixture]
public class _1295_FindNumbersWithEvenNumberDigits_Test
{
    private _1295_FindNumbersWithEvenNumberDigits solution;
    public _1295_FindNumbersWithEvenNumberDigits_Test()
    {
        solution = new _1295_FindNumbersWithEvenNumberDigits();
    }

    [Test]
    public void FindNumbers_1()
    {
        // Arrange
        int[] nums = { 12, 345, 2, 6, 7896 };

        // Act
        int result = solution.FindNumbers(nums);

        // Assert
        Assert.That(result, Is.EqualTo(2));
    }

    [Test]
    public void FindNumbers_2()
    {
        // Arrange
        int[] nums = { 555, 901, 482, 1771 };

        // Act
        int result = solution.FindNumbers(nums);

        // Assert
        Assert.That(result, Is.EqualTo(1));
    }

    [Test]
    public void FindNumbers_3()
    {
        // Arrange
        int[] nums = { 123, 456, 789 };

        // Act
        int result = solution.FindNumbers(nums);

        // Assert
        Assert.That(result, Is.EqualTo(0));
    }

    [Test]
    public void FindNumbers_4()
    {
        // Arrange
        int[] nums = { 12, 345, 2, 6, 7896 };

        // Act
        int result = solution.FindNumbers(nums);

        // Assert
        Assert.That(result, Is.EqualTo(2));
    }
    [Test]
    public void FindNumbers_5()
    {
        // Arrange
        int[] nums = { 100000 };

        // Act
        int result = solution.FindNumbers(nums);

        // Assert
        Assert.That(result, Is.EqualTo(1));
    }

}

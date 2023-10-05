using LeetCode.Problems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Test.Misc;
public class _33_SearchInRotatedSortedArray_Test
{
    private _33_SearchInRotatedSortedArray solution;

    [SetUp]
    public void Setup()
    {
        solution = new _33_SearchInRotatedSortedArray();
    }

    [Test]
    public void Test1()
    {
        int[] nums = { 4, 5, 6, 7, 0, 1, 2 };
        int target = 0;
        int expected = 4;
        Assert.That(solution.Search(nums, target), Is.EqualTo(expected));
    }

    [Test]
    public void Test2()
    {
        int[] nums = { 4, 5, 6, 7, 0, 1, 2 };
        int target = 3;
        int expected = -1;
        Assert.That(solution.Search(nums, target), Is.EqualTo(expected));
    }

    [Test]
    public void Test3()
    {
        int[] nums = { 1 };
        int target = 0;
        int expected = -1;
        Assert.That(solution.Search(nums, target), Is.EqualTo(expected));
    }

    [Test]
    public void Test4()
    {
        int[] nums = { 3, 1 };
        int target = 1;
        int expected = 1;
        Assert.That(solution.Search(nums, target), Is.EqualTo(expected));
    }

    [Test]
    public void Test5()
    {
        int[] nums = { 5, 1, 3 };
        int target = 3;
        int expected = 2;
        Assert.That(solution.Search(nums, target), Is.EqualTo(expected));
    }

    [Test]
    public void Test6()
    {
        int[] nums = { 5, 1, 3 };
        int target = 5;
        int expected = 0;
        Assert.That(solution.Search(nums, target), Is.EqualTo(expected));
    }
}

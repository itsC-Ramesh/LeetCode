using LeetCode.Problems;

namespace LeetCode.Test.Misc;
[TestFixture]
public class _34_FindFirstAndLastPositionOfElementInSortedArray_Test
{
    private _34_FindFirstAndLastPositionOfElementInSortedArray solution;
    [SetUp]
    public void Setup()
    {
        solution = new _34_FindFirstAndLastPositionOfElementInSortedArray();
    }

    [Test]
    public void SearchRange_1()
    {
        int[] nums = { 5, 7, 7, 8, 8, 8, 10 };
        int target = 8;
        int[] expected = { 3, 5 };
        Assert.That(solution.SearchRange(nums, target), Is.EqualTo(expected));
    }

    [Test]
    public void SearchRange_2()
    {
        int[] nums = { 5, 7, 7, 8, 8, 8, 10 };
        int target = 6;
        int[] expected = { -1, -1 };
        Assert.That(solution.SearchRange(nums, target), Is.EqualTo(expected));
    }

    [Test]
    public void SearchRange_3()
    {
        int[] nums = { 1, 2, 3, 4, 5 };
        int target = 3;
        int[] expected = { 2, 2 };
        Assert.That(solution.SearchRange(nums, target), Is.EqualTo(expected));
    }

    [Test]
    public void SearchRange_4()
    {
        int[] nums = { 1, 2, 2, 2, 3, 4, 5, 5, 5 };
        int target = 5;
        int[] expected = { 6, 8 };
        Assert.That(solution.SearchRange(nums, target), Is.EqualTo(expected));
    }

    [Test]
    public void SearchRange_5()
    {
        int[] nums = { 1 };
        int target = 1;
        int[] expected = { 0, 0 };
        Assert.That(solution.SearchRange(nums, target), Is.EqualTo(expected));
    }

}

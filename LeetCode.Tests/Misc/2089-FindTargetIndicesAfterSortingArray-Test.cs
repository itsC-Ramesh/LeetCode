using LeetCode.Problems;

namespace LeetCode.Test.Misc;
[TestFixture]
public class _2089_FindTargetIndicesAfterSortingArray_Test
{
    private _2089_FindTargetIndicesAfterSortingArray solution;

    [SetUp]
    public void Setup()
    {
        solution = new _2089_FindTargetIndicesAfterSortingArray();
    }

    [Test]
    public void TargetIndices_1()
    {
        int[] nums = { 1, 2, 5, 2, 3 };
        int target = 2;
        List<int> expected = new List<int>() { 1, 2 };
        var result = solution.TargetIndices(nums, target);
        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void TargetIndices_2()
    {
        int[] nums = { 1, 2, 5, 2, 3 };
        int target = 3;
        List<int> expected = new List<int>() { 3 };
        var result = solution.TargetIndices(nums, target);
        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void TargetIndices_3()
    {
        int[] nums = { 1, 2, 5, 2, 3 };
        int target = 5;
        List<int> expected = new List<int>() { 4 };
        var result = solution.TargetIndices(nums, target);
        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void TargetIndices_4()
    {
        int[] nums = { 81, 7, 87, 77, 45, 70, 4, 20, 41, 8, 74, 88, 71, 28, 74, 41, 12, 16, 99, 13, 69, 34, 57, 74, 76, 88, 15, 1, 64, 10, 28, 89, 25, 12, 7, 69, 81, 39, 58, 79, 28, 27, 7, 87, 1, 66, 50, 93, 30, 76, 34, 22, 20, 89, 35, 42, 90, 22, 54, 50, 10, 20, 24, 44, 87 };
        int target = 1;
        List<int> expected = new List<int>() { 0, 1 };
        var result = solution.TargetIndices(nums, target);
        CollectionAssert.AreEqual(expected, result);
    }

    // 
    [Test]
    public void TargetIndices_1_1()
    {
        int[] nums = { 1, 2, 5, 2, 3 };
        int target = 2;
        List<int> expected = new List<int>() { 1, 2 };
        var result = solution.TargetIndices_1(nums, target);
        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void TargetIndices_1_2()
    {
        int[] nums = { 1, 2, 5, 2, 3 };
        int target = 3;
        List<int> expected = new List<int>() { 3 };
        var result = solution.TargetIndices_1(nums, target);
        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void TargetIndices_1_3()
    {
        int[] nums = { 1, 2, 5, 2, 3 };
        int target = 5;
        List<int> expected = new List<int>() { 4 };
        var result = solution.TargetIndices_1(nums, target);
        CollectionAssert.AreEqual(expected, result);
    }
}

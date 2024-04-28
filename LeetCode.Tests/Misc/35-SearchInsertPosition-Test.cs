using LeetCode.Problems;

namespace LeetCode.Test.Misc;
[TestFixture]
public class _35_SearchInsertPosition_Test
{
    private _35_SearchInsertPosition solution;

    [SetUp]
    public void Setup()
    {
        solution = new _35_SearchInsertPosition();
    }

    [Test]
    public void Test1()
    {
        int[] nums = { 1, 3, 5, 6 };
        int target = 5;
        int expected = 2;
        int result = solution.SearchInsert(nums, target);
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test2()
    {
        int[] nums = { 1, 3, 5, 6 };
        int target = 2;
        int expected = 1;
        int result = solution.SearchInsert(nums, target);
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test3()
    {
        int[] nums = { 1, 3, 5, 6 };
        int target = 7;
        int expected = 4;
        int result = solution.SearchInsert(nums, target);
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test4()
    {
        int[] nums = { 1, 3, 5, 6 };
        int target = 0;
        int expected = 0;
        int result = solution.SearchInsert(nums, target);
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test5()
    {
        int[] nums = { };
        int target = 5;
        int expected = 0;
        int result = solution.SearchInsert(nums, target);
        Assert.That(result, Is.EqualTo(expected));
    }
}

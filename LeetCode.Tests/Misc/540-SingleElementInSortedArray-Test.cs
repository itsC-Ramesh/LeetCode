using LeetCode.Problems;

namespace LeetCode.Test.Misc;
[TestFixture]
public class _540_SingleElementInSortedArray_Test
{
    private _540_SingleElementInSortedArray solution;

    [SetUp]
    public void Setup()
    {
        solution = new _540_SingleElementInSortedArray();
    }

    [Test]
    public void SingleNonDuplicate_1()
    {
        int[] nums = { 1, 1, 2, 3, 3, 4, 4, 8, 8 };
        int expected = 2;
        int result = solution.SingleNonDuplicate(nums);
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void SingleNonDuplicate_2()
    {
        int[] nums = { 3, 3, 7, 7, 10, 11, 11 };
        int expected = 10;
        int result = solution.SingleNonDuplicate(nums);
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void SingleNonDuplicate_3()
    {
        int[] nums = { 1, 1, 2 };
        int expected = 2;
        int result = solution.SingleNonDuplicate(nums);
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void SingleNonDuplicate_4()
    {
        int[] nums = { 1 };
        int expected = 1;
        int result = solution.SingleNonDuplicate(nums);
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void SingleNonDuplicate_1_1()
    {
        int[] nums = { 1, 1, 2, 3, 3, 4, 4, 8, 8 };
        int expected = 2;
        int result = solution.SingleNonDuplicate_1(nums);
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void SingleNonDuplicate_1_2()
    {
        int[] nums = { 3, 3, 7, 7, 10, 11, 11 };
        int expected = 10;
        int result = solution.SingleNonDuplicate_1(nums);
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void SingleNonDuplicate_1_3()
    {
        int[] nums = { 1, 1, 2 };
        int expected = 2;
        int result = solution.SingleNonDuplicate_1(nums);
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void SingleNonDuplicate_1_4()
    {
        int[] nums = { 1 };
        int expected = 1;
        int result = solution.SingleNonDuplicate_1(nums);
        Assert.That(result, Is.EqualTo(expected));
    }
}

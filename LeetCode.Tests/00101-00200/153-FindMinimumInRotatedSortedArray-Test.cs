using LeetCode.Problems;

namespace LeetCode.Test._00101_00200;
[TestFixture]
public class _153_FindMinimumInRotatedSortedArray_Test
{
    private _153_FindMinimumInRotatedSortedArray solution;

    [SetUp]
    public void Setup()
    {
        solution = new _153_FindMinimumInRotatedSortedArray();
    }

    [Test]
    public void FindMin_1()
    {
        int[] nums = { 3, 4, 5, 1, 2 };
        int expected = 1;
        int result = solution.FindMin(nums);
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void FindMin_2()
    {
        int[] nums = { 4, 5, 6, 7, 0, 1, 2 };
        int expected = 0;
        int result = solution.FindMin(nums);
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void FindMin_3()
    {
        int[] nums = { 11, 13, 15, 17 };
        int expected = 11;
        int result = solution.FindMin(nums);
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void FindMin_4()
    {
        int[] nums = { 2, 1 };
        int expected = 1;
        int result = solution.FindMin(nums);
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void FindMin_5()
    {
        int[] nums = { 3, 1, 2 };
        int expected = 1;
        int result = solution.FindMin(nums);
        Assert.That(result, Is.EqualTo(expected));
    }


    [Test]
    public void FindMin_1_1()
    {
        int[] nums = { 3, 4, 5, 1, 2 };
        int expected = 1;
        int result = solution.FindMin_1(nums);
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void FindMin_1_2()
    {
        int[] nums = { 4, 5, 6, 7, 0, 1, 2 };
        int expected = 0;
        int result = solution.FindMin_1(nums);
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void FindMin_1_3()
    {
        int[] nums = { 11, 13, 15, 17 };
        int expected = 11;
        int result = solution.FindMin_1(nums);
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void FindMin_1_4()
    {
        int[] nums = { 2, 1 };
        int expected = 1;
        int result = solution.FindMin_1(nums);
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void FindMin_1_5()
    {
        int[] nums = { 3, 1, 2 };
        int expected = 1;
        int result = solution.FindMin_1(nums);
        Assert.That(result, Is.EqualTo(expected));
    }
}

using LeetCode.Problems;

namespace LeetCode.Test.Misc;
public class _162_FindPeakElement_Test
{
    private _162_FindPeakElement solution;
    [SetUp]
    public void Setup()
    {
        solution = new _162_FindPeakElement();
    }

    [Test]
    public void Test1()
    {
        int[] nums = { 1, 2, 3, 1 };
        int expected = 2; // Peak element is 3
        int result = solution.FindPeakElement(nums);
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test2()
    {
        int[] nums = { 1, 2, 1, 3, 5, 6, 4 };
        int expected = 5; // Peak element is 6
        int result = solution.FindPeakElement(nums);
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test3()
    {
        int[] nums = { 1 };
        int expected = 0; // There's only one element, which is a peak
        int result = solution.FindPeakElement(nums);
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test4()
    {
        int[] nums = { 1, 2, 3, 4, 5 };
        int expected = 4; // Peak element is 5
        int result = solution.FindPeakElement(nums);
        Assert.That(result, Is.EqualTo(expected));
    }
}

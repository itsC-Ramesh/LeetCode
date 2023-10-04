using LeetCode.Problems;

namespace LeetCode.Test.Misc;
[TestFixture]
public class _852_PeakIndexInMountainArray_Test
{
    private _852_PeakIndexInMountainArray solution;

    [SetUp]
    public void Setup()
    {
        solution = new _852_PeakIndexInMountainArray();
    }

    [Test]
    public void Test1()
    {
        int[] arr = { 0, 1, 0 };
        int expected = 1;
        int result = solution.PeakIndexInMountainArray(arr);
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test2()
    {
        int[] arr = { 0, 2, 1, 0 };
        int expected = 1;
        int result = solution.PeakIndexInMountainArray(arr);
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test3()
    {
        int[] arr = { 0, 1, 2, 3, 4, 3 };
        int expected = 4;
        int result = solution.PeakIndexInMountainArray(arr);
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test4()
    {
        int[] arr = { 3, 5, 4 };
        int expected = 1;
        int result = solution.PeakIndexInMountainArray(arr);
        Assert.That(result, Is.EqualTo(expected));
    }
}

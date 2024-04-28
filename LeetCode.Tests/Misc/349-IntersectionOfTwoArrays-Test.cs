using LeetCode.Problems;

namespace LeetCode.Test.Misc;
[TestFixture]
public class _349_IntersectionOfTwoArrays_Test
{
    private _349_IntersectionOfTwoArrays solution;

    [SetUp]
    public void Setup()
    {
        solution = new _349_IntersectionOfTwoArrays();
    }

    [Test]
    public void Test1()
    {
        int[] nums1 = { 1, 2, 2, 1 };
        int[] nums2 = { 2, 2 };
        int[] expected = { 2 };
        int[] result = solution.Intersection(nums1, nums2);
        Assert.That(result.OrderBy(x => x), Is.EqualTo(expected.OrderBy(x => x)));
    }

    [Test]
    public void Test2()
    {
        int[] nums1 = { 4, 9, 5 };
        int[] nums2 = { 9, 4, 9, 8, 4 };
        int[] expected = { 9, 4 };
        int[] result = solution.Intersection(nums1, nums2);
        Assert.That(result.OrderBy(x => x), Is.EqualTo(expected.OrderBy(x => x)));
    }

    [Test]
    public void Test3()
    {
        int[] nums1 = { 1, 2, 3 };
        int[] nums2 = { 4, 5, 6 };
        int[] expected = { };
        int[] result = solution.Intersection(nums1, nums2);
        Assert.That(result.OrderBy(x => x), Is.EqualTo(expected.OrderBy(x => x)));
    }
}

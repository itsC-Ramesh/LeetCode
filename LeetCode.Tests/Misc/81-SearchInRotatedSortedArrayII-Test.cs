namespace LeetCode.Problems;
[TestFixture]
public class _81_SearchInRotatedSortedArrayII_Test
{
    private _81_SearchInRotatedSortedArrayII solution;

    [SetUp]
    public void Setup()
    {
        solution = new _81_SearchInRotatedSortedArrayII();
    }

    [Test]
    public void Search_1()
    {
        int[] nums = { 2, 5, 6, 0, 0, 1, 2 };
        int target = 0;
        bool expected = true;
        bool result = solution.Search(nums, target);
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Search_2()
    {
        int[] nums = { 2, 5, 6, 0, 0, 1, 2 };
        int target = 3;
        bool expected = false;
        bool result = solution.Search(nums, target);
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Search_3()
    {
        int[] nums = { 1 };
        int target = 0;
        bool expected = false;
        bool result = solution.Search(nums, target);
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Search_4()
    {
        int[] nums = { 1, 0, 1, 1, 1 };
        int target = 0;
        bool expected = true;
        bool result = solution.Search(nums, target);
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Search_5()
    {
        int[] nums = { 1, 1, 1, 1, 1, 1, 1, 1, 1, 13, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
        int target = 13;
        bool expected = true;
        bool result = solution.Search(nums, target);
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Search_6()
    {
        int[] nums = { 3, 1 };
        int target = 1;
        bool expected = true;
        bool result = solution.Search(nums, target);
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Search_7()
    {
        int[] nums = { 2, 2, 2, 0, 2, 2 };
        int target = 0;
        bool expected = true;
        bool result = solution.Search(nums, target);
        Assert.That(result, Is.EqualTo(expected));
    }
}

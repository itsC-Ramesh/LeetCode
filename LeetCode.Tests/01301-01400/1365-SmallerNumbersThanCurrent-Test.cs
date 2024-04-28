using LeetCode.Problems;
using LeetCodeTests;

namespace LeetCode.Test._1301_1400;
[TestFixture]
public class _1365_SmallerNumbersThanCurrent_Test
{
    private _1365_SmallerNumbersThanCurrent solution;
    public _1365_SmallerNumbersThanCurrent_Test()
    {
        solution = new _1365_SmallerNumbersThanCurrent();
    }

    [Test]
    public void SmallerNumbersThanCurrent_1()
    {
        var result = solution.SmallerNumbersThanCurrent(new int[] { 8, 1, 2, 2, 3 });
        AssertHelper.AssertArray(new int[] { 4, 0, 1, 1, 3 }, result);
    }

    [Test]
    public void SmallerNumbersThanCurrent_2()
    {
        var result = solution.SmallerNumbersThanCurrent(new int[] { 6, 5, 4, 8 });
        AssertHelper.AssertArray(new int[] { 2, 1, 0, 3 }, result);
    }

    [Test]
    public void SmallerNumbersThanCurrent_3()
    {
        var result = solution.SmallerNumbersThanCurrent(new int[] { 7, 7, 7, 7 });
        AssertHelper.AssertArray(new int[] { 0, 0, 0, 0 }, result);
    }


    [Test]
    public void SmallerNumbersThanCurrent_4()
    {
        var result = solution.SmallerNumbersThanCurrent(new int[] { 5, 0, 10, 0, 10, 6 });
        AssertHelper.AssertArray(new int[] { 2, 0, 4, 0, 4, 3 }, result);
    }

    [Test]
    public void SmallerNumbersThanCurrent_1_1()
    {
        var result = solution.SmallerNumbersThanCurrent_1(new int[] { 8, 1, 2, 2, 3 });
        AssertHelper.AssertArray(new int[] { 4, 0, 1, 1, 3 }, result);
    }

    [Test]
    public void SmallerNumbersThanCurrent_1_2()
    {
        var result = solution.SmallerNumbersThanCurrent_1(new int[] { 6, 5, 4, 8 });
        AssertHelper.AssertArray(new int[] { 2, 1, 0, 3 }, result);
    }

    [Test]
    public void SmallerNumbersThanCurrent_1_3()
    {
        var result = solution.SmallerNumbersThanCurrent_1(new int[] { 7, 7, 7, 7 });
        AssertHelper.AssertArray(new int[] { 0, 0, 0, 0 }, result);
    }


    [Test]
    public void SmallerNumbersThanCurrent_1_4()
    {
        var result = solution.SmallerNumbersThanCurrent_1(new int[] { 5, 0, 10, 0, 10, 6 });
        AssertHelper.AssertArray(new int[] { 2, 0, 4, 0, 4, 3 }, result);
    }

}

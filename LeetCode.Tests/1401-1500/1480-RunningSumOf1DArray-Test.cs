using LeetCode.Problems;
using LeetCodeTests;

namespace LeetCode.Test._1401_1500;
[TestFixture]
public class _1480_RunningSumOf1DArray_Test
{
    private _1480_RunningSumOfArray solution;
    public _1480_RunningSumOf1DArray_Test()
    {
        solution = new _1480_RunningSumOfArray();
    }

    [Test]
    public void RunningSum_3_1()
    {
        var result = solution.RunningSum_3(new int[] { 1, 2, 3, 4 });
        AssertHelper.AssertArray(new int[] { 1, 3, 6, 10 }, result);
    }

    [Test]
    public void RunningSum_3_2()
    {
        var result = solution.RunningSum_3(new int[] { 1, 1, 1, 1, 1 });
        AssertHelper.AssertArray(new int[] { 1, 2, 3, 4, 5 }, result);
    }

    [Test]
    public void RunningSum_3_3()
    {
        var result = solution.RunningSum_3(new int[] { 3, 1, 2, 10, 1 });
        AssertHelper.AssertArray(new int[] { 3, 4, 6, 16, 17 }, result);
    }


}

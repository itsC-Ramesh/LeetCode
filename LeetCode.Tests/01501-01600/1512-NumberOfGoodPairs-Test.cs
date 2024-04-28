using LeetCode.Problems;

namespace LeetCode.Test._1501_1600;
internal class _1512_NumberOfGoodPairs_Test
{
    private _1512_NumberOfGoodPairs solution;
    public _1512_NumberOfGoodPairs_Test()
    {
        solution = new _1512_NumberOfGoodPairs();
    }

    [Test]
    public void NumIdenticalPairs_1()
    {
        var result = solution.NumIdenticalPairs(new int[] { 1, 2, 3, 1, 1, 3 });
        Assert.That(result, Is.EqualTo(4));
    }

    [Test]
    public void NumIdenticalPairs_2()
    {
        var result = solution.NumIdenticalPairs(new int[] { 1, 1, 1, 1 });
        Assert.That(result, Is.EqualTo(6));
    }

    [Test]
    public void NumIdenticalPairs_3()
    {
        var result = solution.NumIdenticalPairs(new int[] { 1, 2, 3 });
        Assert.That(result, Is.EqualTo(0));
    }

    [Test]
    public void NumIdenticalPairs_1_1()
    {
        var result = solution.NumIdenticalPairs_1(new int[] { 1, 2, 3, 1, 1, 3 });
        Assert.That(result, Is.EqualTo(4));
    }

    [Test]
    public void NumIdenticalPairs_1_2()
    {
        var result = solution.NumIdenticalPairs_1(new int[] { 1, 1, 1, 1 });
        Assert.That(result, Is.EqualTo(6));
    }

    [Test]
    public void NumIdenticalPairs_1_3()
    {
        var result = solution.NumIdenticalPairs_1(new int[] { 1, 2, 3 });
        Assert.That(result, Is.EqualTo(0));
    }
}

using LeetCode.Problems;

namespace LeetCodeTests._1401_1500;
[TestFixture]
internal class _1470_ShuffleTheArray_Test
{
    private _1470_ShuffleArray _solution;
    public _1470_ShuffleTheArray_Test()
    {
        _solution = new _1470_ShuffleArray();
    }

    [Test]
    public void Shuffle_1()
    {
        var result = _solution.Shuffle(new int[] { 2, 5, 1, 3, 4, 7 }, 3);
        AssertHelper.AssertArray(new int[] { 2, 3, 5, 4, 1, 7 }, result);
    }

    [Test]
    public void Shuffle_2()
    {
        var result = _solution.Shuffle(new int[] { 1, 2, 3, 4, 4, 3, 2, 1 }, 4);
        AssertHelper.AssertArray(new int[] { 1, 4, 2, 3, 3, 2, 4, 1 }, result);
    }

    [Test]
    public void Shuffle_3()
    {
        var result = _solution.Shuffle(new int[] { 1, 1, 2, 2 }, 2);
        AssertHelper.AssertArray(new int[] { 1, 2, 1, 2 }, result);
    }

}

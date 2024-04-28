using LeetCode.Problems;
using LeetCodeTests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Test._1401_1500;
[TestFixture]
internal class _1431_KidsWithCandies_Test
{
    private _1431_KidsWithCandies solution;

    public _1431_KidsWithCandies_Test()
    {
        solution = new _1431_KidsWithCandies();
    }

    [Test]
    public void KidsWithCandies_1()
    {
        var result = solution.KidsWithCandies(new int[] { 2, 3, 5, 1, 3 }, 3);
        AssertHelper.AssertList(new bool[] { true, true, true, false, true }, result);
    }

    [Test]
    public void KidsWithCandies_2()
    {
        var result = solution.KidsWithCandies(new int[] { 4, 2, 1, 1, 2 }, 1);
        AssertHelper.AssertList(new bool[] { true, false, false, false, false }, result);
    }

    [Test]
    public void KidsWithCandies_3()
    {
        var result = solution.KidsWithCandies(new int[] { 12, 1, 12 }, 10);
        AssertHelper.AssertList(new bool[] { true, false, true }, result);
    }
}

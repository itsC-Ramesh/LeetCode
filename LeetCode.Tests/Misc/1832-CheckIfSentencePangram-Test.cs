using LeetCode.Problems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Test.Misc;
[TestFixture]
public class _1832_CheckIfSentencePangram_Test
{
    private _1832_CheckIfSentencePangram solution;
    public _1832_CheckIfSentencePangram_Test()
    {
        solution = new _1832_CheckIfSentencePangram();
    }

    [Test]
    public void CheckIfPangram_1()
    {
        var result = solution.CheckIfPangram("thequickbrownfoxjumpsoverthelazydog");
        Assert.That(result, Is.True);
    }

    [Test]
    public void CheckIfPangram_2()
    {
        var result = solution.CheckIfPangram("leetcode");
        Assert.That(result, Is.False);
    }

}

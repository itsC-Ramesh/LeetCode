using LeetCode.Problems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Test.Misc;
[TestFixture]
public class _1773_CountItemsMatchingRule_Test
{
    private _1773_CountItemsMatchingRule solution;
    
    public _1773_CountItemsMatchingRule_Test()
    {
        solution=new _1773_CountItemsMatchingRule();
    }

    [Test]
    public void CountMatches_1()
    {
        // Arrange
        IList<IList<string>> items = new List<IList<string>>
        {
            new List<string> { "phone", "blue", "pixel" },
            new List<string> { "computer", "silver", "lenovo" },
            new List<string> { "phone", "gold", "iphone" }
        };
        string ruleKey = "color";
        string ruleValue = "silver";

        // Act
        int result = solution.CountMatches(items, ruleKey, ruleValue);

        // Assert
        Assert.That(result, Is.EqualTo(1));
    }

    [Test]
    public void CountMatches_2()
    {
        // Arrange
        IList<IList<string>> items = new List<IList<string>>
        {
            new List<string> { "phone", "blue", "pixel" },
            new List<string> { "computer", "silver", "lenovo" },
            new List<string> { "phone", "gold", "iphone" }
        };
        string ruleKey = "type";
        string ruleValue = "phone";

        // Act
        int result = solution.CountMatches(items, ruleKey, ruleValue);

        // Assert
        Assert.That(result, Is.EqualTo(2));
    }


}

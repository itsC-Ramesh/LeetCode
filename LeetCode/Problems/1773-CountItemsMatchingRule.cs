namespace LeetCode.Problems;
public class _1773_CountItemsMatchingRule
{
    //Problem: https://leetcode.com/problems/count-items-matching-a-rule/
    //Solution: https://leetcode.com/problems/count-items-matching-a-rule/submissions/1061367995/
    public int CountMatches(IList<IList<string>> items, string ruleKey, string ruleValue)
    {
        var indx = ruleKey == "color" ? 1 : 2;
        if (ruleKey == "type") indx = 0;

        var res = 0;

        foreach (var item in items) if (item[indx] == ruleValue) res++;

        return res;
    }


    //Solution: https://leetcode.com/problems/count-items-matching-a-rule/submissions/1061371409/
    public int CountMatches_1(IList<IList<string>> items, string ruleKey, string ruleValue)
    {
        int count = 0;

        foreach (var item in items)
        {
            switch (ruleKey)
            {
                case "type":
                    if (item[0] == ruleValue) count++;
                    break;
                case "color":
                    if (item[1] == ruleValue) count++;
                    break;
                case "name":
                    if (item[2] == ruleValue) count++;
                    break;
            }
        }

        return count;
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems;
internal class _389_FindTheDifference
{
    //Problem : https://leetcode.com/problems/find-the-difference/


    //Solution 1 : https://leetcode.com/problems/find-the-difference/submissions/1058787162/
    public char FindTheDifference(string s, string t)
    {
        var countDict = new Dictionary<char, int>();

        foreach (var c in s)
        {
            if (countDict.ContainsKey(c)) countDict[c]++;
            else countDict[c] = 0;
        }

        foreach (var c in t)
        {
            if (countDict.ContainsKey(c)) countDict[c]++;
            else countDict[c] = 0;
        }

        foreach (var item in countDict)
        {
            if (item.Value % 2 == 0) return item.Key;
        }

        return Char.MinValue;
    }


    //Solution 2 : https://leetcode.com/problems/find-the-difference/submissions/1058878528/
    public char FindTheDifference_2(string s, string t)
    {
        foreach (char c in t)
            if (t.Count(ch => ch == c) > s.Count(ch => ch == c))
                return c;
        return Char.MinValue;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems;
internal class _028_FindIndexofFirstOccurrenceInString
{
    //Problems:https://leetcode.com/problems/find-the-index-of-the-first-occurrence-in-a-string/

    //Solution:https://leetcode.com/problems/find-the-index-of-the-first-occurrence-in-a-string/submissions/1059825615/
    public int StrStr(string haystack, string needle)
    {
        int needleLength = needle.Length;

        for (int i = 0; i <= haystack.Length - needleLength; i++)
        {
            if (haystack.Substring(i, needleLength) == needle) return i;
        }
        return -1;

    }

    public int StrStr1(string haystack, string needle)
    {
        return haystack.IndexOf(needle);
    }
}

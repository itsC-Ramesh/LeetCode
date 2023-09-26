namespace LeetCode.Problems;
internal class _392_IsSubSequence
{
    // Problem : https://leetcode.com/problems/is-subsequence/
    // Solution : https://leetcode.com/problems/is-subsequence/submissions/1058963685/

    public bool IsSubsequence(string s, string t)
    {
        int foundAt = 0;
        int charsMatchedCount = s.Length;

        //if (s.Length == t.Length) return s == t;
        //if (t.Length < s.Length) return false;

        foreach (var item in s)
        {
            for (int i = foundAt; i < t.Length; i++)
            {
                if (item == t[i])
                {
                    charsMatchedCount--;
                    break;
                }
                foundAt++;
            }
            foundAt++;
        }
        return charsMatchedCount == 0;
    }

    // Soultion : https://leetcode.com/problems/is-subsequence/submissions/905167365/
    public bool IsSubsequence_2(string s, string t)
    {
        if (s.Length == 0) return true;
        int s_count = 0;

        for (int i = 0; i < t.Length; i++)
        {
            if (t[i] == s[s_count])
            {
                s_count++;
            };
            if (s_count == s.Length) return true;
        }
        return false;
    }

}

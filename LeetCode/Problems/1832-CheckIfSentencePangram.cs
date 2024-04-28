namespace LeetCode.Problems;
public class _1832_CheckIfSentencePangram
{
    //Problem: https://leetcode.com/problems/check-if-the-sentence-is-pangram/

    //Solution: https://leetcode.com/problems/check-if-the-sentence-is-pangram/submissions/1061356760/ 
    public bool CheckIfPangram(string sentence)
    {
        if (sentence.Length < 26) return false;

        var dict = new Dictionary<char, int>();
        foreach (var ch in sentence)
        {
            if (!dict.ContainsKey(ch)) dict[ch] = 0;
        }
        if (dict.Count < 26) return false;
        else return true;
    }
}

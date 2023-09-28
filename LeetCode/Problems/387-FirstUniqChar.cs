namespace LeetCode.Problems;
internal class _387_FirstUniqChar
{
    //Problem : https://leetcode.com/problems/first-unique-character-in-a-string/
    //Solution : https://leetcode.com/problems/first-unique-character-in-a-string/submissions/1058893300/

    public int FirstUniqChar(string s)
    {
        var dict = new Dictionary<char, int>();
        foreach (char c in s)
        {
            if (dict.ContainsKey(c)) dict[c]++;
            else dict[c] = 0;
        }

        foreach (var item in dict)
        {
            if (item.Value == 0) return s.IndexOf(item.Key);
        }
        return -1;
    }
}

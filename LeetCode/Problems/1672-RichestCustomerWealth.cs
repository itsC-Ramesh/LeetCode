namespace LeetCode.Problems;
internal class _1672_RichestCustomerWealth
{
    //Problems : https://leetcode.com/problems/richest-customer-wealth/
    //Solution : https://leetcode.com/problems/richest-customer-wealth/submissions/1060682155/
    public int MaximumWealth(int[][] accounts)
    {
        var maxWealth = 0;
        foreach (var account in accounts)
        {
            var accountSum = 0;
            foreach (var wealth in account) { accountSum += wealth; }
            if (accountSum > maxWealth) maxWealth = accountSum;
        }
        return maxWealth;
    }
}

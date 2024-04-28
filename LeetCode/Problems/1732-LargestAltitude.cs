namespace LeetCode.Problems;
public class _1732_LargestAltitude
{
    //Problem: https://leetcode.com/problems/find-the-highest-altitude/
    //Soltion: https://leetcode.com/problems/find-the-highest-altitude/submissions/1061382771/
    public int LargestAltitude(int[] gain)
    {
        var actualGains = new int[gain.Length + 1];

        actualGains[0] = 0;

        for (int i = 0; i < gain.Length; i++)
        {
            actualGains[i + 1] = gain[i] + actualGains[i];
        }

        return actualGains.Max();
    }

    //Solution: https://leetcode.com/problems/find-the-highest-altitude/submissions/1061393336/
    public int LargestAltitude_1(int[] gain)
    {
        int currentAltitude = 0; int highestAltitude = 0;

        for (int i = 0; i < gain.Length; i++)
        {
            currentAltitude += gain[i];
            if (currentAltitude > highestAltitude) highestAltitude = currentAltitude;
        }

        return highestAltitude;
    }
}

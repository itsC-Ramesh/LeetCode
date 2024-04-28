using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LeetCode.Problems;
public class _1431_KidsWithCandies
{
    //Problem: https://leetcode.com/problems/kids-with-the-greatest-number-of-candies/
    //Solution: https://leetcode.com/problems/kids-with-the-greatest-number-of-candies/submissions/1061221719/

    public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
    {
        var list = new bool[candies.Length];
        var maxCandies = candies.Max();
        for (int i = 0; i < candies.Length; i++)
        {
            list[i] = (candies[i] + extraCandies >= maxCandies) ? true : false;
        }
        return list;
    }
}

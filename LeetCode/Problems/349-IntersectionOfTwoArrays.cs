using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems;
public class _349_IntersectionOfTwoArrays
{
    public int[] Intersection(int[] nums1, int[] nums2)
    {
        var dict = new Dictionary<int, int>();

        for (int i = 0; i < nums1.Length; i++)
        {
            if (!dict.ContainsKey(nums1[i])) dict[nums1[i]] = 1;
        }

        for (int i = 0; i < nums2.Length; i++)
        {
            if (dict.ContainsKey(nums2[i])) dict[nums2[i]]++;
        }

        return dict.Where(x => x.Value > 1).Select(x => x.Key).ToArray();


        //var result = new List<int>();

        //dict.Select(x => x.Value > 1 )

        //foreach (var item in dict)
        //{
        //    if (item.Value >= 2) result.Add(item.Key);
        //}

        //return result.ToArray();
    }
}


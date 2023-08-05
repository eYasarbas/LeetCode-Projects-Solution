using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Merge_Sorted_Array
{
    public class Solution
    {
        public List<int> Merge(int[] nums1, int m, int[] nums2, int n)
        {
            List<int> newList = new List<int>(m + n);

            for (var i = 0; i < m ; i++)
            {
                newList.Add(nums1[i]);
            }

            for (var j = 0; j < n ; j++)
            {
                newList.Add(nums2[j]);
            }
            newList.Sort();
            return newList;
        }

    }
}
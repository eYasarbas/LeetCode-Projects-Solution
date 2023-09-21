using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Merge_Sorted_Array;
public class Program
{
    public static void Main(string[] args)
    {
        int[] nums1 = { 1, 2, 3, 0, 0, 0 };
        int[] nums2 = { 2, 5, 6 };
        int m = 3;
        int n = 3;

        Solution solution = new Solution();
        List<int> mergedList = solution.Merge(nums1, m, nums2, n);
        string output = string.Join(", ", mergedList);
        Console.WriteLine(output);


    }
}


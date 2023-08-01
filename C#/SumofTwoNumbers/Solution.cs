using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SumofTwoNumbers
{
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                var complement = target - nums[i];
                for (int j = 0; j < i; j++)
                {
                    if (nums[j] == complement)
                    {
                        return new int[] { j, i };
                    }
                }
            }
            // If no solution is found, you can return null or an empty array
            return new int[0];
        }

    }
}
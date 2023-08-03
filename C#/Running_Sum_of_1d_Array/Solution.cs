using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Running_Sum_of_1d_Array
{
    public class Solution
    {
        public int[] RunningSum(int[] nums)
        {
            int[] newNums = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                if (i == 0)
                {
                    newNums[i] = nums[i];
                }
                else
                {
                    for (int j = 0; j <= i; j++)
                    {
                        newNums[i] += nums[j];
                    }
                }

            }
            return newNums;
        }

    }
}
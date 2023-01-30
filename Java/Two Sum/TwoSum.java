
import java.util.*;

public class TwoSum {
    public static void main(String[] args) {
        class Solution {
            public int[] twoSum1(int[] nums, int target) {
                for (int i = 0; i < nums.length; i++) {
                    for (int j = i + 1; j < nums.length; j++) {
                        if (nums[i] + nums[j] == target) {
                            return new int[] { i, j };
                        }
                    }
                }

                return new int[] {};
            }

            public int[] twoSum2(int[] nums, int target) {
                Map<Integer, Integer> numToIndex = new HashMap<>();
                for (int i = 0; i < nums.length; i++) {
                    if (numToIndex.containsKey(target - nums[i])) {
                        return new int[] { numToIndex.get(target - nums[i]), i };
                    }
                    numToIndex.put(nums[i], i);
                }
                return new int[] {};

            }
        }
        int[] testList = new int[9];
        testList[0] = 1;
        testList[1] = 3;
        testList[2] = 4;
        testList[3] = 6;
        testList[4] = 8;
        testList[5] = 9;
        testList[6] = 13;
        testList[7] = 14;
        testList[8] = 34;

        int target = 27;

        Solution solution1 = new Solution();
        System.out.println(solution1.twoSum1(testList, target)[0]);
        System.out.println(solution1.twoSum1(testList, target)[1]);
        Solution solution2 = new Solution();
        System.out.println(solution2.twoSum1(testList, target)[0]);
        System.out.println(solution2.twoSum1(testList, target)[1]);
    }

}

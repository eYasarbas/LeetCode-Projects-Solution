namespace RemoveDuplicates2;

public class Program
{
    public static void Main(string[] args)
    {
        List<int> RemoveDuplicates(int[] nums)
        {
            var nums2 = new List<int>(nums);
            for (var i = 0; i < nums2.Count;)
            {
                if (i + 2 < nums2.Count)
                {

                    if (nums2[i] == nums2[i + 1] && nums2[i] == nums[i + 2])
                    {
                        nums2.RemoveAt(i + 2);
                        i--;
                    }
                }

                i++;
            }

            return nums2;
        }

        int[] nums = { 0, 0, 0, 1, 1, 1, 1, 2, 2, 2, 3, 3 };
        var result = RemoveDuplicates(nums);
        foreach (var VARIABLE in result)
        {
            Console.WriteLine(VARIABLE);
        }
    }
}
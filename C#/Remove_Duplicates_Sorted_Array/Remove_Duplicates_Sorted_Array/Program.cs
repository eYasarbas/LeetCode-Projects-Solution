namespace Remove_Duplicates_Sorted_Array;

public class Program
{
    public static void Main(string[] args)
    {
        int[] nums = { 1, 1, 2, 2, 3, 4, 4, 5 };
        var length = RemoveDuplicates(nums);

        Console.WriteLine("Duplicated elements removed:");
        for (var i = 0; i < length; i++) Console.Write(nums[i] + " ");
    }

    public static int RemoveDuplicates(int[] nums)
    {
        if (nums.Length == 0) return 0;

        var uniqueCount = 1;

        for (var i = 1; i < nums.Length; i++)
            if (nums[i] != nums[i - 1])
            {
                nums[uniqueCount] = nums[i];
                uniqueCount++;
            }

        return uniqueCount;
    }
}
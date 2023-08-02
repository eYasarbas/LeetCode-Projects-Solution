namespace SumofTwoNumbers;

static class SumofTwoNumbers
{
    public static void Main(string[] args)
    {
        int[] nums = { 2, 7, 11, 15 };
        const int target = 9;
        Console.WriteLine(SumTwo(12, 34));
        int[] result = Solution.TwoSum(nums, target);

        if (result.Length == 2)
        {
            Console.WriteLine($"Indices of the two numbers: {result[0]} and {result[1]}");
        }
        else
        {
            Console.WriteLine("No two numbers found that add up to the target.");
        }
    }

    private static string SumTwo(int a, int b)
    {
        return "The sum of " + a + " and " + b + " is: " + (a + b);
    }
}
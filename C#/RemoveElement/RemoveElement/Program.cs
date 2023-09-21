namespace RemoveElement;

public class Program
{
    public static void Main(string[] args)
    {
        int RemoveElement(int[] nums, int val)

        {
            int result = 0;
            foreach (var item in nums)
            {
                if (item != val)
                {
                    nums[result] = item;
                    result++;
                }
            }

            return result;
        }
    }
}
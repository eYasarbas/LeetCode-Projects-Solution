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
                    var x = nums2[i];
                    var y = nums2[i + 1];
                    var z = nums2[i + 2];
                    if (x == y)

                        if (y == z)
                        {
                            nums2.Remove(z);
                            i--;
                        }
                }

                i++;
            }

            return nums2;
        }

        int[] nums = { 1, 1, 1, 2, 2, 3 };
        var result = RemoveDuplicates(nums);
        Console.WriteLine(result.Count);
        foreach (var VARIABLE in result) Console.WriteLine(VARIABLE);
    }
}
namespace Majority_Element;

public class Program
{
    public static void Main(string[] args)
    {
        int MajorityElement(int[] nums)
        {
            var againCount = new Dictionary<int, int>();

            foreach (var item in nums)
                if (againCount.ContainsKey(item))
                    againCount[item]++;
                else
                    againCount[item] = 1;

            var mostAgain = againCount.OrderByDescending(x => x.Value).First().Key;

            return mostAgain;
        }

        int[] myList =
        {
            1, 2, 3, 4, 2, 2, 5, 6, 2, 7, 8, 9, 2
        };

        Console.WriteLine(MajorityElement(myList));
    }
}
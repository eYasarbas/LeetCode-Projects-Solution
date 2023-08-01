namespace SumofTwoNumbers;
class SumofTwoNumbers
{
    public static void Main(string[] args)
    {
        Console.WriteLine(SumTwo(12, 34));
    }

    private static string SumTwo(int a, int b)
    {
        return ("The sum of " + a + " and " + b + " is: "+ (a + b));
    }
}
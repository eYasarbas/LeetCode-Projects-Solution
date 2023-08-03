namespace Running_Sum_of_1d_Array
{
    class Program
    {
        public static void Main(string[] args)
        {
            Solution solution= new Solution();
            int [] nums = {-2, 0, -3};
            Console.WriteLine("The result is: "+solution.RunningSum(nums));
        }
    }
}
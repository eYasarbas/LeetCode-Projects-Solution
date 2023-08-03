namespace PalindromeNumber
{
    class Program
    {
        public static void Main(string[] args)
        {
            Solution solution= new Solution();
            bool result= solution.IsPalindrome(543432);
            Console.WriteLine("result:{0}",result );
        }
    }
    
}
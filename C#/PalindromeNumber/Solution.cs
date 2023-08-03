namespace PalindromeNumber
{
    public class Solution
    {
        public bool IsPalindrome(int x)
        {
            string str = x.ToString();
            string reversed = new string(str.Reverse().ToArray());
            return str.Equals(reversed);
        }
    }
}
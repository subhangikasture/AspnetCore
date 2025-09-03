namespace ExtensionMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string test = "HelloWorld";
            string left = test.Substring(0, 5);
            string right = test.RightSubstring(5);
            Console.WriteLine(left);
            Console.WriteLine(right);
            Console.WriteLine("Hello, World!");
        }
    }

    internal static class StringExtensions_
    { 
        public static string RightSubstring(this string s, int count)
        {
            return s.Substring(s.Length - count, count);
        }
    }



}

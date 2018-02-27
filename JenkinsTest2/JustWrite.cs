using System;

namespace JenkinsTest2
{
    public class JustWrite
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(GetMessage());
        }

        public static string GetMessage()
        {
            return "This is a test.";
        }
    }
}

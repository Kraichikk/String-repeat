using System;

namespace String_repeat
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
        public static string RepeatStr(int n, string s)
        {
            string val = "";

            for (int i = 0; i < n; i++)
            {
                val += s;
            }
            return val;
        }
    }
}

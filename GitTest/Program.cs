using System;

namespace GitTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Test.TestString1);
            Console.WriteLine(Test.TestString2);
            Console.WriteLine(Test.TestString3);
            Console.Read();
        }
    }
    public static class Test
    {
        public static string TestString1 => "TestString1";
        public static string TestString2 => "TestString2";
        public static string TestString3 => "TestString3";
    }

}

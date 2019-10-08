using System;
using System.Collections.Generic;
using System.Text;

namespace MasteringLinq
{
    public static class ConsoleExtensions
    {
        public static void DrawLine()
        {
            Console.WriteLine("============================================");
        }

        public static void DrawSmallLine()
        {
            Console.WriteLine("--------------------------------------------");
        }

        public static void WriteNewLine()
        {
            Console.WriteLine("");
        }
    }
}

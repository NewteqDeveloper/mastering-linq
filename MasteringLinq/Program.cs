using System;
using MasteringLinq.SelectQuery;

namespace MasteringLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            var masteringSelect = new MasteringSelect();
            masteringSelect.Run();

            Console.WriteLine("All code has finished running");

            Console.ReadKey();
        }
    }
}

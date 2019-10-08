using System;
using MasteringLinq.Enumberable;
using MasteringLinq.SelectQuery;

namespace MasteringLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            var masteringSelect = new MasteringSelect();
            var enumeratorSample = new SampleEnumerator();

            masteringSelect.Run();
            enumeratorSample.Run();

            Console.WriteLine("All code has finished running");

            Console.ReadKey();
        }
    }
}

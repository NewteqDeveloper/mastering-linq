using System;
using MasteringLinq.Enumberable;
using MasteringLinq.QuerySyntax;
using MasteringLinq.SelectQuery;

namespace MasteringLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            var masteringSelect = new MasteringSelect();
            var enumeratorSample = new SampleEnumerator();
            var query = new SampleQuerySyntax();

            masteringSelect.Run();
            enumeratorSample.Run();
            query.Run();

            Console.WriteLine("All code has finished running");

            Console.ReadKey();
        }
    }
}

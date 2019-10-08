using System;
using System.Collections.Generic;
using System.Text;

namespace MasteringLinq.Enumberable
{
    public class SampleEnumerator
    {
        public void Run()
        {
            Console.WriteLine($"Running the {nameof(SampleEnumerator)}");
            ConsoleExtensions.DrawSmallLine();
            GoOverItems();
            ConsoleExtensions.DrawLine();
        }

        private void GoOverItems()
        {
            IEnumerable<int> list = new List<int>
            {
                1,
                2,
                3,
                4,
                5
            };

            // the IEnumerator is an object that implements IDisposable, and should be disposed
            // this is why we us a using statement
            using (var enumerator = list.GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    Console.WriteLine(enumerator.Current);
                }
                enumerator.Reset();
                while (enumerator.MoveNext())
                {
                    Console.WriteLine(enumerator.Current);
                }
            }
        }
    }
}

using PerformanceTest.Models;
using System;
using System.Data.Entity;
using System.Diagnostics;

namespace PerformanceTest
{
    public class Program
    {
        private async void Main(string[] args)
        {
            string str = "test string";
            Stopwatch s = new Stopwatch();

            s.Start();
            using (TestEntites db = new TestEntites())
            {
                bool xx = await db.TestTable.AnyAsync(x => x.TestColumm.Contains(str));
            }
            s.Stop();
            Console.WriteLine("{0}ms using Contains", s.Elapsed.TotalMilliseconds);

            s.Reset();

            s.Start();
            using (TestEntites db = new TestEntites())
            {
                bool xx = await db.TestTable.AnyAsync(x => x.TestColumm.StartsWith(str);
            }
            s.Stop();
            Console.WriteLine("{0}ms using StartsWith", s.Elapsed.TotalMilliseconds);

            s.Reset();

            s.Start();
            using (TestEntites db = new TestEntites())
            {
                bool xx = await db.TestTable.AnyAsync(x => x.TestColumm.Equals(str);
            }
            s.Stop();
            Console.WriteLine("{0}ms using Equals", s.Elapsed.TotalMilliseconds);

            s.Reset();

            s.Start();
            using (TestEntites db = new TestEntites())
            {
                bool xx = await db.TestTable.AnyAsync(x => x.TestColumm == str);
            }
            s.Stop();
            Console.WriteLine("{0}ms using ==", s.Elapsed.TotalMilliseconds);

            Console.WriteLine("Press a key to quit...");
            Console.ReadKey();
        }
    }
}
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Order;
using BenchmarkDotNet.Reports;
using System.Data.Common;

namespace BenchMark
{
    [MemoryDiagnoser]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn]
    public class BenchMarkExecutingMethods
    {
        public List<string> RegularList()
        {
            return new List<string> { "apple", "banana", "orange" };
        }

      
        public List<string> ColExpressionList()
        {
            return ["apple", "banana", "orange"];
        }
        [Benchmark(Baseline = true)]
        public bool EndsWithStringValue()
        {
            var testString = "serkut";
            return testString.EndsWith("s");
        }
        [Benchmark]
        public bool EndsWithCharValue()
        {
            var testString = "serkut";
            return testString.EndsWith('s');
        }

    }
}

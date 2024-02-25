using BenchMark;
using BenchmarkDotNet.Running;

var summary = BenchmarkRunner.Run<BenchMarkExecutingMethods>();

// Display summary
Console.WriteLine(summary);
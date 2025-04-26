using BenchmarkDotNet.Running;
using BenchmarkingSandbox.Enumeration;

var summary = BenchmarkRunner.Run<EnumerationBenchmark>();
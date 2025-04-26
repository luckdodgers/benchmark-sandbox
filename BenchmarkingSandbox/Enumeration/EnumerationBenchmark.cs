using BenchmarkDotNet.Attributes;

namespace BenchmarkingSandbox.Enumeration;

public class EnumerationBenchmark
{
    [Benchmark]
    public IReadOnlyList<ColorsDefault> GetAllValuesDefault() => ColorsDefault.AllValues;
    
    [Benchmark]
    public IReadOnlyList<ColorsOptimized> GetAllValuesOptimized() => ColorsOptimized.AllValues;
}
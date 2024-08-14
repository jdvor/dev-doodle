namespace Doodle.Benchmarks;

using BenchmarkDotNet.Attributes;

[MemoryDiagnoser]
public class SequenceSearchBench
{
    [Benchmark]
    public int Version1()
    {
        var r = 0;
        foreach (var (_, nums, _) in SequenceSearch.Data)
        {
            r = SequenceSearch.Find(nums);
        }

        return r;
    }
}



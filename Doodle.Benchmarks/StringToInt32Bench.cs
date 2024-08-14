namespace Doodle.Benchmarks;

using BenchmarkDotNet.Attributes;

[MemoryDiagnoser]
public class StringToInt32Bench
{
    [Benchmark]
    public int Version1()
    {
        var r = 0;
        foreach (var (s, _) in StringToInt32.Data)
        {
            r = StringToInt32.Convert(s);
        }

        return r;
    }
}



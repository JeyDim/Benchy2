using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using Benchy.Solutions;

BenchmarkRunner.Run<Benchmarks>();

[MemoryDiagnoser]
public class Benchmarks
{
    [Params(10, 1000, 100_000)] public int Length = 10;

    private Naive _naive;
    private RecreateArray _recreateArray;
    private Sergey _sergey;
    private Michael _michael;


    [GlobalSetup]
    public void Do()
    {
        _naive = new Naive(Length);
        _recreateArray = new RecreateArray(Length);
        _sergey = new Sergey(Length);
        _michael = new Michael(Length);
    }

    [Benchmark(Baseline = true)]
    public void Naive() => _naive.SetAllCells(1);
    [Benchmark]
    public void RecreateArray() => _recreateArray.SetAllCells(1);
    [Benchmark]
    public void Sergey() => _sergey.SetAllCells(1);
    
    [Benchmark]
    public void Michael() => _michael.SetAllCells(1);
}
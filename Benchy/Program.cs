using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using Benchy;
using Benchy.Solutions;

BenchmarkRunner.Run<Benchmarks>();

[MemoryDiagnoser]
public class Benchmarks
{
    [Params(typeof(Naive), typeof(RecreateArray), typeof(Sergey), typeof(Sergey2), typeof(Michael), typeof(Michael2))] public Type _type = typeof(Naive);

    [Params(1000, 10_000, 100_000)] public int Length = 10;

    private ITask0 _task0;

    [GlobalSetup]
    public void Do()
    {
        var task0 = Activator.CreateInstance(_type, args: Length) as ITask0;
        _task0 = task0 ?? throw new Exception("Task0 is null");
    }

    [IterationSetup]
    public void Boost()
    {
        for (var j = 0; j < Length; j++) _task0.SetCell(1, j);
    }

    [Benchmark]
    public void SetCell() => _task0.SetCell(1, 0);

    [Benchmark]
    public void GetCell() => _task0.GetCell(0);

    [Benchmark]
    public void SetAllCells() => _task0.SetAllCells(1);
}
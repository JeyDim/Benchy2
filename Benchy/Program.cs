using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using Benchy;
using Benchy.Solutions;

BenchmarkRunner.Run<Benchmarks>();

[MemoryDiagnoser]
public class Benchmarks
{
    [Params(10, 1000, 100_000)] public int Length = 10;
    [Params(typeof(Naive), typeof(RecreateArray), typeof(Sergey))] public Type _type = typeof(Naive);

    private readonly ITask0 _task0;

    public Benchmarks()
    {
        // todo create _naive by type from Type

        var task0 = Activator.CreateInstance(_type, args: Length) as ITask0;
        _task0 = task0 ?? throw new Exception("Task0 is null");
    }
    
    [Benchmark]
    public void SetAllCells() => _task0.SetAllCells(1);
}
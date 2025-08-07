using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using Benchy.Solutions;

// BenchmarkRunner.Run<BenchmarkSetAllCells>();
// BenchmarkRunner.Run<BenchmarkSetCell>();
BenchmarkRunner.Run<BenchmarkGetCell>();

[MemoryDiagnoser]
public class BenchmarkSetAllCells
{
    [Params(10, 100, 1000)] public int Length = 10;

    private Naive _naive;
    private RecreateArray _recreateArray;
    private Sergey _sergey;
    private Sergey2 _sergey2;
    private Michael _michael;


    [GlobalSetup]
    public void Do()
    {
        _naive = new Naive(Length);
        _recreateArray = new RecreateArray(Length);
        _sergey = new Sergey(Length);
        _sergey2 = new Sergey2(Length);
        _michael = new Michael(Length);
    }

    [Benchmark(Baseline = true)]
    public void Naive() => _naive.SetAllCells(1);

    [Benchmark]
    public void RecreateArray() => _recreateArray.SetAllCells(1);

    [Benchmark]
    public void Sergey() => _sergey.SetAllCells(1);
    [Benchmark]
    public void Sergey2() => _sergey2.SetAllCells(1);

    [Benchmark]
    public void Michael() => _michael.SetAllCells(1);
}


[MemoryDiagnoser]
public class BenchmarkSetCell
{
    [Params(10, 100, 1000)] public int Length = 10;

    private Naive _naive;
    private RecreateArray _recreateArray;
    private Sergey _sergey;
    private Sergey2 _sergey2;
    private Michael _michael;


    [GlobalSetup]
    public void Do()
    {
        _naive = new Naive(Length);
        _recreateArray = new RecreateArray(Length);
        _sergey = new Sergey(Length);
        _sergey2 = new Sergey2(Length);
        _michael = new Michael(Length);
    }

    [Benchmark(Baseline = true)]
    public void Naive() => _naive.SetCell(1, 1);

    [Benchmark]
    public void RecreateArray() => _recreateArray.SetCell(1, 1);

    [Benchmark]
    public void Sergey() => _sergey.SetCell(1, 1);

    [Benchmark]
    public void Sergey2() => _sergey2.SetCell(1, 1);

    [Benchmark]
    public void Michael() => _michael.SetCell(1, 1);
}

[MemoryDiagnoser]
public class BenchmarkGetCell
{
    [Params(10, 100, 1000)] public int Length = 10;

    private Naive _naive;
    private RecreateArray _recreateArray;
    private Sergey _sergey;
    private Sergey2 _sergey2;
    private Michael _michael;


    [GlobalSetup]
    public void Do()
    {
        _naive = new Naive(Length);
        _recreateArray = new RecreateArray(Length);
        _sergey = new Sergey(Length);
        _sergey2 = new Sergey2(Length);
        _michael = new Michael(Length);
    }

    [Benchmark(Baseline = true)]
    public void Naive() => _naive.GetCell(1);

    [Benchmark]
    public void RecreateArray() => _recreateArray.GetCell(1);

    [Benchmark]
    public void Sergey() => _sergey.GetCell(1);

    [Benchmark]
    public void Sergey2() => _sergey2.GetCell(1);

    [Benchmark]
    public void Michael() => _michael.GetCell(1);
}
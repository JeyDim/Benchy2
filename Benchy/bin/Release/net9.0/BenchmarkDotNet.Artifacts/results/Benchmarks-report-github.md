```

BenchmarkDotNet v0.15.2, macOS Sequoia 15.6 (24G84) [Darwin 24.6.0]
Apple M1 Pro, 1 CPU, 10 logical and 10 physical cores
.NET SDK 9.0.304
  [Host]     : .NET 9.0.8 (9.0.825.36511), Arm64 RyuJIT AdvSIMD
  DefaultJob : .NET 9.0.8 (9.0.825.36511), Arm64 RyuJIT AdvSIMD


```
| Method      | Length | _type         | Mean       | Error     | StdDev    | Allocated |
|------------ |------- |-------------- |-----------:|----------:|----------:|----------:|
| **SetCell**     | **10**     | **Naive**         |  **0.1894 ns** | **0.0016 ns** | **0.0014 ns** |         **-** |
| GetCell     | 10     | Naive         |  0.0904 ns | 0.0054 ns | 0.0050 ns |         - |
| SetAllCells | 10     | Naive         | 11.3345 ns | 0.0178 ns | 0.0148 ns |         - |
| **SetCell**     | **10**     | **RecreateArray** |  **0.1316 ns** | **0.0054 ns** | **0.0048 ns** |         **-** |
| GetCell     | 10     | RecreateArray |  0.0199 ns | 0.0028 ns | 0.0026 ns |         - |
| SetAllCells | 10     | RecreateArray | 10.9758 ns | 0.0458 ns | 0.0428 ns |         - |
| **SetCell**     | **10**     | **Sergey**        |  **0.1431 ns** | **0.0012 ns** | **0.0011 ns** |         **-** |
| GetCell     | 10     | Sergey        |  0.0344 ns | 0.0027 ns | 0.0023 ns |         - |
| SetAllCells | 10     | Sergey        | 11.3209 ns | 0.0120 ns | 0.0112 ns |         - |
| **SetCell**     | **1000**   | **Naive**         |  **0.1098 ns** | **0.0023 ns** | **0.0021 ns** |         **-** |
| GetCell     | 1000   | Naive         |  0.0528 ns | 0.0028 ns | 0.0026 ns |         - |
| SetAllCells | 1000   | Naive         |  9.0793 ns | 0.0165 ns | 0.0154 ns |         - |
| **SetCell**     | **1000**   | **RecreateArray** |  **0.1208 ns** | **0.0020 ns** | **0.0019 ns** |         **-** |
| GetCell     | 1000   | RecreateArray |  0.0336 ns | 0.0081 ns | 0.0072 ns |         - |
| SetAllCells | 1000   | RecreateArray |  9.1287 ns | 0.0436 ns | 0.0387 ns |         - |
| **SetCell**     | **1000**   | **Sergey**        |  **0.1360 ns** | **0.0076 ns** | **0.0071 ns** |         **-** |
| GetCell     | 1000   | Sergey        |  0.0504 ns | 0.0043 ns | 0.0041 ns |         - |
| SetAllCells | 1000   | Sergey        |  9.1469 ns | 0.0941 ns | 0.0880 ns |         - |
| **SetCell**     | **100000** | **Naive**         |  **0.1405 ns** | **0.0028 ns** | **0.0026 ns** |         **-** |
| GetCell     | 100000 | Naive         |  0.0545 ns | 0.0020 ns | 0.0019 ns |         - |
| SetAllCells | 100000 | Naive         |  9.0797 ns | 0.0266 ns | 0.0249 ns |         - |
| **SetCell**     | **100000** | **RecreateArray** |  **0.1201 ns** | **0.0022 ns** | **0.0021 ns** |         **-** |
| GetCell     | 100000 | RecreateArray |  0.0298 ns | 0.0024 ns | 0.0022 ns |         - |
| SetAllCells | 100000 | RecreateArray |  9.0769 ns | 0.0188 ns | 0.0167 ns |         - |
| **SetCell**     | **100000** | **Sergey**        |  **0.1205 ns** | **0.0024 ns** | **0.0023 ns** |         **-** |
| GetCell     | 100000 | Sergey        |  0.0301 ns | 0.0020 ns | 0.0019 ns |         - |
| SetAllCells | 100000 | Sergey        |  9.0845 ns | 0.0151 ns | 0.0141 ns |         - |

Results

| Method      | Length | _type         |       Mean |     Error |    StdDev | Allocated |
|-------------|--------|---------------|-----------:|----------:|----------:|----------:|
| SetAllCells | 10     | Naive         | 11.3345 ns | 0.0178 ns | 0.0148 ns |         - |
| SetAllCells | 10     | RecreateArray | 10.9758 ns | 0.0458 ns | 0.0428 ns |         - |
| SetAllCells | 10     | Sergey        | 11.3209 ns | 0.0120 ns | 0.0112 ns |         - |
| SetAllCells | 1000   | Naive         |  9.0793 ns | 0.0165 ns | 0.0154 ns |         - |
| SetAllCells | 1000   | RecreateArray |  9.1287 ns | 0.0436 ns | 0.0387 ns |         - |
| SetAllCells | 1000   | Sergey        |  9.1469 ns | 0.0941 ns | 0.0880 ns |         - |
| SetAllCells | 100000 | Naive         |  9.0797 ns | 0.0266 ns | 0.0249 ns |         - |
| SetAllCells | 100000 | RecreateArray |  9.0769 ns | 0.0188 ns | 0.0167 ns |         - |
| SetAllCells | 100000 | Sergey        |  9.0845 ns | 0.0151 ns | 0.0141 ns |         - |

# Results

| Method      | _type         | Length |           Mean |         Error |        StdDev |         Median |            P95 | Allocated |
|-------------|---------------|--------|---------------:|--------------:|--------------:|---------------:|---------------:|----------:|
| SetCell     | Michael       | 1000   |     85.7143 ns |    13.7405 ns |    35.2222 ns |    100.0000 ns |    100.0000 ns |         - |
| GetCell     | Michael       | 1000   |    130.3030 ns |    20.3503 ns |    59.6838 ns |    100.0000 ns |    200.0000 ns |         - |
| SetAllCells | Michael       | 1000   |    728.3505 ns |    51.7573 ns |   150.1574 ns |    750.0000 ns |  1,050.0000 ns |         - |
| SetCell     | Michael       | 10000  |     87.8049 ns |    12.4156 ns |    32.9243 ns |    100.0000 ns |    100.0000 ns |         - |
| GetCell     | Michael       | 10000  |    130.3030 ns |    20.9251 ns |    61.3696 ns |    100.0000 ns |    200.0000 ns |         - |
| SetAllCells | Michael       | 10000  |  2,758.9474 ns |   120.4661 ns |   345.6399 ns |  2,700.0000 ns |  3,500.0000 ns |         - |
| SetCell     | Michael       | 100000 |     77.9070 ns |    15.3389 ns |    41.7307 ns |    100.0000 ns |    100.0000 ns |         - |
| GetCell     | Michael       | 100000 |    123.2323 ns |    18.7569 ns |    55.0107 ns |    100.0000 ns |    200.0000 ns |         - |
| SetAllCells | Michael       | 100000 | 49,787.5000 ns |   933.0952 ns |   916.4242 ns | 49,400.0000 ns | 51,325.0000 ns |         - |
| SetCell     | Michael2      | 1000   |     89.7436 ns |    11.8293 ns |    30.5352 ns |    100.0000 ns |    100.0000 ns |         - |
| GetCell     | Michael2      | 1000   |    112.1212 ns |    25.4378 ns |    74.6047 ns |    100.0000 ns |    200.0000 ns |         - |
| SetAllCells | Michael2      | 1000   |    612.7660 ns |    43.9865 ns |   125.4960 ns |    600.0000 ns |    900.0000 ns |      64 B |
| SetCell     | Michael2      | 10000  |     86.2500 ns |    13.2430 ns |    34.6547 ns |    100.0000 ns |    100.0000 ns |         - |
| GetCell     | Michael2      | 10000  |     96.0526 ns |     7.7009 ns |    19.6013 ns |    100.0000 ns |    100.0000 ns |         - |
| SetAllCells | Michael2      | 10000  |    567.0455 ns |    24.4465 ns |    67.3327 ns |    600.0000 ns |    700.0000 ns |      64 B |
| SetCell     | Michael2      | 100000 |    111.2245 ns |    23.0269 ns |    67.1706 ns |    100.0000 ns |    200.0000 ns |         - |
| GetCell     | Michael2      | 100000 |     76.0417 ns |    25.0158 ns |    72.1764 ns |    100.0000 ns |    200.0000 ns |         - |
| SetAllCells | Michael2      | 100000 |  1,258.7629 ns |   154.0486 ns |   446.9229 ns |  1,100.0000 ns |  2,100.0000 ns |      64 B |
| SetCell     | Naive         | 1000   |     68.6869 ns |    17.3221 ns |    50.8027 ns |    100.0000 ns |    100.0000 ns |         - |
| GetCell     | Naive         | 1000   |     51.5152 ns |    18.4607 ns |    54.1420 ns |      0.0000 ns |    100.0000 ns |         - |
| SetAllCells | Naive         | 1000   |  5,694.7368 ns |   416.5144 ns | 1,195.0579 ns |  5,500.0000 ns |  7,790.0000 ns |         - |
| SetCell     | Naive         | 10000  |     51.0000 ns |    18.3528 ns |    54.1136 ns |      0.0000 ns |    100.0000 ns |         - |
| GetCell     | Naive         | 10000  |     72.7273 ns |    18.7505 ns |    54.9920 ns |    100.0000 ns |    110.0000 ns |         - |
| SetAllCells | Naive         | 10000  |  9,258.2418 ns |   275.2148 ns |   771.7320 ns |  9,100.0000 ns | 10,750.0000 ns |         - |
| SetCell     | Naive         | 100000 |     76.0000 ns |    17.4606 ns |    51.4831 ns |    100.0000 ns |    100.0000 ns |         - |
| GetCell     | Naive         | 100000 |     40.2062 ns |     6.8754 ns |    19.9468 ns |     50.0000 ns |     50.0000 ns |         - |
| SetAllCells | Naive         | 100000 | 49,805.5556 ns |   967.2632 ns | 1,034.9608 ns | 49,350.0000 ns | 51,615.0000 ns |         - |
| SetCell     | RecreateArray | 1000   |     90.1099 ns |    10.7051 ns |    30.0183 ns |    100.0000 ns |    100.0000 ns |         - |
| GetCell     | RecreateArray | 1000   |     51.5152 ns |    17.8065 ns |    52.2233 ns |    100.0000 ns |    100.0000 ns |         - |
| SetAllCells | RecreateArray | 1000   |  8,034.7368 ns | 1,257.1159 ns | 3,606.9014 ns |  9,200.0000 ns | 12,340.0000 ns |    4056 B |
| SetCell     | RecreateArray | 10000  |     77.3196 ns |    14.5093 ns |    42.0940 ns |    100.0000 ns |    100.0000 ns |         - |
| GetCell     | RecreateArray | 10000  |     53.5354 ns |    17.0923 ns |    50.1287 ns |    100.0000 ns |    100.0000 ns |         - |
| SetAllCells | RecreateArray | 10000  | 18,200.0000 ns | 2,907.5818 ns | 8,527.4347 ns | 21,100.0000 ns | 29,240.0000 ns |   40056 B |
| SetCell     | RecreateArray | 100000 |     72.7273 ns |    18.1068 ns |    53.1040 ns |    100.0000 ns |    100.0000 ns |         - |
| GetCell     | RecreateArray | 100000 |     29.5918 ns |    16.4806 ns |    48.0746 ns |      0.0000 ns |    100.0000 ns |         - |
| SetAllCells | RecreateArray | 100000 | 26,508.1633 ns |   495.4635 ns |   989.4941 ns | 26,400.0000 ns | 28,680.0000 ns |  400056 B |
| SetCell     | Sergey        | 1000   |     56.0000 ns |    19.4739 ns |    57.4192 ns |    100.0000 ns |    100.0000 ns |         - |
| GetCell     | Sergey        | 1000   |      2.0408 ns |     4.8720 ns |    14.2119 ns |      0.0000 ns |      0.0000 ns |         - |
| SetAllCells | Sergey        | 1000   |     79.1667 ns |    14.1496 ns |    40.8248 ns |    100.0000 ns |    100.0000 ns |         - |
| SetCell     | Sergey        | 10000  |     36.8687 ns |    12.7917 ns |    37.5159 ns |     50.0000 ns |    150.0000 ns |         - |
| GetCell     | Sergey        | 10000  |     42.2222 ns |     6.5372 ns |    18.2232 ns |     50.0000 ns |     50.0000 ns |         - |
| SetAllCells | Sergey        | 10000  |     72.4490 ns |    16.1625 ns |    47.1467 ns |    100.0000 ns |    100.0000 ns |         - |
| SetCell     | Sergey        | 100000 |      0.0000 ns |     0.0000 ns |     0.0000 ns |      0.0000 ns |      0.0000 ns |         - |
| GetCell     | Sergey        | 100000 |     74.7475 ns |    18.4477 ns |    54.1039 ns |    100.0000 ns |    110.0000 ns |         - |
| SetAllCells | Sergey        | 100000 |     69.3878 ns |    17.3396 ns |    50.5805 ns |    100.0000 ns |    100.0000 ns |         - |
| SetCell     | Sergey2       | 1000   |     92.5926 ns |    10.0032 ns |    26.3523 ns |    100.0000 ns |    100.0000 ns |         - |
| GetCell     | Sergey2       | 1000   |     87.9121 ns |    11.6897 ns |    32.7793 ns |    100.0000 ns |    100.0000 ns |         - |
| SetAllCells | Sergey2       | 1000   |     39.3939 ns |    17.4393 ns |    51.1464 ns |      0.0000 ns |    100.0000 ns |         - |
| SetCell     | Sergey2       | 10000  |     73.8095 ns |    16.4646 ns |    44.2312 ns |    100.0000 ns |    100.0000 ns |         - |
| GetCell     | Sergey2       | 10000  |    100.0000 ns |     0.0000 ns |     0.0000 ns |    100.0000 ns |    100.0000 ns |         - |
| SetAllCells | Sergey2       | 10000  |     55.5556 ns |    17.0291 ns |    49.9433 ns |    100.0000 ns |    100.0000 ns |         - |
| SetCell     | Sergey2       | 100000 |     55.0000 ns |    20.6636 ns |    60.9272 ns |      0.0000 ns |    200.0000 ns |         - |
| GetCell     | Sergey2       | 100000 |    100.0000 ns |     0.0000 ns |     0.0000 ns |    100.0000 ns |    100.0000 ns |         - |
| SetAllCells | Sergey2       | 100000 |     73.7374 ns |    15.8481 ns |    46.4799 ns |    100.0000 ns |    100.0000 ns |         - |

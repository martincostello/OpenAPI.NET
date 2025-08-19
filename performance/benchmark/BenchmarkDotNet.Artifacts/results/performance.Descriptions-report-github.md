```

BenchmarkDotNet v0.15.2, Windows 11 (10.0.26100.4946/24H2/2024Update/HudsonValley)
13th Gen Intel Core i7-13700H 2.90GHz, 1 CPU, 20 logical and 14 physical cores
.NET SDK 8.0.413
  [Host]   : .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method       | Mean         | Error         | StdDev       | Gen0       | Gen1       | Gen2      | Allocated    |
|------------- |-------------:|--------------:|-------------:|-----------:|-----------:|----------:|-------------:|
| PetStoreYaml |     322.6 μs |     251.77 μs |     13.80 μs |    35.1563 |     7.8125 |         - |    445.71 KB |
| PetStoreJson |     151.7 μs |      56.10 μs |      3.07 μs |    24.4141 |     5.8594 |         - |    307.85 KB |
| GHESYaml     | 829,977.0 μs | 127,873.81 μs |  7,009.19 μs | 38000.0000 | 19000.0000 | 4000.0000 | 422174.19 KB |
| GHESJson     | 397,127.5 μs | 576,195.19 μs | 31,583.20 μs | 23000.0000 | 12000.0000 | 2000.0000 |  283644.3 KB |

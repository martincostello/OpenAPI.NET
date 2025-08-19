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
| PetStoreYaml |     311.7 μs |      90.14 μs |      4.94 μs |    35.1563 |     7.8125 |         - |    434.34 KB |
| PetStoreJson |     142.7 μs |      28.80 μs |      1.58 μs |    23.4375 |     6.8359 |         - |    296.48 KB |
| GHESYaml     | 796,230.8 μs | 296,583.76 μs | 16,256.76 μs | 37000.0000 | 19000.0000 | 4000.0000 | 404377.45 KB |
| GHESJson     | 359,560.4 μs | 122,198.31 μs |  6,698.10 μs | 22000.0000 | 12000.0000 | 2000.0000 | 265847.63 KB |

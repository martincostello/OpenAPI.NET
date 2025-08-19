```

BenchmarkDotNet v0.15.2, Windows 11 (10.0.26100.4946/24H2/2024Update/HudsonValley)
13th Gen Intel Core i7-13700H 2.90GHz, 1 CPU, 20 logical and 14 physical cores
.NET SDK 8.0.413
  [Host]   : .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method       | Mean         | Error         | StdDev      | Gen0       | Gen1       | Gen2      | Allocated    |
|------------- |-------------:|--------------:|------------:|-----------:|-----------:|----------:|-------------:|
| PetStoreYaml |     265.6 μs |      53.73 μs |     2.94 μs |    31.2500 |     7.8125 |         - |    387.12 KB |
| PetStoreJson |     106.6 μs |      39.80 μs |     2.18 μs |    20.0195 |     5.3711 |         - |    249.26 KB |
| GHESYaml     | 774,833.9 μs | 155,894.04 μs | 8,545.08 μs | 36000.0000 | 19000.0000 | 4000.0000 | 400088.73 KB |
| GHESJson     | 364,114.2 μs | 174,868.35 μs | 9,585.12 μs | 22000.0000 | 12000.0000 | 2000.0000 | 261558.87 KB |

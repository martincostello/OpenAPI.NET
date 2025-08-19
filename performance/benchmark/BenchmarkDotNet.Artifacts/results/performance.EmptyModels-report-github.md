```

BenchmarkDotNet v0.15.2, Windows 11 (10.0.26100.4946/24H2/2024Update/HudsonValley)
13th Gen Intel Core i7-13700H 2.90GHz, 1 CPU, 20 logical and 14 physical cores
.NET SDK 8.0.413
  [Host]   : .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                      | Mean       | Error       | StdDev     | Gen0   | Allocated |
|---------------------------- |-----------:|------------:|-----------:|-------:|----------:|
| EmptyApiCallback            |   3.685 ns |   4.9995 ns |  0.2740 ns | 0.0025 |      32 B |
| EmptyApiComponents          |   4.967 ns |  11.7587 ns |  0.6445 ns | 0.0083 |     104 B |
| EmptyApiContact             |   3.944 ns |   7.9007 ns |  0.4331 ns | 0.0038 |      48 B |
| EmptyApiDiscriminator       |   5.334 ns |   6.5404 ns |  0.3585 ns | 0.0032 |      40 B |
| EmptyDocument               | 287.007 ns | 203.0917 ns | 11.1321 ns | 0.0901 |    1136 B |
| EmptyApiEncoding            |   3.901 ns |   6.4548 ns |  0.3538 ns | 0.0045 |      56 B |
| EmptyApiExample             |   3.857 ns |   6.2012 ns |  0.3399 ns | 0.0045 |      56 B |
| EmptyApiExternalDocs        |   3.952 ns |   7.6022 ns |  0.4167 ns | 0.0032 |      40 B |
| EmptyApiHeader              |   5.191 ns |   7.9492 ns |  0.4357 ns | 0.0064 |      80 B |
| EmptyApiInfo                |   4.238 ns |   4.7224 ns |  0.2588 ns | 0.0064 |      80 B |
| EmptyApiLicense             |   4.067 ns |   8.7288 ns |  0.4785 ns | 0.0038 |      48 B |
| EmptyApiLink                |   4.313 ns |   8.1149 ns |  0.4448 ns | 0.0057 |      72 B |
| EmptyApiMediaType           |   3.722 ns |   1.1040 ns |  0.0605 ns | 0.0045 |      56 B |
| EmptyApiOAuthFlow           |   3.726 ns |   3.3702 ns |  0.1847 ns | 0.0045 |      56 B |
| EmptyApiOAuthFlows          |   3.873 ns |   6.6975 ns |  0.3671 ns | 0.0045 |      56 B |
| EmptyApiOperation           |  43.343 ns |  25.3121 ns |  1.3874 ns | 0.0299 |     376 B |
| EmptyApiParameter           |   5.779 ns |   4.0769 ns |  0.2235 ns | 0.0076 |      96 B |
| EmptyApiPathItem            |   3.935 ns |   3.4925 ns |  0.1914 ns | 0.0051 |      64 B |
| EmptyApiPaths               |  42.765 ns |  58.4386 ns |  3.2032 ns | 0.0197 |     248 B |
| EmptyApiRequestBody         |   3.850 ns |   9.8115 ns |  0.5378 ns | 0.0038 |      48 B |
| EmptyApiResponse            |   3.616 ns |   0.7401 ns |  0.0406 ns | 0.0045 |      56 B |
| EmptyApiResponses           |  37.981 ns |  37.5047 ns |  2.0558 ns | 0.0197 |     248 B |
| EmptyApiSchema              |  11.261 ns |   2.0170 ns |  0.1106 ns | 0.0325 |     408 B |
| EmptyApiSecurityRequirement |   7.887 ns |   1.3878 ns |  0.0761 ns | 0.0083 |     104 B |
| EmptyApiSecurityScheme      |   4.981 ns |   6.6272 ns |  0.3633 ns | 0.0070 |      88 B |
| EmptyApiServer              |   3.836 ns |   7.2441 ns |  0.3971 ns | 0.0038 |      48 B |
| EmptyApiServerVariable      |   3.703 ns |   1.3471 ns |  0.0738 ns | 0.0038 |      48 B |
| EmptyApiTag                 |   3.830 ns |   3.7540 ns |  0.2058 ns | 0.0038 |      48 B |

```

BenchmarkDotNet v0.15.2, Windows 11 (10.0.26100.4946/24H2/2024Update/HudsonValley)
13th Gen Intel Core i7-13700H 2.90GHz, 1 CPU, 20 logical and 14 physical cores
.NET SDK 8.0.413
  [Host]   : .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                      | Mean       | Error       | StdDev    | Gen0   | Allocated |
|---------------------------- |-----------:|------------:|----------:|-------:|----------:|
| EmptyApiCallback            |   2.835 ns |   5.0955 ns | 0.2793 ns | 0.0025 |      32 B |
| EmptyApiComponents          |   4.336 ns |   5.3098 ns | 0.2910 ns | 0.0083 |     104 B |
| EmptyApiContact             |   2.915 ns |   2.6253 ns | 0.1439 ns | 0.0038 |      48 B |
| EmptyApiDiscriminator       |   3.725 ns |   7.0269 ns | 0.3852 ns | 0.0032 |      40 B |
| EmptyDocument               | 301.248 ns | 112.3264 ns | 6.1570 ns | 0.0901 |    1136 B |
| EmptyApiEncoding            |   3.479 ns |   8.1898 ns | 0.4489 ns | 0.0045 |      56 B |
| EmptyApiExample             |   3.144 ns |   1.1887 ns | 0.0652 ns | 0.0045 |      56 B |
| EmptyApiExternalDocs        |   2.892 ns |   5.6670 ns | 0.3106 ns | 0.0032 |      40 B |
| EmptyApiHeader              |   3.898 ns |   7.8901 ns | 0.4325 ns | 0.0064 |      80 B |
| EmptyApiInfo                |   4.000 ns |   4.0371 ns | 0.2213 ns | 0.0064 |      80 B |
| EmptyApiLicense             |   2.970 ns |   1.2353 ns | 0.0677 ns | 0.0038 |      48 B |
| EmptyApiLink                |   3.778 ns |   5.6028 ns | 0.3071 ns | 0.0057 |      72 B |
| EmptyApiMediaType           |   2.912 ns |   0.5330 ns | 0.0292 ns | 0.0045 |      56 B |
| EmptyApiOAuthFlow           |   3.307 ns |   2.7900 ns | 0.1529 ns | 0.0045 |      56 B |
| EmptyApiOAuthFlows          |   3.116 ns |   3.5033 ns | 0.1920 ns | 0.0045 |      56 B |
| EmptyApiOperation           |  44.758 ns |  66.3975 ns | 3.6395 ns | 0.0299 |     376 B |
| EmptyApiParameter           |   4.735 ns |   9.1361 ns | 0.5008 ns | 0.0077 |      96 B |
| EmptyApiPathItem            |   3.447 ns |   3.2455 ns | 0.1779 ns | 0.0051 |      64 B |
| EmptyApiPaths               |  33.193 ns |  15.0617 ns | 0.8256 ns | 0.0197 |     248 B |
| EmptyApiRequestBody         |   3.004 ns |   2.9458 ns | 0.1615 ns | 0.0038 |      48 B |
| EmptyApiResponse            |   3.025 ns |   0.6471 ns | 0.0355 ns | 0.0045 |      56 B |
| EmptyApiResponses           |  33.526 ns |  20.6998 ns | 1.1346 ns | 0.0197 |     248 B |
| EmptyApiSchema              |  11.596 ns |  15.6745 ns | 0.8592 ns | 0.0325 |     408 B |
| EmptyApiSecurityRequirement |   7.382 ns |   3.2533 ns | 0.1783 ns | 0.0083 |     104 B |
| EmptyApiSecurityScheme      |   3.854 ns |   2.6641 ns | 0.1460 ns | 0.0070 |      88 B |
| EmptyApiServer              |   2.888 ns |   1.5968 ns | 0.0875 ns | 0.0038 |      48 B |
| EmptyApiServerVariable      |   3.428 ns |   6.9437 ns | 0.3806 ns | 0.0038 |      48 B |
| EmptyApiTag                 |   2.951 ns |   3.6418 ns | 0.1996 ns | 0.0038 |      48 B |

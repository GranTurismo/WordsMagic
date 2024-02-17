```

BenchmarkDotNet v0.13.12, macOS Sonoma 14.4 (23E5196e) [Darwin 23.4.0]
Apple M1, 1 CPU, 8 logical and 8 physical cores
.NET SDK 8.0.101
  [Host]     : .NET 8.0.1 (8.0.123.58001), Arm64 RyuJIT AdvSIMD
  DefaultJob : .NET 8.0.1 (8.0.123.58001), Arm64 RyuJIT AdvSIMD


```
| Method    | ProvidedData | Mean     | Error    | StdDev   | Gen0      | Allocated |
|---------- |------------- |---------:|---------:|---------:|----------:|----------:|
| Calculate | brpgejkke    | 950.2 ms | 18.30 ms | 15.28 ms | 1000.0000 |   8.42 MB |

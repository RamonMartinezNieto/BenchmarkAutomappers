```

BenchmarkDotNet v0.13.12, Windows 10 (10.0.19045.4291/22H2/2022Update)
Intel Core i5-7600K CPU 3.80GHz (Kaby Lake), 1 CPU, 4 logical and 4 physical cores
.NET SDK 8.0.202
  [Host]   : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  .NET 8.0 : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2


```
| Method      | Job      | Runtime  | Mean     | Error     | StdDev    | Median   | Gen0   | Allocated |
|------------ |--------- |--------- |---------:|----------:|----------:|---------:|-------:|----------:|
| SmallManual | .NET 7.0 | .NET 7.0 |       NA |        NA |        NA |       NA |     NA |        NA |
| SmallManual | .NET 8.0 | .NET 8.0 | 6.883 ns | 0.1691 ns | 0.4544 ns | 6.681 ns | 0.0153 |      48 B |

Benchmarks with issues:
  BenchmarkClass.SmallManual: .NET 7.0(Runtime=.NET 7.0)

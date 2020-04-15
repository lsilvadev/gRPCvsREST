## Avaliando o desempenho do gRPC x Rest no .NET Core

O benchmark oferece uma comparação entre a performance do gRPC (HTTP2) e do Rest (HTTP com JSON).

Para geração dos resultados do benchmark foi utilizado a library open-source <a href="https://github.com/dotnet/BenchmarkDotNet">BenchmarkDotNet</a>.

Para executar o benchmark, em um prompt de comando, seguir os passos abaixo.

### API Rest
cd gRPCvsREST\RestAPI
```
dotnet run -c Release
```

### Serviço gRPC
cd gRPCvsREST\GrpcService
```
dotnet run -c Release
```

### Benchmark (gRPC x Rest)
cd gRPCvsREST\Client
```
dotnet run -c Release
```

### Resultado do Benchmark

```
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18362.720 (1903/May2019Update/19H1)
Intel Core i5-3450 CPU 3.10GHz (Ivy Bridge), 1 CPU, 4 logical and 4 physical cores
.NET Core SDK=3.1.100
  [Host]     : .NET Core 3.0.1 (CoreCLR 4.700.19.51502, CoreFX 4.700.19.51609), X64 RyuJIT
  DefaultJob : .NET Core 3.0.1 (CoreCLR 4.700.19.51502, CoreFX 4.700.19.51609), X64 RyuJIT
```

|         Method | IterationCount |      Mean |     Error |    StdDev |
|--------------- |--------------- |----------:|----------:|----------:|
| GrpcGetMessage |            100 |  3.602 ms | 0.0716 ms | 0.1743 ms |
| RestGetMessage |            100 | 11.273 ms | 0.2949 ms | 0.8268 ms |
| GrpcGetMessage |            200 |  3.557 ms | 0.0711 ms | 0.1886 ms |
| RestGetMessage |            200 | 11.011 ms | 0.2198 ms | 0.5350 ms |

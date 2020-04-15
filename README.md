## Avaliando o desempenho do gRPC x Rest no .NET Core

O benchmark oferece uma comparação entre a performance do gRPC (HTTP2) e do Rest (HTTP com JSON).

Para geração dos resultados foi utilizada a library open-source <a href="https://github.com/dotnet/BenchmarkDotNet">BenchmarkDotNet</a>.

Para executar os projetos, em um prompt de comando, seguir os passos abaixo.

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
BenchmarkDotNet=v0.12.1, OS=macOS Catalina 10.15.2 (19C57) [Darwin 19.2.0]
Intel Core i5-7267U CPU 3.10GHz (Kaby Lake), 1 CPU, 4 logical and 2 physical cores
.NET Core SDK=3.0.101
  [Host]     : .NET Core 3.0.1 (CoreCLR 4.700.19.51502, CoreFX 4.700.19.51609), X64 RyuJIT
  DefaultJob : .NET Core 3.0.1 (CoreCLR 4.700.19.51502, CoreFX 4.700.19.51609), X64 RyuJIT
```

|         Method | IterationCount |       Mean |     Error |    StdDev |     Median |
|--------------- |--------------- |-----------:|----------:|----------:|-----------:|
| GrpcGetMessage |            100 |   479.8 us |  11.72 us |  32.66 us |   470.9 us |
| RestGetMessage |            100 | 1,719.9 us | 135.74 us | 395.95 us | 1,574.1 us |
| GrpcGetMessage |            200 |   506.0 us |  29.57 us |  82.43 us |   476.3 us |
| RestGetMessage |            200 | 1,706.4 us | 141.43 us | 394.24 us | 1,605.6 us |
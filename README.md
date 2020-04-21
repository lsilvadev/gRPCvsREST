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

``` ini
BenchmarkDotNet=v0.12.1, OS=macOS Catalina 10.15.2 (19C57) [Darwin 19.2.0]
Intel Core i5-7267U CPU 3.10GHz (Kaby Lake), 1 CPU, 4 logical and 2 physical cores
.NET Core SDK=3.0.101
  [Host]     : .NET Core 3.0.1 (CoreCLR 4.700.19.51502, CoreFX 4.700.19.51609), X64 RyuJIT
  DefaultJob : .NET Core 3.0.1 (CoreCLR 4.700.19.51502, CoreFX 4.700.19.51609), X64 RyuJIT
```

|         Method | IterationCount |       Mean |    Error |    StdDev |     Median |
|--------------- |--------------- |-----------:|---------:|----------:|-----------:|
| **GrpcGetMessage** |            **100** |   **569.9 μs** | **29.94 μs** |  **83.97 μs** |   **550.7 μs** |
| RestGetMessage |            100 | 1,669.5 μs | 75.02 μs | 214.04 μs | 1,582.3 μs |
| **GrpcGetMessage** |            **200** |   **572.8 μs** | **40.94 μs** | **113.46 μs** |   **529.9 μs** |
| RestGetMessage |            200 | 1,754.3 μs | 89.15 μs | 242.55 μs | 1,717.6 μs |
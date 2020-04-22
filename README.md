## Avaliando o desempenho do gRPC x Rest no .NET Core

O benchmark oferece uma comparação entre a performance do gRPC (HTTP2 com Protobuf) e do Rest (HTTP com JSON).

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

|         Method | IterationCount |       Mean |     Error |    StdDev |     Median |
|--------------- |--------------- |-----------:|----------:|----------:|-----------:|
| **GrpcGetMessage** |            **100** |   **529.1 μs** |  **33.57 μs** |  **92.46 μs** |   **488.9 μs** |
| RestGetMessage |            100 | 1,672.9 μs | 134.39 μs | 370.14 μs | 1,578.7 μs |
| **GrpcGetMessage** |            **200** |   **502.1 μs** |  **19.31 μs** |  **55.70 μs** |   **485.5 μs** |
| RestGetMessage |            200 | 1,321.6 μs |  43.17 μs | 117.45 μs | 1,274.3 μs |

Tempo de execução: 00:05:33 (333.29 segundos)

#### Legenda
- IterationCount: valor do parâmetro 'IterationCount'
- Mean: média aritmética de todas as medições
- Error: metade do intervalo de confiança de 99,9%
- StdDev: desvio padrão de todas as medições
- Median: valor que separa a metade mais alta de todas as medições
- 1 us: 1 microssegundo (0.000001 segundo)

<img src="https://github.com/lsilvadev/gRPCvsREST/blob/master/Image/Client.BenchmarkTest-barplot.png" width="600" alt="Gráfico">



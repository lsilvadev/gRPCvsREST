## Avaliando o desempenho do gRPC x Rest no .NET Core

Para executar o benchmark, em um prompt de comando, seguir os passos abaixo.

### API Rest
cd gRPCvsREST\RestAPI
```
dotnet run -c Release
```

### Serviço gRPC
cd gRPCvsREST\GrpcAPI
```
dotnet run -c Release
```

### Executa o benchmark nos serviços (gRPC e Rest)
cd gRPCvsREST\Client
```
dotnet run -c Release
```

``` ini
BenchmarkDotNet=v0.11.5, OS=Windows 10.0.18362
```

| Method                         | IterationCount |         Mean |         Error |        StdDev |
| ------------------------------ | -------------- | -----------: | ------------: | ------------: |
| GrpcGetMessage                 |   50           |         0 ms |          0 ms |          0 ms |
| RestGetMessage                 |   50           |         0 ms |          0 ms |          0 ms |
| GrpcGetMessage                 |  100           |         0 ms |          0 ms |          0 ms |
| RestGetMessage                 |  100           |         0 ms |          0 ms |          0 ms |


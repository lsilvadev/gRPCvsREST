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

### Benchmark nos Serviços (gRPC x Rest)
cd gRPCvsREST\Client
```
dotnet run -c Release
```

### Resultado do Benchmark
Em breve...

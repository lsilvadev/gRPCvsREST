using System;
using System.Threading.Tasks;
using GrpcAPI;
using Grpc.Net.Client;

namespace Client
{
    class GrpcClient
    {
        public async Task<string> GetMessage()
        {
            // // macOS
            // // https://docs.microsoft.com/pt-br/aspnet/core/grpc/troubleshoot?view=aspnetcore-3.1#call-insecure-grpc-services-with-net-core-client
            // // This switch must be set before creating the GrpcChannel/HttpClient.
            // AppContext.SetSwitch("System.Net.Http.SocketsHttpHandler.Http2UnencryptedSupport", true);

            // The port number(5001) must match the port of the gRPC server.
            var channel = GrpcChannel.ForAddress("https://localhost:5001");
            // macOS
            // var channel = GrpcChannel.ForAddress("http://localhost:5000");

            var client = new GrpcTest.GrpcTestClient(channel);
            var reply = await client.GetMessageAsync(
                              new MessageRequest { Name = "gRPC API" });
            return reply.Message;
        }
    }
}
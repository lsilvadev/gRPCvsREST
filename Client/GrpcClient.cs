using System.Threading.Tasks;
using GrpcService;
using Grpc.Net.Client;

namespace Client
{
    class GrpcClient
    {
        private readonly GrpcChannel channel;
        private readonly GrpcTest.GrpcTestClient client;

        public GrpcClient()
        {          
            // The port number(5001) must match the port of the gRPC server.
            channel = GrpcChannel.ForAddress("https://localhost:5001");
            // macOS
            // var channel = GrpcChannel.ForAddress("http://localhost:5000");
            
            client = new GrpcTest.GrpcTestClient(channel);
        }        
        public async Task GetMessage()
        {
            // // macOS
            // // https://docs.microsoft.com/pt-br/aspnet/core/grpc/troubleshoot?view=aspnetcore-3.1#call-insecure-grpc-services-with-net-core-client
            // // This switch must be set before creating the GrpcChannel/HttpClient.
            // AppContext.SetSwitch("System.Net.Http.SocketsHttpHandler.Http2UnencryptedSupport", true);

            await client.GetMessageAsync(new MessageRequest { Name = "gRPC Service" });
        }
    }
}
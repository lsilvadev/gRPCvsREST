using System;
using System.Threading.Tasks;
using GrpcAPI;
using Grpc.Net.Client;

namespace Client
{
    class GrpcClient
    {
        public static void GetMessageFor()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            string message = "";

            for (int i = 0; i < 500; i++)
            {
                message = GetMessage().Result;
            }

            watch.Stop();
            var milliseconds = watch.ElapsedMilliseconds;

            Console.WriteLine(message + " | " + milliseconds + " ms");
        }

        private static async Task<string> GetMessage()
        {
            // This switch must be set before creating the GrpcChannel/HttpClient.
            //AppContext.SetSwitch("System.Net.Http.SocketsHttpHandler.Http2UnencryptedSupport", true);

            // The port number(5001) must match the port of the gRPC server.
            var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new GrpcTest.GrpcTestClient(channel);
            var reply = await client.GetMessageAsync(
                              new MessageRequest { Name = "gRPC API" });
            return reply.Message;
        }
    }
}
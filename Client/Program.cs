using System;
using System.Net.Http;
using System.Threading.Tasks;
using GrpcAPI;
using Grpc.Net.Client;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            GrpcClient.GetMessageFor();
            RestClient.GetMessageFor();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
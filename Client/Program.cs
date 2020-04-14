using BenchmarkDotNet.Running;
using System;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<BenchmarkTest>();
            //Console.ReadKey();
            //GrpcClient client = new GrpcClient();
            //client.GetMessageFor();
            /*RestClient.GetMessageFor();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();*/
        }
    }
}
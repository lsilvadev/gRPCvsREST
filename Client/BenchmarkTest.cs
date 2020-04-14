using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Validators;
using System.Threading.Tasks;

namespace Client
{
    [RPlotExporter]
    [AsciiDocExporter]
    [CsvExporter]
    [HtmlExporter]
    public class BenchmarkTest
    {
        [Params(50, 100)]
        public int IterationCount;
        readonly GrpcClient grpc = new GrpcClient();
        readonly RestClient rest = new RestClient();

        [Benchmark]
        public async Task GrpcGetMessage()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                await grpc.GetMessage();
            }
        }

        [Benchmark]
        public string RestGetMessage()
        {
            string message = "";

            for (int i = 0; i < IterationCount; i++)
            {
                message = rest.GetMessage();
            }

            return message;
        }
    }
}
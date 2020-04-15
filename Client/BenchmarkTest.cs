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
        [Params(100, 200)]
        public int IterationCount;
        readonly GrpcClient grpc = new GrpcClient();
        readonly RestClient rest = new RestClient();

        [Benchmark]
        public async Task GrpcGetMessage()
        {
            await grpc.GetMessage();
        }

        [Benchmark]
        public async Task RestGetMessage()
        {
            await rest.GetMessage();
        }
    }
}
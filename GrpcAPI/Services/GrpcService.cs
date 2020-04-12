using System.Threading.Tasks;
using Grpc.Core;
using Microsoft.Extensions.Logging;

namespace GrpcAPI
{
    public class GrpcService : GrpcTest.GrpcTestBase
    {
        private readonly ILogger<GrpcService> _logger;
        public GrpcService(ILogger<GrpcService> logger)
        {
            _logger = logger;
        }

        public override Task<MessageReply> GetMessage(MessageRequest request, ServerCallContext context)
        {
            return Task.FromResult(new MessageReply
            {
                Message = request.Name
            });
        }
    }
}

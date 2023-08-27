using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

using System.Threading;
using System.Threading.Tasks;

namespace BTradePlatServer.Core
{
    class BTradePlatServer : BackgroundService, IBTradePlatServer
    {
        private readonly ILogger<BTradePlatServer> _logger;
        public BTradePlatServer(ILogger<BTradePlatServer> logger)
        {

        }
        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            { 

            }
        }
    }
}

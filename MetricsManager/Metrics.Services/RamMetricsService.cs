using Metrics.Services.Interfaces;
using System;


namespace Metrics.Services
{
    public class RamMetricsService : IRamMetricsService
    {
        public long GetMetricsFromAgent(int agentId, TimeSpan fromTime, TimeSpan toTime)
        {
            throw new NotImplementedException();
        }
    }
}

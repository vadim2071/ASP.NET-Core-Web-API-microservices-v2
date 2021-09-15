using System;
using Metrics.Services.Interfaces;

namespace Metrics.Services
{
    public class CpuMetricsService : ICpuMetricsService
    {
        public long GetMetricsFromAgent(int agentId, TimeSpan fromTime, TimeSpan toTime)
        {
            throw new NotImplementedException();
        }
    }
}

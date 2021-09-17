using Metrics.Services.Interfaces;
using System;


namespace Metrics.Services
{
    public class HddMetricsService : IHddMetricsService
    {
        public long GetMetricsFromAgent(int agentId, TimeSpan fromTime, TimeSpan toTime)
        {
            throw new NotImplementedException();
        }
    }
}

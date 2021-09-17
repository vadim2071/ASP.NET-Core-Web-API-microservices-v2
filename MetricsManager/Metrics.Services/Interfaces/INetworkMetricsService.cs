using System;


namespace Metrics.Services.Interfaces
{
    public interface INetworkMetricsService
    {
        long GetMetricsFromAgent(int agentId, TimeSpan fromTime, TimeSpan toTime);
    }
}

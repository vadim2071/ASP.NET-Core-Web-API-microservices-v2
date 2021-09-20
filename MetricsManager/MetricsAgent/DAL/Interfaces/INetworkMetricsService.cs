using System;


namespace MetricsAgent.DAL.Interfaces
{
    public interface INetworkMetricsService
    {
        long GetMetricsFromAgent(int agentId, TimeSpan fromTime, TimeSpan toTime);
    }
}

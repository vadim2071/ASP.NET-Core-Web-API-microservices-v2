using System;


namespace MetricsAgent.DAL.Interfaces
{
    public interface INetworkMetricsService
    {
        long GetMetricsFromAgent(int agentId, DateTime fromTime, DateTime toTime);
    }
}

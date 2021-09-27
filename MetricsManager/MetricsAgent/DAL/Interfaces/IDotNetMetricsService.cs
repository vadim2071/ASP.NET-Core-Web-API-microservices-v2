using System;


namespace MetricsAgent.DAL.Interfaces
{
    public interface IDotNetMetricsService
    {
        long GetMetricsFromAgent(int agentId, DateTime fromTime, DateTime toTime);
    }
}

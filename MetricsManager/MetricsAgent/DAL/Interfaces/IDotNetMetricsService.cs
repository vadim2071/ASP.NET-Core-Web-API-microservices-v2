using System;


namespace MetricsAgent.DAL.Interfaces
{
    public interface IDotNetMetricsService
    {
        long GetMetricsFromAgent(int agentId, TimeSpan fromTime, TimeSpan toTime);
    }
}

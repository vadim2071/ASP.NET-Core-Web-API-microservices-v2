using System;


namespace MetricsAgent.DAL.Interfaces
{
    public interface IHddMetricsService
    {
        long GetMetricsFromAgent(int agentId, DateTime fromTime, DateTime toTime);
    }
}

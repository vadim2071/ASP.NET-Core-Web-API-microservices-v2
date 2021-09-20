using System;


namespace MetricsAgent.DAL.Interfaces
{
    public interface IHddMetricsService
    {
        long GetMetricsFromAgent(int agentId, TimeSpan fromTime, TimeSpan toTime);
    }
}

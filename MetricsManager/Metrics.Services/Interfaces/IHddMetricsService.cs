using System;


namespace Metrics.Services.Interfaces
{
    public interface IHddMetricsService
    {
        long GetMetricsFromAgent(int agentId, TimeSpan fromTime, TimeSpan toTime);
    }
}

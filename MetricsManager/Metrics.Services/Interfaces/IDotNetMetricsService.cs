using System;


namespace Metrics.Services.Interfaces
{
    public interface IDotNetMetricsService
    {
        long GetMetricsFromAgent(int agentId, TimeSpan fromTime, TimeSpan toTime);
    }
}

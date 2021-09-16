using System;


namespace Metrics.Services.Interfaces
{
    public interface ICpuMetricsService
    {
        long GetMetricsFromAgent(int agentId, TimeSpan fromTime, TimeSpan toTime); // long из-за отсутсвия модели DTO
    }
}

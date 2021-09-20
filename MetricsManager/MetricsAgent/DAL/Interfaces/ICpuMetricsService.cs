using System;


namespace MetricsAgent.DAL.Interfaces
{
    public interface ICpuMetricsService
    {
        long GetMetricsFromAgent(int agentId, TimeSpan fromTime, TimeSpan toTime); // long из-за отсутсвия модели DTO
    }
}

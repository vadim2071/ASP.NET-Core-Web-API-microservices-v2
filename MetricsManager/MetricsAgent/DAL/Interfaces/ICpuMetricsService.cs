using System;


namespace MetricsAgent.DAL.Interfaces
{
    public interface ICpuMetricsService
    {
        long GetMetricsFromAgent(int agentId, DateTime fromTime, DateTime toTime); // long из-за отсутсвия модели DTO
    }
}

using System;


namespace MetricsAgent.DAL.Interfaces
{
    public interface IRamMetricsService
    {
        long GetMetricsFromAgent(int agentId, DateTime fromTime, DateTime toTime); // long из-за отсутсвия модели DTO
    }
}

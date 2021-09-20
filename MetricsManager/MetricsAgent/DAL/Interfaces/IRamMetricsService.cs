using System;


namespace MetricsAgent.DAL.Interfaces
{
    public interface IRamMetricsService
    {
        long GetMetricsFromAgent(int agentId, TimeSpan fromTime, TimeSpan toTime); // long из-за отсутсвия модели DTO
    }
}

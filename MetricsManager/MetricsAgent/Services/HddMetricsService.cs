using MetricsAgent.DAL.Interfaces;
using System;


namespace MetricsAgent.Services
{
    public class HddMetricsService : IHddMetricsService
    {
        public long GetMetricsFromAgent(int agentId, DateTime fromTime, DateTime toTime)
        {
            throw new NotImplementedException();
        }
    }
}

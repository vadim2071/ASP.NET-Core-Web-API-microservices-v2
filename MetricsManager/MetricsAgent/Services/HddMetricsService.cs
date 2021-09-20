using MetricsAgent.DAL.Interfaces;
using System;


namespace MetricsAgent.Services
{
    public class HddMetricsService : IHddMetricsService
    {
        public long GetMetricsFromAgent(int agentId, TimeSpan fromTime, TimeSpan toTime)
        {
            throw new NotImplementedException();
        }
    }
}

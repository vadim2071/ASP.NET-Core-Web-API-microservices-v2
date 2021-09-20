using MetricsAgent.DAL.Interfaces;
using System;


namespace MetricsAgent.Services
{
    public class DotNetMetricsService : IDotNetMetricsService
    {
        public long GetMetricsFromAgent(int agentId, TimeSpan fromTime, TimeSpan toTime)
        {
            throw new NotImplementedException();
        }
    }
}

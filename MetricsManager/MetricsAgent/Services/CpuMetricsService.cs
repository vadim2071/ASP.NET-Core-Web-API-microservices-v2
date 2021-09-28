using Metrics.Services.Repository;
using MetricsAgent.DAL.Interfaces;
using MetricsAgent.DAL.Models;
using System;
using System.Collections.Generic;

namespace MetricsAgent.Services
{
    public class CpuMetricsService : ICpuMetricsService
    {
        public long GetMetricsFromAgent(int agentId, DateTime fromTime, DateTime toTime)
        {
            throw new NotImplementedException();
        }
    }
}

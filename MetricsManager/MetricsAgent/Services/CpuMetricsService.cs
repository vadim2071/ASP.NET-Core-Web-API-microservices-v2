﻿using MetricsAgent.DAL.Interfaces;
using System;


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
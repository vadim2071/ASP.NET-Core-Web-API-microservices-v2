﻿using System;
using System.Collections.Generic;


namespace MetricsAgent.Responses
{
    public class AllNetworkMetricsResponse
    {
        public List<NetworkMetricDTO> Metrics { get; set; }
    }
    public class NetworkMetricDTO
    {
        public TimeSpan Time { get; set; }
        public int Value { get; set; }
        public int Id { get; set; }
    }
}

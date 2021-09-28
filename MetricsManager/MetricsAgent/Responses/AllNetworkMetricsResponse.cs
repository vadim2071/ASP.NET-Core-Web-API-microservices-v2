using System;
using System.Collections.Generic;


namespace MetricsAgent.Responses
{
    public class AllNetworkMetricsResponse
    {
        public List<NetworkMetricDTO> Metrics { get; set; }
    }
    public class NetworkMetricDTO : baseMetricDTO
    {
    }
}

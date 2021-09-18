using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

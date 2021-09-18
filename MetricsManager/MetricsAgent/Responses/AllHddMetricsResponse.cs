using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetricsAgent.Responses
{
    public class AllHddMetricsResponse
    {
        public List<HddMetricDTO> Metrics { get; set; }
    }
    public class HddMetricDTO
    {
        public TimeSpan Time { get; set; }
        public int Value { get; set; }
        public int Id { get; set; }
    }
}

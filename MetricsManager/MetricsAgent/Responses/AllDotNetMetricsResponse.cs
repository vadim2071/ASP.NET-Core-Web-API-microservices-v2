using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetricsAgent.Responses
{
    public class AllDotNetMetricsResponse
    {
        public List<DotNetMetricDTO> Metrics { get; set; }
    }

    public class DotNetMetricDTO
    {
        public TimeSpan Time { get; set; }
        public int Value { get; set; }
        public int Id { get; set; }
    }
}

using System;
using System.Collections.Generic;


namespace MetricsAgent.Responses
{
    public class AllDotNetMetricsResponse
    {
        public List<DotNetMetricDTO> Metrics { get; set; }
    }

    public class DotNetMetricDTO
    {
        public DateTime Time { get; set; }
        public int Value { get; set; }
        public int Id { get; set; }
    }
}

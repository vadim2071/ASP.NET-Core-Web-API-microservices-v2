using System;
using System.Collections.Generic;


namespace MetricsAgent.Responses
{
    public class AllHddMetricsResponse
    {
        public List<HddMetricDTO> Metrics { get; set; }
    }
    public class HddMetricDTO
    {
        public DateTime Time { get; set; }
        public int Value { get; set; }
        public int Id { get; set; }
    }
}

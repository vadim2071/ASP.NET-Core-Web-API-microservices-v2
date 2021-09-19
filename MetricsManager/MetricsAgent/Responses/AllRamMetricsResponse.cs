using System;
using System.Collections.Generic;


namespace MetricsAgent.Responses
{
    public class AllRamMetricsResponse
    {
        public List<RamMetricDTO> Metrics { get; set; }
    }
    public class RamMetricDTO
    {
        public DateTime Time { get; set; }
        public int Value { get; set; }
        public int Id { get; set; }
    }
}

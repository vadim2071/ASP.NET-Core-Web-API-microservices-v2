using System;
using System.Collections.Generic;

namespace MetricsAgent.Responses
{
    public class AllCpuMetricsResponse
    {
        public List<CpuMetricDTO> Metrics { get; set; }
    }
    public class CpuMetricDTO
    {
        public DateTime Time { get; set; }
        public int Value { get; set; }
        public int Id { get; set; }
    }
}

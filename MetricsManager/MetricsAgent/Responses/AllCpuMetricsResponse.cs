using System;
using System.Collections.Generic;

namespace MetricsAgent.Responses
{
    public class AllCpuMetricsResponse 
    {
        public List<CpuMetricDTO> Metrics { get; set; }
    }
    public class CpuMetricDTO : baseMetricDTO
    {
    }
}

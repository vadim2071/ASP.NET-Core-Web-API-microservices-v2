using System;
using System.Collections.Generic;


namespace MetricsAgent.Responses
{
    public class AllRamMetricsResponse
    {
        public List<RamMetricDTO> Metrics { get; set; }
    }
    public class RamMetricDTO : baseMetricDTO
    {
    }
}

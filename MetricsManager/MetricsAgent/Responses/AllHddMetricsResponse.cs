using System;
using System.Collections.Generic;


namespace MetricsAgent.Responses
{
    public class AllHddMetricsResponse
    {
        public List<HddMetricDTO> Metrics { get; set; }
    }
    public class HddMetricDTO : baseMetricDTO
    {
    }
}

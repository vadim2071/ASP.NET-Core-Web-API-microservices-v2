using Metrics.Services.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using MetricsAgent.Responses;


namespace MetricsAgent.Controllers
{
    [Route("api/metrics/hdd/left[Controller]")]
    [ApiController]
    public class HddMetricsController : ControllerBase
    {
        private readonly ILogger<HddMetricsController> _logger;

        public HddMetricsController(ILogger<HddMetricsController> logger)
        {
            _logger = logger;
            _logger.LogDebug(1, "NLog встроен в HddMetricsController");
        }
        private IHddMetricsRepository repository;
        public HddMetricsController(IHddMetricsRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet("from/{fromTime}/to/{toTime}")]
        public IActionResult GetMetrics([FromRoute] DateTime fromTime, [FromRoute] DateTime toTime)
        {
            _logger.LogInformation("Привет! Это наше первое сообщение в лог HddMetricsController");
            var metrics = repository.GetAll();

            var response = new AllHddMetricsResponse()
            {
                Metrics = new List<HddMetricDTO>()
            };

            foreach (var metric in metrics)
            {
                response.Metrics.Add(new HddMetricDTO { Time = metric.Time, Value = metric.Value, Id = metric.Id });
            }
            return Ok();
        }

    }
}

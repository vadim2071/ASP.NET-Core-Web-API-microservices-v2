using Metrics.Services.Repository;
using MetricsAgent.Responses;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;


namespace MetricsAgent.Controllers
{
    [Route("api/metrics/ram/available[Controller]")]
    [ApiController]
    public class RamMetricsController : ControllerBase
    {
        private readonly ILogger<RamMetricsController> _logger;

        public RamMetricsController(ILogger<RamMetricsController> logger)
        {
            _logger = logger;
            _logger.LogDebug(1, "NLog встроен в RamMetricsController");
        }

        private IRamMetricsRepository repository;
        public RamMetricsController(IRamMetricsRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet("from/{fromTime}/to/{toTime}")]
        public IActionResult GetMetrics([FromRoute] DateTime fromTime, [FromRoute] DateTime toTime)

        {
            _logger.LogInformation("Привет! Это наше первое сообщение в лог от RamMetricsController");
            var metrics = repository.GetAll();

            var response = new AllRamMetricsResponse()
            {
                Metrics = new List<RamMetricDTO>()
            };

            foreach (var metric in metrics)
            {
                response.Metrics.Add(new RamMetricDTO { Time = metric.Time, Value = metric.Value, Id = metric.Id });
            }
            return Ok();
        }

    }
}

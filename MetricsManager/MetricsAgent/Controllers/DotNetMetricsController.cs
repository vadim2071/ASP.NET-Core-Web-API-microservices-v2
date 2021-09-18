using Metrics.Services.Repository;
using MetricsAgent.Responses;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;

namespace MetricsAgent.Controllers
{
    [Route("api/metrics/dotnet/errors-count[Controller]")]
    [ApiController]
    public class DotNetMetricsController : ControllerBase
    {
        private readonly ILogger<DotNetMetricsController> _logger;

        public DotNetMetricsController(ILogger<DotNetMetricsController> logger)
        {
            _logger = logger;
            _logger.LogDebug(1, "NLog встроен в DotNetMetricsController");
        }

        private IDotNetMetricsRepository repository;
        public DotNetMetricsController(IDotNetMetricsRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet("from/{fromTime}/to/{toTime}")]
        public IActionResult GetMetrics([FromRoute] TimeSpan fromTime,[FromRoute] TimeSpan toTime)
        {
            _logger.LogInformation("Привет! Это наше первое сообщение в лог DotNetMetricsController");
            var metrics = repository.GetAll();

            var response = new AllDotNetMetricsResponse()
            {
                Metrics = new List<DotNetMetricDTO>()
            };

            foreach (var metric in metrics)
            {
                response.Metrics.Add(new DotNetMetricDTO { Time = metric.Time, Value = metric.Value, Id = metric.Id });
            }

            return Ok();
        }

    }
}

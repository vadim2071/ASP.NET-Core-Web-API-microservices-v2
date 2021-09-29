using MetricsAgent.Services;
using MetricsAgent.DAL.Models;
using MetricsAgent.Responses;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using AutoMapper;
using MetricsAgent.Request;
using MetricsAgent.DAL.Repositories;

namespace MetricsAgent.Controllers
{
    public abstract class BaseMetricsContoller<LoggerType, RepositoryType, CreateRequest> : ControllerBase 
        where LoggerType : BaseMetricsContoller<LoggerType, RepositoryType, CreateRequest> 
        where RepositoryType : baseMetric
        where CreateRequest : BaseMetricsCreateRequest
    {
        
        protected readonly ILogger<LoggerType> _logger;
        protected readonly BaseMetricsRepository<RepositoryType> repository;
        protected readonly IMapper mapper;

        public BaseMetricsContoller(BaseMetricsRepository<RepositoryType> repository, ILogger<LoggerType> logger, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
            _logger = logger;
        }

        [HttpGet("all")] ////// закончил здесь 29.09
        public IActionResult GetAll()
        {
            IList<RepositoryType> metrics = repository.GetAll();
            var response = new AllCpuMetricsResponse()
            {
                Metrics = new List<CpuMetricDTO>()
            };
            foreach (var metric in metrics)
            {
                response.Metrics.Add(mapper.Map<CpuMetricDTO>(metric));
            }
            return Ok(response);
        }



        [HttpGet("from/{fromTime}/to/{toTime}")]
        public IActionResult GetMetrics([FromRoute] TimeSpan fromTime, [FromRoute] TimeSpan toTime)
        {
            //_logger.LogInformation("Привет! Это наше первое сообщение в лог CpuMetricsController");
            var metrics = repository.GetAll();

            var response = new AllCpuMetricsResponse()
            {
                Metrics = new List<CpuMetricDTO>()
            };

            foreach (var metric in metrics)
            {
                response.Metrics.Add(new CpuMetricDTO { Time = metric.Time, Value = metric.Value, Id = metric.Id });
            }
            return Ok(response);
        }
    }
}

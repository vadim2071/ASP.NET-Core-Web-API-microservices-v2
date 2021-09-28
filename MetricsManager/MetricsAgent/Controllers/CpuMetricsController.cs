using Metrics.Services.Repository;
using MetricsAgent.Services;
using MetricsAgent.DAL.Models;
using MetricsAgent.Responses;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using AutoMapper;

namespace MetricsAgent.Controllers
{
    [Route("api/metrics/cpu[Controller]")]
    [ApiController]
    public class CpuMetricsController : ControllerBase
    {
        private ICpuMetricsRepository repository;

        private readonly IMapper mapper;

        private readonly ILogger<CpuMetricsController> _logger;

        public CpuMetricsController(ICpuMetricsRepository repository, ILogger<CpuMetricsController> logger, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
            _logger = logger;
        }

        [HttpGet("all")]
        public IActionResult GetAll()
        {
            IList<CpuMetric> metrics = repository.GetAll();
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
        public IActionResult GetMetrics([FromRoute] TimeSpan fromTime,[FromRoute] TimeSpan toTime)
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

        [HttpGet("sql-read-write-test")] //тест записи в базу и чтения
        public IActionResult TryToInsertAndRead()
        {
            //записываем 4 набора данных
            var record1 = new CpuMetric();
            record1.Time = new DateTime(100);
            record1.Value = 50;
            repository.Create(record1);

            var record2 = new CpuMetric();
            record2.Time = new DateTime(102);
            record2.Value = 55;
            repository.Create(record2);

            var record3 = new CpuMetric();
            record3.Time = new DateTime(110);
            record3.Value = 75;
            repository.Create(record3);

            var record4 = new CpuMetric();
            record4.Time = new DateTime(150);
            record4.Value = 27;
            repository.Create(record4);

            // создаем массив, в который запишем объекты с данными из базы данных
            var returnArray = repository.GetAll();

            // оборачиваем массив с данными в объект ответа и возвращаем пользователю 
            return Ok(returnArray);

        }


    }
}

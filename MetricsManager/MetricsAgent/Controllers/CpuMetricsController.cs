using Metrics.Services.Repository;
using MetricsAgent.DAL.Models;
using MetricsAgent.Responses;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;


namespace MetricsAgent.Controllers
{
    [Route("api/metrics/cpu[Controller]")]
    [ApiController]
    public class CpuMetricsController : ControllerBase
    {
        private readonly ILogger<CpuMetricsController> _logger;

        public CpuMetricsController(ILogger<CpuMetricsController> logger)
        {
            _logger = logger;
            _logger.LogDebug(1, "NLog встроен в CpuMetricsController");
        }

        private ICpuMetricsRepository repository;
        public CpuMetricsController(ICpuMetricsRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet("sql-read-write-test")]
        public IActionResult TryToInsertAndRead()
        {
            var record1 = new CpuMetric();
            record1.Time = new TimeSpan(100);
            record1.Value = 50;
            repository.Create(record1);
            
            var record2 = new CpuMetric();
            record1.Time = new TimeSpan(102);
            record1.Value = 55;
            repository.Create(record2); 
            
            var record3 = new CpuMetric();
            record1.Time = new TimeSpan(110);
            record1.Value = 75;
            repository.Create(record3);

            var record4 = new CpuMetric();
            record1.Time = new TimeSpan(150);
            record1.Value = 27;
            repository.Create(record4);

            // создаем соединение с базой данных
            using (var connection = new SQLiteConnection(connectionString))
            {
                {
                    
                    // создаем строку для выборки данных из базы
                    // LIMIT 3 обозначает, что мы достанем только 3 записи
                    string readQuery = "SELECT * FROM cpumetrics LIMIT 3";

                    // создаем массив, в который запишем объекты с данными из базы данных
                    var returnArray = new CpuMetric[3];
                    // изменяем текст команды на наш запрос чтения
                    command.CommandText = readQuery;

                    // создаем читалку из базы данных
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        // счетчик для того, чтобы записать объект в правильное место в массиве
                        var counter = 0;
                        // цикл будет выполняться до тех пор, пока есть что читать из базы данных
                        while (reader.Read())
                        {
                            // создаем объект и записываем его в массив
                            returnArray[counter] = new CpuMetric
                            {
                                Id = reader.GetInt32(0), // читаем данные полученные из базы данных
                                Value = reader.GetInt32(1), // преобразуя к целочисленному типу
                                Time = reader.GetInt64(2)
                            };
                            // увеличиваем значение счетчика
                            counter++;
                        }
                    }
                    // оборачиваем массив с данными в объект ответа и возвращаем пользователю 
                    return Ok(returnArray);
                }
            }
        }

        [HttpGet("from/{fromTime}/to/{toTime}")]
        public IActionResult GetMetrics([FromRoute] TimeSpan fromTime,[FromRoute] TimeSpan toTime)
        {
            _logger.LogInformation("Привет! Это наше первое сообщение в лог CpuMetricsController");
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

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetricsManager.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AgentsController : ControllerBase
    {
        private readonly ILogger<AgentsController> _logger;

        public AgentsController(ILogger<AgentsController> logger)
        {
            _logger = logger;
            _logger.LogDebug(1, "NLog встроен в AgentsController");
        }

        [HttpPost("register")] //решгистрация агента
        public IActionResult RegisterAgent([FromBody] AgentCreateDto agentInfo)
        {
            _logger.LogInformation("Привет! Это наше первое сообщение в лог от AgentsController RegisterAgent");
            return Ok();
        }

        [HttpPut("enable/{agentId}")] //включение агента
        public IActionResult EnableAgentById([FromRoute] int agentId)
        {
            _logger.LogInformation("Привет! Это наше первое сообщение в лог от AgentsController EnableAgentById");
            return Ok();
        }

        [HttpPut("disable/{agentId}")] //отключение агента
        public IActionResult DisableAgentById([FromRoute] int agentId)
        {
            _logger.LogInformation("Привет! Это наше первое сообщение в лог от AgentsController DisableAgentById");
            return Ok();
        }

        [HttpGet()] //получение списка объектов
        public IActionResult GetListAgentId()
        {
            _logger.LogInformation("Привет! Это наше первое сообщение в лог от AgentsController GetListAgentId");
            return Ok();
        }
    }

    public class AgentCreateDto
    {
        private Uri uri;

        //public int AgentId { get; }

        public Uri AgentAddress { get;}
        public AgentCreateDto(Uri uri)
        {
            this.uri = uri;
        }
    }

}

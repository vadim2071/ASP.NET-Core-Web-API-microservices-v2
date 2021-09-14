using Microsoft.AspNetCore.Mvc;
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
        [HttpPost("register")] //решгистрация агента
        public IActionResult RegisterAgent([FromBody] AgentCreateDto agentInfo)
        {
            return Ok();
        }

        [HttpPut("enable/{agentId}")] //включение агента
        public IActionResult EnableAgentById([FromRoute] int agentId)
        {
            return Ok();
        }

        [HttpPut("disable/{agentId}")] //отключение агента
        public IActionResult DisableAgentById([FromRoute] int agentId)
        {
            return Ok();
        }

        [HttpGet()] //получение списка объектов
        public IActionResult GetListAgentId()
        {
            return Ok();
        }
    }

    public class AgentCreateDto
    {
        //public int AgentId { get; }

        public Uri AgentAddress { get; }
    }

}

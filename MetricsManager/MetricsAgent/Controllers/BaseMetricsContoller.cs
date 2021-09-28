using Metrics.Services.Repository;
using MetricsAgent.Services;
using MetricsAgent.DAL.Models;
using MetricsAgent.Responses;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using AutoMapper;
using MetricsAgent.Request;

namespace MetricsAgent.Controllers
{
    public abstract class BaseMetricsContoller<LoggerType, RepositoryType, CreateRequest> : ControllerBase where LoggerType : BaseMetricsContoller<LoggerType, RepositoryType, CreateRequest> where RepositoryType :    where CreateRequest : BaseMetricsCreateRequest
    {
    }
}

﻿using AutoMapper;
using MetricsAgent.DAL.Models;
using MetricsAgent.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetricsAgent.DAL
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            // добавлять сопоставления в таком стиле нужно для всех объектов 
            CreateMap<baseMetric, baseMetricDTO>();
            CreateMap<baseMetricDTO, baseMetric>();
        }
    }
}

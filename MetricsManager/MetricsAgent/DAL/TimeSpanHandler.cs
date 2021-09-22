using System;
using Dapper;
using System.Data;

namespace MetricsAgent.DAL
{
    public class TimeSpanHandler : SqlMapper.TypeHandler<TimeSpan>
    {
        // задаем хэндлер для парсинга значений в TimeSpan если таковые попадутся в наших классах моделей
        public override TimeSpan Parse(object value)
               => TimeSpan.FromSeconds((long)value);

        public override void SetValue(IDbDataParameter parameter, TimeSpan value)
            => parameter.Value = value;
    }
}

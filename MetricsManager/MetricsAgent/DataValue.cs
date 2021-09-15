using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetricsAgent
{
    public class DataValue
    {
        public class dataValue
        {
            public int Value { get; set; }
            public DateTime Time { get; set; }

            public dataValue(int value, DateTime dateTime)
            {
                Value = value;
                Time = dateTime;
            }
        }
    }
}

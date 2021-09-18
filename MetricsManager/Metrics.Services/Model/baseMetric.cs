using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metrics.Services.Model
{
    public abstract class baseMetric
    {
        public int Id { get; set; }
        public int Value { get; set; }
        public DateTime Time { get; set; }

        public baseMetric()
        {
        }

        public baseMetric (int value, DateTime dateTime)
        {
            Value = value;
            Time = dateTime;
        }
    }
}

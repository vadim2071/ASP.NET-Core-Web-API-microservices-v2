using System;


namespace MetricsAgent.DAL.Models
{
    public abstract class baseMetric
    {
        public int Id { get; set; }
        public int Value { get; set; }
        public TimeSpan Time { get; set; }

        public baseMetric()
        {
        }

        public baseMetric (int value, TimeSpan dateTime)
        {
            Value = value;
            Time = dateTime;
        }
    }
}

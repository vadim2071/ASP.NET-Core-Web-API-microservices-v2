using System;


namespace MetricsAgent.Model
{
    public class DataValue
    {
        public class dataValue
        {
            public int Value { get; set; }
            public TimeSpan Time { get; set; }

            public dataValue(int value, TimeSpan dateTime)
            {
                Value = value;
                Time = dateTime;
            }
        }
    }
}

using System;


namespace MetricsAgent.Model
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

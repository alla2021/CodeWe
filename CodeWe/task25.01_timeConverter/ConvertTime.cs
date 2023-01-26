using System;
using System.Globalization;

namespace Task2_ConvertTime
{
    public class ConvertTime
    {
        private long unixTime;

        public ConvertTime() { }

        public long UnixTime
        {
            get => this.unixTime;
            set => this.unixTime = value;
        }

        public DateTime convert(long unixTime)
        {
            DateTime dt = new DateTime(1970, 1, 1, 0, 0, 0);
            dt = dt.AddMilliseconds(unixTime).ToLocalTime();
            string dateString = dt.ToString("MM/dd/yyyy HH:mm", CultureInfo.InvariantCulture);
            DateTime dateTime = DateTime.Parse(dateString, CultureInfo.InvariantCulture);
            return dateTime;
        }

    }
}

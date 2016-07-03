using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    class Call
    {
        public const decimal PricePerMinute = 0.37M; //very expensive

        public string Date { get; set; }

        public string Time { get; set; }

        public string DialedPhone { get; set; }

        public int DurationInSeconds { get; set; }

        public Call(DateTime dateTime, string phone, int duration)
        {
            this.Date = dateTime.Date.ToString();
            this.Time = dateTime.TimeOfDay.ToString();
            this.DialedPhone = phone;
            this.DurationInSeconds = duration;
        }

        public override string ToString()
        {
            var callInfo = new StringBuilder();

            callInfo.AppendFormat($"Call:\n \tDate: {this.Date}, Time: {this.Time}\n \tDialed phone: {this.DialedPhone}," +
                                  $" Duration in seconds {this.DurationInSeconds}");

            return callInfo.ToString();
        }
    }
}

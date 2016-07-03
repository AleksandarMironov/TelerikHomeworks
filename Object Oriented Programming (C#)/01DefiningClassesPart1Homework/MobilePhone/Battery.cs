using System;
using System.Security.Cryptography;

namespace MobilePhone
{
    public class Battery
    {
        private string model;
        private double hoursIdle;
        private double hoursTalk;
        private BatteryType batteryType;


        public string Model
        {
            get
            {
                return this.model;

            }
            set
            {
                this.model = value;

            }
        }

        public double HoursIdle
        {
            get
            {
                return this.hoursIdle;
                
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Must be greater than 0");
                }
                this.hoursIdle = value;
            }
        }

        public double HoursTalk
        {
            get
            {
                return this.hoursTalk;
                
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Must be greater than 0");
                }
                this.hoursTalk = value;
            }
        }

        public BatteryType BatteryType
        {
            get
            {
                return this.batteryType;
                
            }
            set
            {
                this.batteryType = value;
            }
        }


        public Battery(string model = "No info", double hoursIdle = -1, double hoursTalk = -1, BatteryType batteryType = BatteryType.Unknown)
        {
            this.model = model;
            this.hoursIdle = hoursIdle;
            this.hoursTalk = hoursTalk;
            this.batteryType = batteryType;

        }

        public override string ToString()
        {
            return $"Battery:\n \tModel: {this.model} / BatteryType: {this.batteryType} \n \tHoursIdle: {this.hoursIdle} / HoursTalk: {this.hoursTalk}\n";
        }
    }
}
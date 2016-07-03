using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    public class Gsm
    {
        private string model;
        private string manufacturer;
        private decimal? price;
        private string owner; 
        private Battery battery;
        private Display display;
        private List<Call> callHistory = new List<Call>(); 


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

        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
                
            }
            set
            {
                this.manufacturer = value;
                
            }
        }

        public decimal? Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Price must be positive number");
                }
                this.price = value;
            }
        }

        public string Owner
        {
            get
            {
                return this.model;
                
            }
            set
            {
                this.owner = value;
                
            }
        }

        public Battery Battery
        {
            get
            {
                return this.battery;
                
            }
            set
            {
                this.battery = value;
                
            }
        }

        public Display Display
        {
            get
            {
                return this.display;
                
            }
            set
            {
                this.display = value;
                
            }
        }

        public string CallHistory
        {
            get
            {
                if (callHistory.Count == 0)
                {
                    return "Call history is empty!";
                }
                else
                {
                    var callInfo = new StringBuilder();

                    for (int i = 1; i <= callHistory.Count; i++)
                    {
                        callInfo.AppendFormat("{0}. {1}\n", i, this.callHistory[i - 1]);
                    }

                    return callInfo.ToString();
                }
            }
        }

        public void RemoveLongestCall()
        {
            int maxDurationIndex = 0;
            int maxDuration = 0;

            if (this.callHistory.Count > 0)
            {
                for (int i = 0; i < this.callHistory.Count; i++)
                {
                    if (this.callHistory[i].DurationInSeconds > maxDuration)
                    {
                        maxDuration = this.callHistory[i].DurationInSeconds;
                        maxDurationIndex = i;
                    }
                }

                this.callHistory.RemoveAt(maxDurationIndex);
            }
            else
            {
                Console.WriteLine("Call history is empty.");
            }
        }

        public static Gsm IPhone4S = new Gsm("IPhone4S", "Apple", 100000M, "Pena",
                new Battery("Ibat", 30.5, 2.5, MobilePhone.BatteryType.NiMH), new Display(4.0, 16000000));


        public Gsm(string model, string manufacturer)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Owner = null;
            this.Battery = null;
            this.Display = null;

        }

        public Gsm(string model, string manufacturer, decimal? price, string owner ,
          Battery battery , Display display)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;

            this.Price = price;
            this.Owner = owner;
            this.Battery = battery;
            this.Display = display;
        }

        public void AddCall(DateTime dateTime, string dialedNumber, int duration)
        {
            this.callHistory.Add(new Call(dateTime, dialedNumber, duration));
        }

        public void DeleteCall(int callNumber)
        {
            if (callNumber > this.callHistory.Count)
            {
                throw new ArgumentException("Missing call history. Try again");
            }

            this.callHistory.RemoveAt(callNumber - 1);
        }

        public void ClearHistory()
        {
            this.callHistory.Clear();
        }

        public decimal GetPrice()
        {
            decimal price = 0M;
            foreach (var call in this.callHistory)
            {
                price += call.DurationInSeconds / 60M * Call.PricePerMinute;
            }

            return price;
        }

        public override string ToString()
        {
            StringBuilder toStringText = new StringBuilder();  //StringBuilder is used because output can be a lot bigger
            toStringText.Append($"Model: {this.model} \nManufacturer: {this.manufacturer} \n"); //\n can be changed whit Environment.NewLine
            if (this.price != null)
            {
                toStringText.Append($"Price: {this.price} BGN \n");
            }
            if (this.owner != null)
            {
                toStringText.Append($"Owner: {this.owner} \n");
            }
            if (this.battery != null) 
            {
                toStringText.Append(this.battery.ToString());
            }
            if (this.display != null)
            {
                toStringText.Append(this.display);
            }
            return toStringText.ToString() ;
        }


    }
}

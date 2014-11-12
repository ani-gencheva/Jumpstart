using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jumpstart_homework
{
    public class Battery
    {
        private string batteryDescription;
        private double batteryLife;

        public Battery()
        {

        }
        public Battery(string batteryDescription, double batteryLife)
        {
            this.BatteryDescription = batteryDescription;
            this.BatteryLife = batteryLife;
        }
        public string BatteryDescription
        {
            get { return this.batteryDescription; }
            set
            {
                if (value == " ")
                    throw new ArgumentNullException("Description can not be null");
                else
                    this.batteryDescription = value;
            }
        }

        public double BatteryLife
        {
            get { return this.batteryLife; }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Life in Hours can not be negative");
                else
                    this.batteryLife = value;
            }
        }
        public override string ToString()
        {

            string result = null;
            if (BatteryDescription != null || BatteryLife != 0)
            {
                result = String.Format(
                "Battery Description:{0}, Battery life:{1} ", this.batteryDescription, this.BatteryLife);
            }
            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace jumpstart_homework
{
    class Laptop
    {
        private string model;
        private decimal price;
        private string manufacturer;
        private string processor;
        private int ram;
        private string graphicsCard;
        private string hdd;
        private string screen;
        private Battery laptopBattery;

        public Laptop(string model, decimal price)
        {
            this.Model = model;
            this.Price = price;
        }
        public Laptop(string model, decimal price, string manufacturer, string processor, int ram, string graphicsCard,
        string hdd, string screen, Battery laptopBattery)
            : this(model, price)
        {
            this.Manufacturer = manufacturer;
            this.Processor = processor;
            this.Ram = ram;
            this.GraphicsCard = graphicsCard;
            this.Hdd = hdd;
            this.Screen = screen;
            this.LaptopBattery = laptopBattery;
        }
        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Define the model of the laptop, please");
                else
                    this.model = value;
            }
        }
        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value < 0.00M)
                    throw new ArgumentException("Choose Price,pleace ");
                else
                    this.price = value;
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
                if (value == " ")
                    throw new ArgumentNullException("Choose the Manufacturer of the laptop, please");
                else
                    this.manufacturer = value;
            }
        }
        public string Processor
        {
            get
            {
                return this.processor;
            }
            set
            {
                if (value == " ")
                    throw new ArgumentNullException("Choose the Processor of the laptop, please");
                else
                    this.processor = value;
            }
        }
        public int Ram
        {
            get { return this.ram; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Ram can't be negative");
                else
                    this.ram = value;
            }
        }
        public string GraphicsCard
        {
            get
            {
                return this.graphicsCard;
            }
            set
            {
                if (value == " ")
                    throw new ArgumentNullException("Choose the grafics card  of the laptop, please");
                else
                    this.graphicsCard = value;
            }
        }
        public string Hdd
        {
            get
            {
                return this.hdd;
            }
            set
            {
                if (value == " ")
                    throw new ArgumentException("Define the HDD of the laptop, please");
                else
                    this.hdd = value;
            }
        }
        public string Screen
        {
            get
            {
                return this.screen;
            }
            set
            {
                if (value == " ")
                    throw new ArgumentException("Define the screen of the laptop, please");
                else
                    this.screen = value;
            }
        }


        public Battery LaptopBattery
        {
            get { return this.laptopBattery; }
            set { this.laptopBattery = value; }
        }

        public override string ToString()
        {
            if (this.Manufacturer != null || this.Processor != null || this.Ram != 0 || this.GraphicsCard != null || this.Hdd != null || this.Screen != null || this.LaptopBattery != null)
            {
                string emtyField = "empty field";
                return string.Format("Laptop( Model: {0},Price: {1}, Manufacturer: {2}, Processor: {3}, RAM: {4} GB,Graphics card: {5},HDD:{6},Screen:{7},Battery: {8}",
                this.Model, this.Price.ToString("C2", CultureInfo.CreateSpecificCulture("bg-BG")), this.Manufacturer == null ? emtyField : this.Manufacturer,
                this.Processor == null ? emtyField : this.Processor, this.Ram == 0 ? emtyField : this.Ram.ToString(), this.GraphicsCard == null ? emtyField : this.GraphicsCard,
                this.Hdd == null ? emtyField : this.Hdd, this.Screen == null ? emtyField : this.Screen, this.LaptopBattery == null ? emtyField : LaptopBattery.ToString());
            }
            else
            return string.Format("Laptop( Model: {0},Price: {1}", this.Model, this.Price.ToString("C2", CultureInfo.CreateSpecificCulture("bg-BG")));
        }
    }
}
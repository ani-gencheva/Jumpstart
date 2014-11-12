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
        private string graphicsCard;
        private int ram;
        private Battery laptopBattery;

        public Laptop(string model, decimal price)
        {
            this.Model = model;
            this.Price = price;
        }
        public Laptop(string model, decimal price, string manufacturer, string processor, string graphicsCard,
        int ram, Battery laptopBattery)
            : this(model, price)
        {
            this.Manufacturer = manufacturer;
            this.Processor = processor;
            this.GraphicsCard = graphicsCard;
            this.Ram = ram;
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
                if (value == 0.00M)
                    throw new ArgumentOutOfRangeException("Choose Price,pleace ");
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
                    throw new ArgumentNullException("Ram can't be negative");
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
        public Battery LaptopBattery
        {
            get { return this.laptopBattery; }
            set { this.laptopBattery = value; }
        }

        public override string ToString()
        {
            string emptyField = "this field is empty";
            return string.Format("Laptop( Model: {0}, Price: {1}, Manufacturer: {2}, Processor: {3}, Graphics card: {4}, RAM: {5} GB, Battery: {6}",
                this.Model, this.Price.ToString("C2",CultureInfo.GetCultureInfo("bg-BG")),this.Manufacturer == null ? emptyField : this.Manufacturer,
            this.Processor == null ? emptyField : this.Processor, this.GraphicsCard == null ? emptyField : this.GraphicsCard,
            this.Ram == 0 ? emptyField : this.Ram.ToString(), this.LaptopBattery == null ? emptyField : LaptopBattery.ToString());
        }
    }
}
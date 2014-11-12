using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jumpstart_homework
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problem 1
            Person Ivan = new Person("Ivan", 56, "ivan@abv.bg");
            Console.WriteLine(Ivan);
            Person Mariq = new Person("Mariq", 6);
            Console.WriteLine(Mariq);
            //Problem 2
            string model = "Lenovo Yoga 2 Pro";
            decimal price = 2259.00M;
            string manufacturer = "Lenovo";
            string processor = "Intel Core i5-4210U (2-core, 1.70 - 2.70 GHz, 3MB cache)";
            int ram = 8;
            string graphicsCard = "Intel HD Graphics 4400";
            string HDD = "128GB SSD";
            string screen = "13.3\" (33.78 cm) – 3200 x 1800 (QHD+), IPS sensor display";
            string batteryDescription = "Li-Ion, 4-cells, 2550 mAh";
            double batteryLife = 4.5;

            Battery laptopBattery = new Battery(batteryDescription, batteryLife);

            Laptop LenovoHDGraphics = new Laptop(model, price, manufacturer, processor, ram, graphicsCard, HDD, screen, laptopBattery);
            Console.WriteLine(LenovoHDGraphics);
            Laptop LenovoCoreI5 = new Laptop(model, price, manufacturer, processor, 0, null, HDD, null, null);
            Console.WriteLine(LenovoCoreI5);


            Laptop HP = new Laptop("HP 250 G2", 699.00m);
            Console.WriteLine(HP);
        }
    }
}
   

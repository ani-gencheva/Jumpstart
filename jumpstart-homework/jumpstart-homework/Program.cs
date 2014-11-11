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
            Person Ivan = new Person("Ivan", 56, "ivan@abv.bg");
            Console.WriteLine(Ivan);
            string model = "Lenovo Yoga 2 Pro";
            decimal price = 2259.00M;
            string manufacturer = "Lenovo";
            string processor = "Intel Core i5-4210U (2-core, 1.70 - 2.70 GHz, 3MB cache)";
            int ram = 8;
            string graphicsCard = "Intel HD Graphics 4400";
            string batteryDescription = "Li-Ion, 4-cells, 2550 mAh";
            double batteryLife = 4.5;

            Battery laptopBattery = new Battery(batteryDescription, batteryLife);

            Laptop Lenovo = new Laptop(model, price);
            Console.WriteLine(Lenovo);
            Laptop LenovoHDGraphics = new Laptop(model, price, manufacturer, null, graphicsCard, ram, laptopBattery);
            Console.WriteLine(LenovoHDGraphics);
            Laptop LenovoCoreI5 = new Laptop(model, price, manufacturer, processor, null, 0, null);
            Console.WriteLine(LenovoCoreI5);
        }
    }
}
   

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Type = "A";
            car.Сonsumption = 10;
            car.VolumeOfTheTank = 55;
            car.Speed = 80;
        }
    }
}

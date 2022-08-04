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
            Console.WriteLine("Тип автомобиля:");
            car.Type = Console.ReadLine();

            Console.WriteLine("Средний расход топлива:");
            car.Сonsumption = float.Parse(Console.ReadLine());
            Console.WriteLine("Объём топливного бака:");
            car.VolumeOfTheTank = int.Parse(Console.ReadLine());
            Console.WriteLine("Скорость:");
            car.Speed = int.Parse(Console.ReadLine());

            float distance = car.Distance(car.VolumeOfTheTank);
            Console.WriteLine(distance + "км может проехать при полном баке топлива");
            float reservePower = car.PowerReserve(0, 0);
            Console.WriteLine("Запас хода: " + reservePower);
            Console.WriteLine("Количество топлива:");
            int fuel = int.Parse(Console.ReadLine());
            int timeInPath = car.TimeInPath(fuel, 100);
            Console.WriteLine("За " + timeInPath + "ч проедет автомобиль" + "100км");
            PassengerCar car2 = new PassengerCar();
            float powerReserve = car2.PowerReserve(2, 0);
            Console.WriteLine(powerReserve);
            Console.ReadKey(); 
        }
    }
}

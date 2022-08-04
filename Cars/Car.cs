using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    internal class Car
    {
        public string Type { get; set; } //Тип ТС
        public float Сonsumption { get; set; } //Средний расход топлива
        public int VolumeOfTheTank { get; set; } //Объём топливного бака
        public float Speed { get; set; } // Скорость
        public float ReservePower { get; set; } //Запас хода

        public float Distance(int? remainingFuel) // Расстояние, которое может проехать автомобиль, где
                                                  // remainingFuel - остаточное кол-во топлива в баке
        {
            float distance;
            if (remainingFuel == null)
            {
                distance = 100 * VolumeOfTheTank / Сonsumption; //при полном баке
            }
            else
                distance = (float)(100 * remainingFuel / Сonsumption);
            return distance;
        }

        public virtual float PowerReserve(int? passengerCount, float? cargoWeight) //Запас хода в зависимости от пассажиров и груза
                                                                        // Формулу не нашла, значения примерны
        {
            float totalWeight = (float)(70 * passengerCount + cargoWeight); // Общий вес груза ( за средний вес пассажира принято 70кг)
            if (totalWeight == 0)
            {
                ReservePower = 170;

            }
            else if (totalWeight > 0 && totalWeight <= 100)
            {
                ReservePower = 150;
            }
            else
                ReservePower = 120;
            return ReservePower;
        }

        public int TimeInPath(int remainingFuel, float distance) //Время, преодолённое автомобилем
        {
            int timeInPath;
            distance = Distance(remainingFuel);
            timeInPath = (int)(distance / Speed);
            return timeInPath;
        }
    }
}

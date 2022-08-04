using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    internal class FreightCar : Car
    {
        public int LoadCapacity { get; set; } //Грузоподъёмность

        public override float PowerReserve(int? passengerCount, float? cargoWeight)
        {
            if (cargoWeight <= 5000) //200 * (100% / 4%) = 5000кг. При этом значении запас хода снизится до 0.
            {
                ReservePower = (float)((float)ReservePower - (ReservePower / 200 * 0.04));
            }
            else
                Console.WriteLine("Автомобиль не может принять полный груз на борт!");
            return ReservePower;
        }
    }
}

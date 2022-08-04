using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    internal class PassengerCar : Car
    {
        public float PassengerCount { get; set; } // Количество перевозимых пассажиров

        public override float PowerReserve(int? passengerCount, float? cargoWeight)
        {
            //float powerReserve;
            if (passengerCount >= 0 && passengerCount <= 4)
            {
                ReservePower = (float)(ReservePower - ReservePower * passengerCount * 0.06);
                return ReservePower;
            }
            else
                Console.WriteLine("Недопустимое количество пассажиров!");
            return ReservePower;
        }
    }
}

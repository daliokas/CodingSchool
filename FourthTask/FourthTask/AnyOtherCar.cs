using System;

namespace FourthTask
{
    internal class AnyOtherCar : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Driving to the destination");
        }

        public void Park()
        {
            Console.WriteLine("Parking on a single parking spot");
        }
    }
}
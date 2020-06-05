using System;

namespace GarysGarage_Inheritance
{
    public class Cessna: Vehicle, IGas  // Propellor light aircraft
    {
        public double FuelCapacity { get; set; }
        public int CurrentTankPercentage { get; set; } = 0;

        public void RefuelTank()
        {
            CurrentTankPercentage = 100;
        }
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} cessna flys past. Zoooom!");
        }
        public override void Turn(string direction)
        {
            Console.WriteLine($"The Cessna does a barrel-roll {direction} right turn");
        }
        public override void Stop()
        {
            Console.WriteLine($"The Cessna flys towards the airport and lands on the runway");
        }
    }
}
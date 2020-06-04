using System;

namespace GarysGarage_Inheritance
{
    public class Vehicle
    {
        public string MainColor { get; set; }
        public string MaximumOccupancy { get; set; }
        public virtual void Drive()
        {
            Console.WriteLine("Vrooom!");
        }
        public virtual void Turn(string direction)
        {
            Console.WriteLine($"The vehicle slowly turns {direction}");
        }
        public virtual void Stop()
        {
            Console.WriteLine("The vehicle slowly comes to a stop.");
        }
    }
}
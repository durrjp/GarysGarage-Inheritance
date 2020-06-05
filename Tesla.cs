using System;

namespace GarysGarage_Inheritance
{
    public class Tesla: Vehicle, IElectric  // Electric car
    {
        public double BatteryKWh { get; set; }
        public int CurrentChargePercentage { get; set; } = 0;

        public void ChargeBattery()
        {
            CurrentChargePercentage = 100;
        }
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Tesla buzzes past. Buzzzzzzz!");
        }
    }
}
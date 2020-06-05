using System;

namespace GarysGarage_Inheritance
{
    public class Zero: Vehicle, IElectric  // Electric motorcycle
        {
            public double BatteryKWh { get; set; }
            public int CurrentChargePercentage {get; set;} = 0;
            public void ChargeBattery()
            {   
                CurrentChargePercentage = 100;
            }
            public override void Drive()
            {
                Console.WriteLine($"The {MainColor} Zero zips past. Ziiiiippp!");
            }
        }
}
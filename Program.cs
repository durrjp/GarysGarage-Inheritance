using System;

namespace GarysGarage_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero motobike = new Zero()
            {
                MainColor = "red",
                MaximumOccupancy = "1"
            };
            Cessna plane = new Cessna()
            {
                MainColor = "white",
                MaximumOccupancy = "4"
            };
            Tesla tesla = new Tesla()
            {
                MainColor = "black",
                MaximumOccupancy = "5"
            };
            Ram truck = new Ram()
            {
                MainColor = "grey",
                MaximumOccupancy = "20"
            };

            motobike.Drive();
            motobike.Turn("left");
            motobike.Stop();
            plane.Drive();
            plane.Turn("right");
            plane.Stop();
            tesla.Drive();
            tesla.Turn("right");
            tesla.Stop();
            truck.Drive();
            truck.Turn("left");
            truck.Stop();
        }
    }
}

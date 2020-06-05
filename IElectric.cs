namespace GarysGarage_Inheritance
{
    public interface IElectric
    {
        void ChargeBattery();

        int CurrentChargePercentage {get; set;}
    }
}
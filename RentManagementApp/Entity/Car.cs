using RentManagementApp.Repository;

namespace RentManagementApp.Entity;

public sealed class Car:CommonInterface
{
    public Car()
    {
        
    }
    public int Id{ get; set; }
    public int ColorId { get; set; }
    public int FuelId { get; set; }
    public int TransmissionId { get; set; }
    public string? CarState { get; set; }
    public int? KiloMeter { get; set; }
    public short? ModelYear { get; set; }
    public string? Plate { get; set; }
    public string? BrandName { get; set; }
    public string? ModelName { get; set; }
    public double? DailyPrice { get; set; }

    public override string ToString()
    {
        return $"Id:{Id} ColorId:{ColorId} FuelId:{FuelId} TransmissionId:{TransmissionId} CarState:{CarState} " +
               $"Kilometer:{KiloMeter} ModelYear:{ModelYear} Plate:{Plate} BrandName:{BrandName} ModelName:{ModelName} DailyPrice:{DailyPrice}";
    }
};
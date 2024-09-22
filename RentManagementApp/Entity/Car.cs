namespace RentManagementApp.Entity;

public record Car(
    int Id, 
    int ColorId, 
    int FuelId, 
    int TransmissionId, 
    string CarState,
    int? KiloMeter,
    short? ModelYear, 
    string? Plate,
    string? BrandName,
    string? ModelName,
    double? DailyPrice
    );
namespace RentManagementApp.Entity.Dto;

public record CarDetailDto(
    int Id, 
    int ColorName, 
    int FuelName, 
    int TransmissionName, 
    string CarState,
    int? KiloMeter,
    short? ModelYear, 
    string? Plate,
    string? BrandName,
    string? ModelName,
    double? DailyPrice
    );

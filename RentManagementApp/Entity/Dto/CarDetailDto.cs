namespace RentManagementApp.Entity.Dto;

public record CarDetailDto(
    int Id, 
    string ColorName, 
    string FuelName, 
    string TransmissionName, 
    string CarState,
    int? KiloMeter,
    short? ModelYear, 
    string? Plate,
    string? BrandName,
    string? ModelName,
    double? DailyPrice
    );

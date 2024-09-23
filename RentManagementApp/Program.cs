using RentManagementApp.Entity;
using RentManagementApp.Service;

CarService carService = new CarService();
Car car = new Car() 
{ 
    Id = 1,
    ColorId = 1,
    FuelId = 1,
    TransmissionId = 1,
    CarState = "kayseri",
    KiloMeter = 50000,
    ModelYear = 2018,
    Plate = "06ABC01",
    BrandName = "Toyota",
    ModelName = "Camry",
    DailyPrice = 500
};
Car car2 = new Car() 
{ 
    Id = 2,
    ColorId = 2,
    FuelId = 2,
    TransmissionId = 2,
    CarState = "malatya",
    KiloMeter = 44000,
    ModelYear = 2020,
    Plate = "44AAA44",
    BrandName = "Toyota",
    ModelName = "Corolla",
    DailyPrice = 1000
};
/*
carService.AddCar(car);
carService.GetAllCars();
carService.GetCarById(1);
carService.UpdateCar(1,car2);
carService.GetAllCars();
carService.DeleteCar(2);
carService.GetAllCars(); */
//carService.GetAllDetailsById(null,2,null);
//carService.GetAllDetailsByPriceRange(600,1000);
//carService.GetAllDetailsByBrandNameContaining(car.BrandName);
//carService.GetAllDetailsByModelNameContains("Camry");
//carService.GetDetailById(5);
//carService.GetAllDetailsByKilometerRange(20000,80000);
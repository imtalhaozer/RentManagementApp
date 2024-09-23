using RentManagementApp.Entity;
using RentManagementApp.Entity.Dto;
using RentManagementApp.Repository;

namespace RentManagementApp.Service;

public class CarService
{
    private CarRepository _carRepo = new CarRepository();
    public void AddCar(Car car)
    {
        Car newCar = _carRepo.Add(car);
        Console.WriteLine($"Car added {newCar}");
    }

    public void GetAllCars()
    {
        List<Car> cars = _carRepo.GetAll();
        cars.ForEach(x=>Console.WriteLine($"Car: {x}"));
    }

    public void GetCarById(int id)
    {
        Car? car = _carRepo.GetById(id);
        if (car is null)
        {
            Console.WriteLine($"Car cannot found");
            return;
        }

        Console.WriteLine(car);
    }

    public void UpdateCar(int id,Car car)
    {
        List<Car> updatedCar = _carRepo.Update(id,car);
        Console.WriteLine("Car updated");
    }

    public void DeleteCar(int id)
    {
        Car? car = _carRepo.GetById(id);
        if (car is null)
        {
            Console.WriteLine($"Car cannot found");
            return;
        }
        _carRepo.Delete(id);
        Console.WriteLine("Car deleted");
    }
    
    public void GetAllDetailsById(int? colorId, int? fuelId, int? transmissionId)
    {
        List<CarDetailDto> details = _carRepo.GetAllDetailsById(colorId, fuelId, transmissionId);
        details.ForEach(x=>Console.WriteLine($"Car: {x}"));
    }
    
    public void GetAllDetailsByPriceRange(double min, double max)
    {
        List<CarDetailDto> details = _carRepo.GetAllDetailsByPriceRange(min, max);
        details.ForEach(x=>Console.WriteLine($"Car: {x}"));
    }
    
    public void GetAllDetailsByBrandNameContaining(string brandName)
    {
        List<CarDetailDto> details = _carRepo.GetAllDetailsByBrandNameContaining(brandName);
        details.ForEach(x=>Console.WriteLine($"Car: {x}"));
    }
    
    public void GetAllDetailsByModelNameContains(string modelName)
    {
        List<CarDetailDto> details = _carRepo.GetAllDetailsByModelNameContains(modelName);
        details.ForEach(x=>Console.WriteLine($"Car: {x}"));
    }
    
    public void GetDetailById(int categoryId)
    {
        CarDetailDto? detail = _carRepo.GetDetailById(categoryId);
        Console.WriteLine($"Car: {detail}");
    }
    
    public void GetAllDetailsByKilometerRange(int min, int max)
    {
        List<CarDetailDto> details = _carRepo.GetAllDetailsByKilometerRange(min, max);
        details.ForEach(x=>Console.WriteLine($"Car: {x}"));
    }
}
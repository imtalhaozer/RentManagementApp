using RentManagementApp.Entity;
using RentManagementApp.Repository;

namespace RentManagementApp.Service;

public class FuelService
{
    private FuelRepository _fuelRepo = new FuelRepository();
    
    public void AddFuel(Fuel fuel)
    {
        Fuel newFuel = _fuelRepo.Add(fuel);
        Console.WriteLine($"Fuel added {newFuel}");
    }

    public void GetAllFuels()
    {
        List<Fuel> fuels = _fuelRepo.GetAll();
        fuels.ForEach(x => Console.WriteLine($"Fuel: {x}"));
    }

    public void GetFuelById(int id)
    {
        Fuel? fuel = _fuelRepo.GetById(id);
        if (fuel is null)
        {
            Console.WriteLine($"Fuel cannot be found");
            return;
        }

        Console.WriteLine(fuel);
    }

    public void UpdateFuel(int id, Fuel fuel)
    {
        List<Fuel> updatedFuel = _fuelRepo.Update(id, fuel);
        Console.WriteLine("Fuel updated");
    }

    public void DeleteFuel(int id)
    {
        Fuel? fuel = _fuelRepo.GetById(id);
        if (fuel is null)
        {
            Console.WriteLine($"Fuel cannot be found");
            return;
        }
        _fuelRepo.Delete(id);
        Console.WriteLine("Fuel deleted");
    }
}
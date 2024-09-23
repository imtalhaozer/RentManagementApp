using RentManagementApp.Entity;
using RentManagementApp.Repository;

namespace RentManagementApp.Service;

public class TransmissionService
{
    private TransmissionRepository _transmissionRepo = new TransmissionRepository();
    
    public void AddTransmission(Transmission transmission)
    {
        Transmission newTransmission = _transmissionRepo.Add(transmission);
        Console.WriteLine($"Transmission added {newTransmission}");
    }

    public void GetAllTransmissions()
    {
        List<Transmission> transmissions = _transmissionRepo.GetAll();
        transmissions.ForEach(x => Console.WriteLine($"Transmission: {x}"));
    }

    public void GetTransmissionById(int id)
    {
        Transmission? transmission = _transmissionRepo.GetById(id);
        if (transmission is null)
        {
            Console.WriteLine($"Transmission cannot be found");
            return;
        }

        Console.WriteLine(transmission);
    }

    public void UpdateTransmission(int id, Transmission transmission)
    {
        List<Transmission> updatedTransmission = _transmissionRepo.Update(id, transmission);
        Console.WriteLine("Transmission updated");
    }

    public void DeleteTransmission(int id)
    {
        Transmission? transmission = _transmissionRepo.GetById(id);
        if (transmission is null)
        {
            Console.WriteLine($"Transmission cannot be found");
            return;
        }
        _transmissionRepo.Delete(id);
        Console.WriteLine("Transmission deleted");
    }
}
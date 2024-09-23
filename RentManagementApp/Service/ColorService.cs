using RentManagementApp.Entity;
using RentManagementApp.Repository;

namespace RentManagementApp.Service;

public class ColorService
{
    private ColorRepository _colorRepo = new ColorRepository();
    
    public void AddColor(Color color)
    {
        Color newColor = _colorRepo.Add(color);
        Console.WriteLine($"Color added {newColor}");
    }

    public void GetAllColors()
    {
        List<Color> colors = _colorRepo.GetAll();
        colors.ForEach(x => Console.WriteLine($"Color: {x}"));
    }

    public void GetColorById(int id)
    {
        Color? color = _colorRepo.GetById(id);
        if (color is null)
        {
            Console.WriteLine($"Color cannot be found");
            return;
        }

        Console.WriteLine(color);
    }

    public void UpdateColor(int id, Color color)
    {
        List<Color> updatedColor = _colorRepo.Update(id, color);
        Console.WriteLine("Color updated");
    }

    public void DeleteColor(int id)
    {
        Color? color = _colorRepo.GetById(id);
        if (color is null)
        {
            Console.WriteLine($"Color cannot be found");
            return;
        }
        _colorRepo.Delete(id);
        Console.WriteLine("Color deleted");
    }
}
using RentManagementApp.Entity;
using RentManagementApp.Entity.Dto;

namespace RentManagementApp.Repository;

public class CarRepository : BaseRepository<Car>
{
    public List<Color> colors = new List<Color>()
    {
        new Color()
        {
            Id = 1,
            Name = "Blue",
        },
        new Color()
        {
            Id = 2,
            Name = "Green",
        }
    };
        
    public List<Fuel> fuels = new List<Fuel>()
    {
        new Fuel()
        {
            Id = 1,
            Name = "Gasoline",
        },
        new Fuel()
        {
            Id = 2,
            Name = "Motorine",
        }
    };
    public List<Transmission> transmissions = new List<Transmission>()
    {
        new Transmission()
        {
            Id = 1,
            Name = "Automatic",
        },
        new Transmission()
        {
            Id = 2,
            Name = "Manual",
        }
    };
    public CarRepository()
    {
        ListedObjects = new List<Car>()
        {
            new Car() 
            { 
                Id = 3,
                ColorId = 2,
                FuelId = 2,
                TransmissionId = 2,
                CarState = "Ankara",
                KiloMeter = 50000,
                ModelYear = 2018,
                Plate = "06ABC02",
                BrandName = "Toyota",
                ModelName = "Camry",
                DailyPrice = 500
            },
            new Car() 
            { 
                Id = 4,
                ColorId = 1,
                FuelId = 1,
                TransmissionId = 1,
                CarState = "İstanbul",
                KiloMeter = 30000,
                ModelYear = 2021,
                Plate = "34XYZ99",
                BrandName = "Ford",
                ModelName = "Focus",
                DailyPrice = 800
            },
            new Car() 
            { 
                Id = 5,
                ColorId = 1,
                FuelId = 1,
                TransmissionId = 1,
                CarState = "Ankara",
                KiloMeter = 50000,
                ModelYear = 2018,
                Plate = "06ABC03",
                BrandName = "Toyota",
                ModelName = "Camry",
                DailyPrice = 500
            }
            
        };
    }
    
    //GetAllDetails fonksiyonunu colorid, fuelid ve transmissinonid ye göre filtrelenecek şekilde ayarladım hocam
    //ancak isterseniz spesifik özellikleri tek tekte yazabilirim. Tek fonksiyon birden fazla sorgu yapabilmekte.
    public List<CarDetailDto> GetAllDetailsById(int? colorId, int? fuelId, int? transmissionId)
    {
        var result =
            from car in ListedObjects
            where (!colorId.HasValue || car.ColorId == colorId)
                  && (!fuelId.HasValue || car.FuelId == fuelId)
                  && (!transmissionId.HasValue || car.TransmissionId == transmissionId)
            join c in colors on car.ColorId equals c.Id
            join f in fuels on car.FuelId equals f.Id
            join t in transmissions on car.TransmissionId equals t.Id

            select new CarDetailDto(
                Id: car.Id,
                ColorName: c.Name,
                FuelName: f.Name,
                TransmissionName: t.Name,
                CarState: car.CarState,
                KiloMeter: car.KiloMeter,
                ModelYear:car.ModelYear,
                Plate: car.Plate,
                BrandName:car.BrandName,
                ModelName:car.ModelName,
                DailyPrice:car.DailyPrice
            );
        return result.ToList();
    }

    public List<CarDetailDto> GetAllDetailsByPriceRange(double min, double max)
    {
        return GetAllDetailsById(null, null, null).FindAll(x => x.DailyPrice >= min && x.DailyPrice <= max);
    }

    public List<CarDetailDto> GetAllDetailsByBrandNameContaining(string brandName)
    {
        return GetAllDetailsById(null, null, null).FindAll(x => x.BrandName == brandName);
    }
    
    public List<CarDetailDto> GetAllDetailsByModelNameContains(string modelName)
    {
        return GetAllDetailsById(null, null, null).FindAll(x => x.ModelName == modelName);
    }

    public CarDetailDto? GetDetailById(int categoryId)
    {
        return GetAllDetailsById(null, null, null).FindAll(x => x.Id == categoryId).FirstOrDefault();
    }
    
    public List<CarDetailDto> GetAllDetailsByKilometerRange(int min, int max)
    {
        return GetAllDetailsById(null, null, null).FindAll(x => x.KiloMeter >= min && x.KiloMeter <= max);
    }

}
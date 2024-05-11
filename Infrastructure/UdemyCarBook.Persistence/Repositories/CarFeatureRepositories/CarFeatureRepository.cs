using UdemyCarBook.Application.Interfaces.CarFeatureInterfaces;
using UdemyCarBook.Domain.Entities;
using UdemyCarBook.Persistence.Context;

namespace UdemyCarBook.Persistence.Repositories.CarFeatureRepositories;
public class CarFeatureRepository : ICarFeatureRepository
{
    private readonly CarBookContext _context;

    public CarFeatureRepository(CarBookContext context)
    {
        _context = context;
    }

    public List<CarFeature> GetCarFeaturesByCarId(int carId)
    {
        var values = _context.CarFeatures.Where(x=> x.CarID == carId).ToList(); 
        return values;  
    }
}

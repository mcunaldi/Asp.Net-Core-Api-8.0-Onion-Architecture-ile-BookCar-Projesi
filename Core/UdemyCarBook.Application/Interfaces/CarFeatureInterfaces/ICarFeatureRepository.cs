using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Interfaces.CarFeatureInterfaces;
public interface ICarFeatureRepository
{
    List<CarFeature> GetCarFeaturesByCarId(int carId);
}

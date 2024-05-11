using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Interfaces.CarFeatureInterfaces;
public interface ICarFeatureRepository
{
    List<CarFeature> GetCarFeaturesByCarId(int carId);
    void ChangeCarFeatureAvailableToFalse(int id);
    void ChangeCarFeatureAvailableToTrue(int id);
    void CreateCarFeatureByCar(CarFeature carFeature);
}

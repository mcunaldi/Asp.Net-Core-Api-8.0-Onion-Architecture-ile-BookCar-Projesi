using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Interfaces.CarPricingInterface;
public interface ICarPricingRepository
{
    List<CarPricing> GetCarPricingWithCars();
}

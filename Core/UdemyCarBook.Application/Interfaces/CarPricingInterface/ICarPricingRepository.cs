using UdemyCarBook.Application.ViewModels;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Interfaces.CarPricingInterface;
public interface ICarPricingRepository
{
    List<CarPricing> GetCarPricingWithCars();
    List<CarPricing> GetCarPricingWithTimePeriod();
    List<CarPricingViewModel> GetCarPricingWithTimePeriod1();
}

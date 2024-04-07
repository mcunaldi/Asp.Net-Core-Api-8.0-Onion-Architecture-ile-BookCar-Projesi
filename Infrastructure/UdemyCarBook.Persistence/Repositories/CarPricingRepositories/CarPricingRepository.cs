using Microsoft.EntityFrameworkCore;
using UdemyCarBook.Application.Interfaces.CarPricingInterface;
using UdemyCarBook.Domain.Entities;
using UdemyCarBook.Persistence.Context;

namespace UdemyCarBook.Persistence.Repositories.CarPricingRepositories;
public class CarPricingRepository(CarBookContext context) : ICarPricingRepository
{
    public List<CarPricing> GetCarPricingWithCars()
    {
        var values = context.CarPricings.Include(x => x.Car).ThenInclude(x => x.Brand).Include(x => x.Pricing).Where(z=> z.PricingID == 2).ToList();
        return values;
    }
}

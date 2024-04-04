using Microsoft.EntityFrameworkCore;
using UdemyCarBook.Application.Interfaces.CarInterfaces;
using UdemyCarBook.Domain.Entities;
using UdemyCarBook.Persistence.Context;

namespace UdemyCarBook.Persistence.Repositories.CarRepositories;
public class CarRepository(CarBookContext context) : ICarRepository
{
    public List<Car> GetCarsListWithBrands()
    {
        var values = context.Cars.Include(x => x.Brand).ToList();
        return values;
    }
}

using Microsoft.EntityFrameworkCore;
using System;
using System.Linq.Expressions;
using UdemyCarBook.Application.Interfaces.RentACarInterfaces;
using UdemyCarBook.Domain.Entities;
using UdemyCarBook.Persistence.Context;

namespace UdemyCarBook.Persistence.Repositories.RentACarRepositories
{
    public class RentACarRepository(CarBookContext context) : IRentACarRepository
    {
        public async Task<List<RentACar>> GetByFilterAsync(Expression<Func<RentACar, bool>> filter)
        {
            var values = await context.RentACars.Where(filter).Include(x=> x.Car).ThenInclude(y=> y.Brand).ToListAsync();
            return values;
        }
	}
}

//var values = context.CarPricings.Include(x => x.Car).ThenInclude(x => x.Brand).Include(x => x.Pricing).Where(z => z.PricingID == 2).ToList();


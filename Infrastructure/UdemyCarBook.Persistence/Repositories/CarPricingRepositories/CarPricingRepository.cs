using Microsoft.EntityFrameworkCore;
using UdemyCarBook.Application.Interfaces.CarPricingInterface;
using UdemyCarBook.Application.ViewModels;
using UdemyCarBook.Domain.Entities;
using UdemyCarBook.Persistence.Context;

namespace UdemyCarBook.Persistence.Repositories.CarPricingRepositories;
public class CarPricingRepository(CarBookContext context) : ICarPricingRepository
{
	public List<CarPricing> GetCarPricingWithCars()
	{
		var values = context.CarPricings.Include(x => x.Car).ThenInclude(x => x.Brand).Include(x => x.Pricing).Where(z => z.PricingID == 2).ToList();
		return values;
	}

	public List<CarPricing> GetCarPricingWithTimePeriod()
	{
		throw new NotImplementedException();
	}

	public List<CarPricingViewModel> GetCarPricingWithTimePeriod1()
	{

		List<CarPricingViewModel> values = new List<CarPricingViewModel>();
		using (var command = context.Database.GetDbConnection().CreateCommand())
		{
			command.CommandText = "Select * from(Select Model, CoverImageUrl, PricingID, Amount from CarPricings Inner Join Cars On Cars.CarID = CarPricings.CarID Inner Join Brands On Brands.BrandID = Cars.BrandID) As SourceTable Pivot(sum(Amount) for PricingId In  ([1],[2],[3])) as PivotTable";
			command.CommandType = System.Data.CommandType.Text;
			context.Database.OpenConnection();
			using (var reader = command.ExecuteReader())
			{
				while (reader.Read())
				{
                    CarPricingViewModel carPricingViewModel = new CarPricingViewModel()
                    {
                        Model = reader["Model"].ToString(),
                        CoverImageUrl = reader["CoverImageUrl"].ToString(),
                        Amounts = new List<decimal>
                        {
                            Convert.ToDecimal(reader[2]),
                            Convert.ToDecimal(reader[3]),
                            Convert.ToDecimal(reader[4])
                        }
                    };

					values.Add(carPricingViewModel);
				}
			}

			context.Database.CloseConnection();
			return values;
		}
	}
}



/*
 
        var values = from x in context.CarPricings
                     group x by x.PricingID into g
                     select new
                     {
                         CarID = g.Key,
                         DailyPrice = g.Where(y => y.CarPricingID == 1).Sum(z => z.Amount),
                         WeeklyPrice = g.Where(y => y.CarPricingID == 2).Sum(z => z.Amount),
                         MonthlyPrice = g.Where(y => y.CarPricingID == 3).Sum(z => z.Amount)
                     };
 */

/*
 
        List<CarPricing> values = new List<CarPricing>();
        using(var command = context.Database.GetDbConnection().CreateCommand())
        {
            command.CommandText = "Select * from(Select Brands.Name, PricingID, Amount from CarPricings Inner Join Cars On Cars.CarID = CarPricings.CarID Inner Join Brands On Brands.BrandID = Cars.BrandID) As SourceTable Pivot(sum(Amount) for PricingId In  ([1],[2],[3])) as PivotTable";
            command.CommandType = System.Data.CommandType.Text;
            context.Database.OpenConnection();
            using(var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    CarPricing carPricing = new CarPricing();
                    Enumerable.Range(1, 3).ToList().ForEach(x=>
                    {
                        if (DBNull.Value.Equals(reader[x]))
                        {
                            carPricing.Amount = 0;
                        }
                        else
                        {
                            carPricing.Amount
                        }
                    });

					values.Add(carPricing);
                }
            }

            context.Database.CloseConnection();
            return values;
}
 */
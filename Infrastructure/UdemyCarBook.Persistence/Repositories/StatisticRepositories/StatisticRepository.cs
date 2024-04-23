using Microsoft.EntityFrameworkCore;
using UdemyCarBook.Application.StatisticsInterfaces;
using UdemyCarBook.Persistence.Context;

namespace UdemyCarBook.Persistence.Repositories.StatisticRepositories;
public class StatisticRepository(CarBookContext context) : IStatisticsRepository
{
    public string GetBlogTitleByMaxBlogComment()
    {
        //Select top(1) BlogId, Count(*) as 'Sayi' from Comments group by BlogID order by Sayi desc 
        var value = context.Comments.GroupBy(x => x.BlogID).Select(y => new
        {
            BlogID = y.Key,
            Count = y.Count()
        }).OrderByDescending(z=> z.Count).Take(1).FirstOrDefault();

        string commentName = context.Blogs.Where(x=> x.BlogID == value.BlogID).Select(y=> y.Title).FirstOrDefault();

        return commentName;
    }

    public string GetBrandNameByMaxCar()
    {
        //Select top(1)  Brands.Name, Count(*) as 'ToplamArac' from Cars Inner Join Brands on Cars.BrandID = Brands.BrandID Group by Brands.Name order by 
        var value = context.Cars.GroupBy(x => x.BrandID)
        .Select(y => new
        {
            BrandId = y.Key,
            Count = y.Count(),
        }).OrderByDescending(z=> z.Count).Take(1).FirstOrDefault();

        string brandName = context.Brands.Where(x=> x.BrandID == value.BrandId).Select(y=> y.Name).FirstOrDefault();

        return brandName;
    }

    public int GetAuthorCount()
    {
        var value = context.Authors.Count();
        return value;
    }

    public decimal GetAvgRentPriceForDaily()
    {
        //Select AVG(Amount) from CarPricings where CarPricingID=(Select PricingID from Pricings where Name='Günlük')
        int id = context.Pricings.Where(y => y.Name == "Günlük").Select(z => z.PricingID).FirstOrDefault();
        var value = context.CarPricings.Where(w => w.PricingID == id).Average(x => x.Amount);
        return value;
    }

    public decimal GetAvgRentPriceForMonthly()
    {
        int id = context.Pricings.Where(y => y.Name == "Aylık").Select(z => z.PricingID).FirstOrDefault();
        var value = context.CarPricings.Where(w => w.PricingID == id).Average(x => x.Amount);
        return value;
    }

    public decimal GetAvgRentPriceForWeekly()
    {
        int id = context.Pricings.Where(y => y.Name == "Haftalık").Select(z => z.PricingID).FirstOrDefault();
        var value = context.CarPricings.Where(w => w.PricingID == id).Average(x => x.Amount);
        return value;
    }

    public int GetBlogCount()
    {
        var value = context.Blogs.Count();
        return value;
    }

    public int GetBrandCount()
    {
        var value = context.Brands.Count();
        return value;
    }

    public string GetCarBrandAndModelByRentPriceDailyMax()
    {


        int pricingId = context.Pricings.Where(x => x.Name == "Günlük").Select(y => y.PricingID).FirstOrDefault();
        decimal amount = context.CarPricings.Where(y => y.PricingID == pricingId).Max(x => x.Amount);
        int carId = context.CarPricings.Where(x => x.Amount == amount).Select(y => y.CarID).FirstOrDefault();
        string brandModel = context.Cars.Where(x => x.CarID == carId).Include(y => y.Brand).Select(z => z.Brand.Name + " " + z.Model).FirstOrDefault();
        return brandModel;

        //var brandModel = context.Pricings
        //                                 .Where(p => p.Name == "Günlük")
        //                                 .Join(context.CarPricings, pricing => pricing.PricingID, carPricing => carPricing.PricingID, (pricing, carPricing) =>  new { pricing, carPricing })
        //                                 .OrderByDescending(pc => pc.carPricing.Amount)
        //                                 .Select(pc => pc.carPricing.CarID)
        //                                 .Join(context.Cars.Include(c => c.Brand), carPricingCarID => carPricingCarID, car => car.CarID, (carPricingCarID, car) => car.Brand.Name + " " + car.Model)
        //                                  .FirstOrDefault();

        //return brandModel;
    }

    public string GetCarBrandAndModelByRentPriceDailyMin()
    {
        int pricingId = context.Pricings.Where(x => x.Name == "Günlük").Select(y => y.PricingID).FirstOrDefault();
        decimal amount = context.CarPricings.Where(y => y.PricingID == pricingId).Min(x => x.Amount);
        int carId = context.CarPricings.Where(x => x.Amount == amount).Select(y => y.CarID).FirstOrDefault();
        string brandModel = context.Cars.Where(x => x.CarID == carId).Include(y => y.Brand).Select(z => z.Brand.Name + " " + z.Model).FirstOrDefault();
        return brandModel;
    }

    public int GetCarCount()
    {
        var value = context.Cars.Count();
        return value;
    }

    public int GetCarCountByFuelElectric()
    {

        var value = context.Cars.Where(x => x.Fuel == "Elektrik").Count();
        return value;
    }

    public int GetCarCountByFuelGasolineOrDiesel()
    {
        var value = context.Cars.Where(x => x.Fuel == "Benzin" || x.Fuel == "Dizel").Count();
        return value;
    }

    public int GetCarCountBySmallerThan1000()
    {
        var value = context.Cars.Where(x => x.Km < 1000).Count();
        return value;
    }

    public int GetCarCountByTransmissionIsAuto()
    {
        var value = context.Cars.Where(x => x.Transmission == "Otomatik").Count();
        return value;
    }

    public int GetLocationCount()
    {
        var value = context.Locations.Count();
        return value;
    }
}

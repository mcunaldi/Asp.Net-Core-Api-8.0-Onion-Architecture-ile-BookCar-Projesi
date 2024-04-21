namespace UdemyCarBook.Application.StatisticsInterfaces;
public interface IStatisticsRepository
{
    int GetLocationCount();
    int GetAuthorCount();
    int GetBlogCount();
    int GetBrandCount();
    double GetAvgRentPriceForDaily();
    double GetAvgRentPriceForWeekly();
    double GetAvgRentPriceForMonthly();
    int GetCarCountByTransmissionIsAuto();
    string BrandNameByMaxCar();
    string BlogTitleByMaxBlogComment();
    int GetCarCountBySmallerThan1000();
    int GetCarCountByFuelGasolineOrDiesel();
    int GetCarCountByFuelElectric();
    string GetCarBrandAndModelByRentPriceDailyMax();
    string GetCarBrandAndModelByRentPriceDailyMin();

}

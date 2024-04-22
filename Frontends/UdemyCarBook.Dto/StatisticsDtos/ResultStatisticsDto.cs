namespace UdemyCarBook.Dto.StatisticsDtos;
public class ResultStatisticsDto
{
    public int CarCount { get; set; }
    public int LocationCount { get; set; }
    public int AuthorCount { get; set; }
    public int BlogCount { get; set; }
    public int BrandCount { get; set; }
    public decimal AvgRentPriceForDaily { get; set; }
    public decimal AvgRentPriceForWeekly { get; set; }
    public decimal AvgRentPriceForMonthly { get; set; }
    public decimal CarCountByTransmissionIsAuto { get; set; }
    public int CarCountBySmallerThan1000 { get; set; }
    public int CarCountByFuelGasolineOrDiesel { get; set; }
    public int CarCountByFuelElectric { get; set; }
}

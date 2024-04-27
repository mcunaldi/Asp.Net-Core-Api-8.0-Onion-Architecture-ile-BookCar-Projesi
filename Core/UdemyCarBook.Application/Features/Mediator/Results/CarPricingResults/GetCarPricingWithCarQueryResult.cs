namespace UdemyCarBook.Application.Features.Mediator.Results.CarPricingResults;
public class GetCarPricingWithCarQueryResult
{
    public int CarID { get; set; }
    public int CarPricingID { get; set; }
    public string Brand { get; set; }
    public string Model { get; set; }
    public decimal Amount { get; set; }
    public string CoverImageUrl { get; set; }
}

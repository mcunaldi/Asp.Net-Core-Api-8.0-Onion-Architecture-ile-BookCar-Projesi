namespace UdemyCarBook.Application.ViewModels;
public class CarPricingViewModel
{
    public CarPricingViewModel()
    {
        Amounts = new List<decimal>();
    }
    public string Model { get; set; }
    public List<Decimal> Amounts { get; set; }
    public string CoverImageUrl { get; set; }
}

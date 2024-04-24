namespace UdemyCarBook.Dto.RentACarDtos
{
	public class FilterRentACarDto
	{
        public int CarID { get; set; }
		public string Brand { get; set; }
		public string Model { get; set; }
		public decimal Amount { get; set; }
		public string CoverImageUrl { get; set; }
	}
}

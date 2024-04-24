using System.ComponentModel.DataAnnotations.Schema;

namespace UdemyCarBook.Domain.Entities
{
	public class RentACarProcess
	{
        public int RentACarProcessID { get; set; }
        public int CarID { get; set; }
        public Car Car { get; set; }
        public int PickUpLocation { get; set; }
        public int DropOffLocation { get; set; }
        [Column(TypeName="Date")]
        public DateOnly PickUpDate { get; set; }

		[Column(TypeName = "Date")]
		public DateOnly DropOffDate { get; set; }

		[Column(TypeName = "Time")]
		public TimeOnly PickUpTime { get; set; }

		[Column(TypeName = "Time")]
		public TimeOnly DropOffTime { get; set; }
        public int CustomerID { get; set; }
        public Customer Customer { get; set; }
        public string PickUpDescription { get; set; }
        public string DropOffDescription { get; set; }
        public decimal TotalPrice { get; set; }
    }
}

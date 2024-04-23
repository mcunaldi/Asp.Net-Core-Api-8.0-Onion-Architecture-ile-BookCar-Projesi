namespace UdemyCarBook.Domain.Entities;
public class RentACar
{
    public int RentACarID { get; set; }
    public int LocationID { get; set; }
    public Location Location { get; set; }
    public int CarID { get; set; }
    public Car Car { get; set; }
    public bool Available { get; set; }
}

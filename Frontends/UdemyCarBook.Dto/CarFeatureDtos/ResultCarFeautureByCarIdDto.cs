namespace UdemyCarBook.Dto.CarFeatureDtos;
public class ResultCarFeautureByCarIdDto
{
    public int CarFeatureID { get; set; }
    public int FeatureID { get; set; }
    public string FeatureName { get; set; }
    public bool Available { get; set; }
}

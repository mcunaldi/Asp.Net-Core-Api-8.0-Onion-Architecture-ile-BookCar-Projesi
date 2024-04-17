namespace UdemyCarBook.Dto.BlogDtos;
public class ResultAllBlogsWithAuthorDto
{
    public int BlogID { get; set; }
    public string Title { get; set; }
    public string AuthorName { get; set; }
    public object CategoryName { get; set; }
    public int AuthorID { get; set; }
    public string CoverImageUrl { get; set; }
    public DateTime CreatedDate { get; set; }
    public int CategoryID { get; set; }
    public string Description { get; set; }

}

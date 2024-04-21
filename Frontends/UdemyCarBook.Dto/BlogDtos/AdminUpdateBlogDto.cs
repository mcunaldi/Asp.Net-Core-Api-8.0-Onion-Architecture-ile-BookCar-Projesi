namespace UdemyCarBook.Dto.BlogDtos;
public class AdminUpdateBlogDto
{
    public int BlogID { get; set; }
    public string Title { get; set; }
    public string AuthorName { get; set; }
    public DateTime CreatedDate { get; set; }
    public int CategoryID { get; set; }
}

using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Interfaces.BlogInterfaces;
public interface IBlogRepository
{
    public List<Blog> GetLast3BlogsWithAuthors();
}

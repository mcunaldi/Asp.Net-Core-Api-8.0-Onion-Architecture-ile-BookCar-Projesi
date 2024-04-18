using UdemyCarBook.Application.Interfaces.TagCloudInterfaces;
using UdemyCarBook.Domain.Entities;
using UdemyCarBook.Persistence.Context;

namespace UdemyCarBook.Persistence.Repositories.TagCloudRepositories;
public class TagCLoudRepository(CarBookContext context) : ITagCloudRepository
{
    public List<TagCloud> GetTagCloudByBlogID(int id)
    {
        var values = context.TagClouds.Where(x=> x.BlogId == id).ToList();
        return values;
    }
}

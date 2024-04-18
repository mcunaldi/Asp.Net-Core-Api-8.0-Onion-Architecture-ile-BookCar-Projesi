using UdemyCarBook.Application.Features.RepositoryPattern;
using UdemyCarBook.Domain.Entities;
using UdemyCarBook.Persistence.Context;

namespace UdemyCarBook.Persistence.Repositories.CommentRepositorie;
public class CommentRepository<T>(CarBookContext context) : IGenericRepository<Comment>
{
    public void Create(Comment entity)
    {
        context.Comments.Add(entity);
    }

    public List<Comment> GetAll()
    {
        return context.Comments.Select(x=> new Comment
        {
            CommentID = x.CommentID,
            BlogID = x.BlogID,
            CreatedDate = x.CreatedDate,
            Description = x.Description,
            Name = x.Name
        }).ToList();        
    }

    public Comment GetById(int id)
    {
        return context.Comments.Find(id);
    }

    public void Remove(Comment entity)
    {
        var value = context.Comments.Find(entity.CommentID);
        context.Comments.Remove(value);
        context.SaveChanges();
    }

    public void Update(Comment entity)
    {
        context.Comments.Update(entity);
        context.SaveChanges();
    }
}

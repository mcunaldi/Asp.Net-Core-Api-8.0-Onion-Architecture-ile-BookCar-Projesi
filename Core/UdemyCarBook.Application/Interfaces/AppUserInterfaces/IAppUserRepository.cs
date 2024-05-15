using System.Linq.Expressions;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Interfaces.AppUserInterfaces;
public interface IAppUserRepository
{
    Task<AppUser> GetByFilterAsync(Expression<Func<AppUser, bool>> filter);
}

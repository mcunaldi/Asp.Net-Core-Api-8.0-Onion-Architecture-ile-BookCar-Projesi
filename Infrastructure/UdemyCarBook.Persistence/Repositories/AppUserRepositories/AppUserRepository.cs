using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using UdemyCarBook.Application.Interfaces.AppUserInterfaces;
using UdemyCarBook.Domain.Entities;
using UdemyCarBook.Persistence.Context;

namespace UdemyCarBook.Persistence.Repositories.AppUserRepositories;
public class AppUserRepository(CarBookContext context) : IAppUserRepository
{
    public async Task<AppUser> GetByFilterAsync(Expression<Func<AppUser, bool>> filter)
    {
        var values = await context.AppUsers.Where(filter).FirstOrDefaultAsync();
        return values;
    }
}

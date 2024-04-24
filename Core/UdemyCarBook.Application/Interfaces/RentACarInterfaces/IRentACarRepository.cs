using System.Linq.Expressions;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Interfaces.RentACarInterfaces
{
    public interface IRentACarRepository
    {
        Task<List<RentACar>> GetByFilterAsync(Expression<Func<RentACar,bool>> filter);
    }
}

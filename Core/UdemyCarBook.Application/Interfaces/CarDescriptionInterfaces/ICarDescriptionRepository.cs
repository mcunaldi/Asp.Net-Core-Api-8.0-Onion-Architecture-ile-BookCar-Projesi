using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Interfaces.CarDescriptionInterfaces;
public interface ICarDescriptionRepository
{
    Task<CarDescription> GetCarDescription(int carId);
}

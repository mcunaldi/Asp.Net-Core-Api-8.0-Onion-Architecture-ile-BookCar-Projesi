using Microsoft.EntityFrameworkCore;
using UdemyCarBook.Application.Interfaces.CarDescriptionInterfaces;
using UdemyCarBook.Domain.Entities;
using UdemyCarBook.Persistence.Context;

namespace UdemyCarBook.Persistence.Repositories.CarDescriptionRepositories;
public class CarDescriptionRepository(CarBookContext context) : ICarDescriptionRepository
{

	async Task<CarDescription> ICarDescriptionRepository.GetCarDescription(int carId)
	{
		var values = await context.CarDescriptions.Where(x => x.CarID == carId).FirstOrDefaultAsync()!;
		return values;
	}
}

using UdemyCarBook.Application.Interfaces.ReviewInterfaces;
using UdemyCarBook.Domain.Entities;
using UdemyCarBook.Persistence.Context;

namespace UdemyCarBook.Persistence.Repositories.ReviewRepositories;
public class ReviewRepository(CarBookContext context) : IReviewRepository
{
	public List<Review> GetAllReviewsByCarId(int carId)
	{
		var values = context.Reviews.Where(x => x.CarID == carId).ToList();
		return values;
	}
}

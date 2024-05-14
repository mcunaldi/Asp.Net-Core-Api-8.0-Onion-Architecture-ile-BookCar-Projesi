using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Interfaces.ReviewInterfaces;
public interface IReviewRepository
{
	List<Review> GetAllReviewsByCarId(int carId);
}

using RestaurantRaterMVC.Models.Rating;

namespace RestaurantRaterMVC.Services.Rating;

public interface IRatingService
{
    Task<bool> CreateRatingAsync(RatingCreate model);
    Task<List<RatingListItem>> GetRatingsAsync();
    Task<List<RatingListItem>> GetRestaurantRatingsAsync(int restaurantId);
}

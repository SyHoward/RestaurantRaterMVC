using RestaurantRaterMVC.Models.Rating;

namespace RestaurantRaterMVC.Services.Rating;

public interface IRatingService
{
    Task<List<RatingListItem>> GetRatingsAsync();
    Task<List<RatingListItem>> GetRestaurantRatingsAsync(int restaurantId);
}

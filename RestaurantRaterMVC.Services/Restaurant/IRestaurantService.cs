using RestaurantRaterMVC.Models.Restaurant;

namespace RestaurantRaterMVC.Services.Restaurant;

public interface IRestaurantService
{
    Task<IEnumerable<RestaurantListItem>> GetAllRestaurantsAsync();
    Task<bool> CreateRestaurantAsync(RestaurantCreate model);
}
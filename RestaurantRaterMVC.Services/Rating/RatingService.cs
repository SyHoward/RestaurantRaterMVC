using RestaurantRaterMVC.Data;

namespace RestaurantRaterMVC.Services.Rating;

public class RatingService : IRatingService
{
    private readonly RestaurantDbContext _content;
    public RatingService(RestaurantDbContext context)
    {
        _content = context;
    }
}
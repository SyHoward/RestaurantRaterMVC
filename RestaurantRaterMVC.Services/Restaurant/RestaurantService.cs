using RestaurantRaterMVC.Data;

namespace RestaurantRaterMVC.Services.Restaurant;

    public class RestaurantService : IRestaurantService
    {
        private RestaurantDbContext _context;
        public RestaurantService(RestaurantDbContext context)
        {
            _context = context;
        }
    }

using Microsoft.AspNetCore.Mvc;
using RestaurantRaterMVC.Services.Rating;

namespace RestaurantRaterMVC.MVC.Controllers;

public class RatingController : Controller
{
    private readonly IRatingService _service;
    public RatingController(IRatingService service)
    {
        _service = service;
    }
}

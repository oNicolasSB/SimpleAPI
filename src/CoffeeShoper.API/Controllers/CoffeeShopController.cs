using CoffeeShoper.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeShoper.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CoffeeShopController : ControllerBase
{
    private readonly ICoffeeShopService _coffeeShopService;
    
    public CoffeeShopController(ICoffeeShopService coffeeShopService)
    {
        _coffeeShopService = coffeeShopService;
    }
    [HttpGet]
    public IActionResult List()
    {
        var coffeeShops = _coffeeShopService.List();
        return Ok(coffeeShops);
    }
}
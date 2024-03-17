using CoffeeShoper.Domain;
using CoffeeShoper.DTO;
using CoffeeShoper.Infrastructure.Data.Repositories;
using CoffeeShoper.Interfaces;

namespace CoffeeShoper.Services;

public class CoffeeShopService : ICoffeeShopService
{
    IBaseRepository<CoffeeShop> _coffeeShopRepository;

    public CoffeeShopService(IBaseRepository<CoffeeShop> coffeeShopRepository)
    {
        _coffeeShopRepository = coffeeShopRepository;
    }

    public List<CoffeeShopDTO> List()
    {
        var coffeeShops = _coffeeShopRepository.GetAllReadOnly().Select(x => new CoffeeShopDTO
        {
            CoffeeShopId = x.CoffeeShopId,
            Name = x.Name,
            Address = x.Address,
            OpeningHours = x.OpeningHours
        }).ToList();
        return coffeeShops;
    }
}

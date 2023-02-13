using ETicaretAPI.Application.Abstractions;
using ETicaretAPI.Application.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ETicaretAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        readonly private IProductWriteRepository _productWriteRepository;
        readonly private IProductReadRepository _productReadRepository;
             
        public ProductsController(IProductWriteRepository productWriteRepository, IProductReadRepository productReadRepository)
        {
            _productWriteRepository = productWriteRepository;
            _productReadRepository = productReadRepository;
        }

        [HttpGet]
       public async void Get()
        {
           await _productWriteRepository.AddRangeAsync(new()
            {

                new(){Id=Guid.NewGuid(), Name="AK1", CreatedDate=DateTime.UtcNow, Price=10, Stock=100},
                new(){Id=Guid.NewGuid(), Name="AK2", CreatedDate=DateTime.UtcNow, Price=20, Stock=100},
                new(){Id=Guid.NewGuid(), Name="AK3", CreatedDate=DateTime.UtcNow, Price=30, Stock=100},
            });
            var count = await _productWriteRepository.SaveAsync();
        }
       
    }
}

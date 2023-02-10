using ETicaretAPI.Application.Abstractions;
using ETicaretAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Persistence.Concretes
{
    public class ProductService : IProductService
    {
        public List<Product> GetProducts()
            => new() {
                new(){Id=Guid.NewGuid(), Name="Product 1", CreatedDate=DateTime.Now , Price= 10, Stock=5},
                new(){Id=Guid.NewGuid(), Name="Product 2", CreatedDate=DateTime.Now , Price= 10, Stock=5},
                new(){Id=Guid.NewGuid(), Name="Product 3", CreatedDate=DateTime.Now , Price= 10, Stock=5},
                new(){Id=Guid.NewGuid(), Name="Product 4", CreatedDate=DateTime.Now , Price= 10, Stock=5},
                new(){Id=Guid.NewGuid(), Name="Product 5", CreatedDate=DateTime.Now , Price= 10, Stock=5}
            };
    }
}

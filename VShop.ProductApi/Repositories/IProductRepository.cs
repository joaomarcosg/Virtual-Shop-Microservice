using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VShop.ProductApi.Models;

namespace VShop.ProductApi.Repositories
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetAll();
        Task<Product> GetById(int id);
        Task<Product> Create(Product product);
        Task<Product> Update(Product product);
        Task<Product> Delete(int id);
    }
}
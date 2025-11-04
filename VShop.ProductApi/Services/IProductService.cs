using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VShop.ProductApi.DTOs;

namespace VShop.ProductApi.Services
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDTO>> GetProducts();
        Task<ProductDTO> GetProductById(int id);
        Task AddProduct(ProductDTO productDTO);
        Task UpdateProduct(ProductDTO productDTO);
        Task RemoveProduct(int id);
    }
}
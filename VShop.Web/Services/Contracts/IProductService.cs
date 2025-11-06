using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VShop.Web.Models;

namespace VShop.Web.Services.Contracts
{
    public interface IProductService
    {
        Task<IEnumerable<ProductViewModel>> GetAllProducts();
        Task<ProductViewModel> FindProductById(int id);
        Task<ProductViewModel> CreateProduct(ProductViewModel productVM);
        Task<ProductViewModel> UpdateProduct(ProductViewModel productVM);
        Task<bool> DeleteProductById(int id);

    }
}
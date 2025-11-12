using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VShop.Web.Models;

namespace VShop.Web.Services.Contracts
{
    public interface ICategoryService
    {
        Task<IEnumerable<CategoryViewModel>> GetAllCategories();
    }
}
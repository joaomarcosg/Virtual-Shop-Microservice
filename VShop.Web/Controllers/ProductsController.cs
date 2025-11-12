using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using VShop.Web.Models;
using VShop.Web.Services.Contracts;

namespace VShop.Web.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductService _productService;
        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductViewModel>>> Index()
        {
            var result = await _productService.GetAllProducts();

            if (result is null)
                return View("Error");

            return View(result);
        }

        [HttpGet]
        public async Task<IActionResult> CreateProduct()
        {
            ViewBag.CategoryId = new SelectList(await
                _categoryService.GetAllCategories(), "CategoryId", "Name");
            return View();
        }

    }
}
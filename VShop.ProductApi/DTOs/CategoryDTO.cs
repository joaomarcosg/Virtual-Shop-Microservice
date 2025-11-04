using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using VShop.ProductApi.Models;

namespace VShop.ProductApi.DTOs
{
    public class CategoryDTO
    {
        public int CategoryId { get; set; }
        
        [Required(ErrorMessage = "The name is required")]
        [MinLength(3)]
        [MaxLength(100)]
        public string? Name { get; set; }
        public ICollection<Product>? Products { get; set; }
    }
}
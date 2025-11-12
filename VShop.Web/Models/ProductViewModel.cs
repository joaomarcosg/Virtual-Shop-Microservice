using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VShop.Web.Models
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public string? Description { get; set; }
        [Required]
        public long Stock { get; set; }
        [Required]
        public string? ImageURL { get; set; }
        public string? CategoryName { get; set; }
        public int CategoryId { get; set; }
    }
    
}
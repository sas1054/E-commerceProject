using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RookieShop.Shared.DTOs.ProductDTOs
{
    public class ProductPost
    {
        
        [Required]
        public string ProductName { get; set; }
        public string Description { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public string ImageLink { get; set; }

        public int CategoryId { get; set; }
        public bool isDeleted { get; set; }
    }
}

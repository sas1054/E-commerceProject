using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using RookieShop.Backend.Models.Enums;

namespace RookieShop.Backend.Models
{
    public class Product
    {
        public string Id { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
        public int NumberInStock { get; set; }

        public Category Category { get; set; }
        public bool isDeleted { get; set; }

        public List<Comment> Comment { get; set; } = new List<Comment>();



    }
}

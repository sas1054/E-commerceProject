using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RookieShop.Backend.Models
{
    public class Product
    {   
        [Key]
        public int Id { get; set; }
        [Required]
        public string ProductName { get; set; }
        public string Description { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        
        public string ImageLink { get; set; }

        public DateTime CreatedDate { get; set; }
        public bool isDeleted { get; set; }
        public List<Category> Categories { get; set; } = new List<Category>();

        



    }
}

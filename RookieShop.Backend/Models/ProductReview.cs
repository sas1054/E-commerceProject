using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RookieShop.Backend.Models
{
    public class ProductReview
    {
        [Key]
        public string ReviewId { get; set; }

        public string Comment { get; set; }

        public int Rating { get; set; }

        public int ProductId { get; set; }

        public string UserId { get; set; }

        public string UserName { get; set; }

        public DateTime DateReview { get; set; }

        public virtual Product Product { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace RookieShop.Shared.DTOs.ProductReviewDTO
{
    public class ProductReviewDTO
    {
        public string ReviewId { get; set; }

        public string Comment { get; set; }

        public int Rating { get; set; }

        public int ProductId { get; set; }

        public string UserId { get; set; }

        public string UserName { get; set; }

        public DateTime DateReview { get; set; }
    }
}

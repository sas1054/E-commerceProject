using System;
using System.Collections.Generic;
using System.Text;

namespace RookieShop.Shared.DTOs.ProductReviewDTO
{
    public class ProductReviewRequest
    {
        public string Conmment { get; set; }

        public int Rating { get; set; }

        public int ProductId { get; set; }

        public string UserName { get; set; }
    }
}

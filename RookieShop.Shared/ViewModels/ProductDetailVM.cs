using RookieShop.Shared.DTOs.ProductDTOs;
using RookieShop.Shared.DTOs.ProductReviewDTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace RookieShop.Shared.ViewModels
{
    public class ProductDetailVM
    {
        public ProductDTOResponse Product { get; set; }

        public IEnumerable<ProductReviewDTO> Reviews { get; set; }
    }
}

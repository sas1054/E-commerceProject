using RookieShop.Shared.DTOs;
using RookieShop.Shared.DTOs.ProductDTOs;
using System;
using System.Collections.Generic;
using System.Text;


namespace RookieShop.Shared.ViewModels
{
    public class HomeVM
    {
        public IEnumerable<ProductDTOResponse> Products { get; set; }
        public IEnumerable<CategoryDTO> Categories { get; set; }
    }
}

using RookieShop.Shared.DTOs;
using RookieShop.Shared.DTOs.ProductDTOs;
using System;
using System.Collections.Generic;
using System.Text;


namespace RookieShop.Shared.ViewModels
{
    public class CategoryVCVM
    {       
        public IEnumerable<CategoryDTO> Categories { get; set; }
    }
}

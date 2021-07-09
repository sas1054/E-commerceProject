using RookieShop.Backend.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RookieShop.Shared.ViewModels
{
    public class HomeVM
    {
        public IEnumerable<ProductDTOResponse> Products { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RookieShop.Shared.DTOs
{
    public class CategoryResponseDTO
    {
        [Required]
        public string CategoryName { get; set; }

        public string Description { get; set; }
    }
}

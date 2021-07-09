using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RookieShop.Shared.DTOs
{
    public class CategoryDTO
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string CategoryName { get; set; }

        public string Description { get; set; }
    }
}

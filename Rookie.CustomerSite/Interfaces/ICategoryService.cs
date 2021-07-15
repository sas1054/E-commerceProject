
using RookieShop.Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rookie.CustomerSite.Interfaces
{
    public interface ICategoryService
    {
        Task<IEnumerable<CategoryDTO>> GetCategoryAsync(/*ProductCriteriaDTO productCriteriaDto*/);
        Task<CategoryDTO> GetCategoryByIdAsync(int id);
    }
}

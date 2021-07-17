
using RookieShop.Shared.DTOs.ProductDTOs;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rookie.CustomerSite.Interfaces
{
    public interface IProductService 
    {
        Task<IEnumerable<ProductDTOResponse>> GetProductAsync(/*ProductCriteriaDTO productCriteriaDto*/);
        Task<ProductDTOResponse> GetProductByIdAsync(int id);

        Task<IEnumerable<ProductDTOResponse>> GetProductByCategory(int CategoryId);

        Task<IEnumerable<ProductDTOResponse>> SearchProduct(string name);
    }
}

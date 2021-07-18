using RookieShop.Shared.DTOs.ProductReviewDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rookie.CustomerSite.Interfaces
{
    public interface IProductReviewService
    {
        Task<IEnumerable<ProductReviewDTO>> GetProductReviewAsync(int ProductId);

        Task<ProductReviewDTO> PostReview(ProductReviewRequest request);
    }
}

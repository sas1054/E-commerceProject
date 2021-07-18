using Microsoft.AspNetCore.Mvc;
using Rookie.CustomerSite.Interfaces;
using Rookie.CustomerSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using RookieShop.Shared.ViewModels;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using RookieShop.Shared.DTOs.ProductReviewDTO;

namespace Rookie.CustomerSite.Controllers
{
    
    public class ProductDetailController : Controller
    {
        private readonly IProductService _productService;
        private readonly IProductReviewService _productReviewService;
        public ProductDetailController(IProductService productService, IProductReviewService productreviewService)
        {
            _productService = productService;
            _productReviewService = productreviewService; 
        }
        /*public IActionResult Index()
        {
            return View();
        }*/
        public async Task<IActionResult> Index(int? Id)
        {
            if (Id == null)
            {
                return NotFound();
            }
            var productDetailVM = new ProductDetailVM
            {
                Product = await _productService.GetProductByIdAsync(Id.Value),
                Reviews = await _productReviewService.GetProductReviewAsync(Id.Value)
            };
            
            return View(productDetailVM);
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> PostReview(string userName, int rating, string comment, int productId)
        {
            var review = new ProductReviewRequest
            {
                UserName = userName,
                Rating = rating,
                Comment = comment,
                ProductId = productId,
            };
            await _productReviewService.PostReview(review);
            return RedirectToAction("Index", new { Id = productId });
        }
    }
}

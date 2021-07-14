using Microsoft.AspNetCore.Mvc;
using Rookie.CustomerSite.Interfaces;
using Rookie.CustomerSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using RookieShop.Shared.ViewModels;
using System.Threading.Tasks;

namespace Rookie.CustomerSite.Controllers
{
    
    public class ProductDetailController : Controller
    {
        private readonly IProductService _productService;
        public ProductDetailController(IProductService productService)
        {
            _productService = productService;
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
                Product = await _productService.GetProductByIdAsync(Id.Value)
            };
            return View(productDetailVM);
        }
    }
}

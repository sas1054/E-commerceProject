using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Rookie.CustomerSite.Interfaces;
using Rookie.CustomerSite.Models;
using RookieShop.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Rookie.CustomerSite.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        public HomeController(ILogger<HomeController> logger, IProductService productService, ICategoryService categoryService)
        {
            _logger = logger;
            _productService = productService;
            _categoryService = categoryService;


        }

        public async Task<IActionResult> Index(int? CategoryID, string name)
        {
            ViewData["CurrentFilter"] = name;
            var homeVM = new HomeVM();
            if (!CategoryID.HasValue) {
                var homeVM1 = new HomeVM
                {
                    Products = await _productService.GetProductAsync(),
                    Categories = await _categoryService.GetCategoryAsync()
                };
                homeVM = homeVM1;
            }           
            else
            {
                var homeVM1 = new HomeVM
                {
                    Products = await _productService.GetProductByCategory(CategoryID.Value),                    
                    Categories = await _categoryService.GetCategoryAsync()
                };
                
                homeVM = homeVM1;
            }
            if (!String.IsNullOrEmpty(name))
            {
                var homeVM1 = new HomeVM
                {
                    Products = await _productService.SearchProduct(name),
                    Categories = await _categoryService.GetCategoryAsync()
                };
                homeVM = homeVM1;
            }

            return View(homeVM);
        }
        public async Task<IActionResult> ViewProductByCategory(int? productID)
        {
            var homeVM = new HomeVM
            {
                Products = await _productService.GetProductByCategory(productID.Value),
                Categories = await _categoryService.GetCategoryAsync()
            };
            return View(homeVM);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

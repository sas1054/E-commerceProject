using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Rookie.CustomerSite.Services;
using Rookie.CustomerSite.Interfaces;
using RookieShop.Shared.ViewModels;

namespace Rookie.CustomerSite.ViewComponents
{
    public class CategoryListViewComponent : ViewComponent
    {
        private readonly ICategoryService _categoryService;
        public CategoryListViewComponent(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var VM = new CategoryVCVM
            {
                Categories = await _categoryService.GetCategoryAsync()
            };
            
            return View(VM);
        }
    }
}

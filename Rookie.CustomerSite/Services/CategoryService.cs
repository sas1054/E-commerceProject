using System.Net.Http;
using Rookie.CustomerSite.Interfaces;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RookieShop.Shared.Constants;
using RookieShop.Shared.DTOs;

namespace Rookie.CustomerSite.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly IHttpClientFactory _clientFactory;
        public CategoryService(IHttpClientFactory clientfactory)
        {
            _clientFactory = clientfactory;
        }
        public async Task<IEnumerable<CategoryDTO>> GetCategoryAsync()
        {
            var client = _clientFactory.CreateClient(ServiceConstants.BACK_END_NAMED_CLIENT);
            var response = await client.GetAsync(EndpointConstants.GET_CATEGORIES);
            response.EnsureSuccessStatusCode();
            var categories = await response.Content.ReadAsAsync<IEnumerable<CategoryDTO>>();
            return categories;
        }

        public async Task<CategoryDTO> GetCategoryByIdAsync(int id)
        {
            var client = _clientFactory.CreateClient(ServiceConstants.BACK_END_NAMED_CLIENT);
            var response = await client.GetAsync($"EndpointConstants.GET_CATEGORIES\\{id}");
            response.EnsureSuccessStatusCode();
            var category = await response.Content.ReadAsAsync<CategoryDTO>();
            return category;
        }
    }
}

using System.Net.Http;
using System.Threading.Tasks;

using RookieShop.Shared;
using RookieShop.Shared.Constants;
using RookieShop.Shared.DTOs.ProductDTOs;
using Newtonsoft.Json;
using System.Collections.Generic;
using Rookie.CustomerSite.Interfaces;


namespace Rookie.CustomerSite.Services
{
    public class ProductService : IProductService 
    {
        private readonly IHttpClientFactory _clientFactory;

        public ProductService(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public async Task<IEnumerable<ProductDTOResponse>> GetProductAsync(/*ProductCriteriaDTO productCriteriaDto*/)
        {
            var client = _clientFactory.CreateClient(ServiceConstants.BACK_END_NAMED_CLIENT);
            var response = await client.GetAsync(EndpointConstants.GET_BRANDS);
            response.EnsureSuccessStatusCode();
            var products = await response.Content.ReadAsAsync<IEnumerable<ProductDTOResponse>>();
            return products;
        }

        public async Task<ProductDTOResponse> GetProductByIdAsync(int id)
        {
            var client = _clientFactory.CreateClient(ServiceConstants.BACK_END_NAMED_CLIENT);
            var response = await client.GetAsync($"{EndpointConstants.GET_BRANDS}\\{id}");
            response.EnsureSuccessStatusCode();
            var Product = await response.Content.ReadAsAsync<ProductDTOResponse>();
            return Product;
        }
        public async Task<IEnumerable<ProductDTOResponse>> GetProductByCategory(int CategoryId)
        {
            var client = _clientFactory.CreateClient(ServiceConstants.BACK_END_NAMED_CLIENT);
            var response = await client.GetAsync($"{EndpointConstants.GET_BRANDS_BY_CATEGORY}\\{CategoryId}");
            response.EnsureSuccessStatusCode();
            var Products = await response.Content.ReadAsAsync <IEnumerable<ProductDTOResponse>>();
            return Products;
        }
    }
}

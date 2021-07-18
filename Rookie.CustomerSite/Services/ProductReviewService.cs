using Rookie.CustomerSite.Interfaces;
using RookieShop.Shared.DTOs.ProductReviewDTO;
using System.Net.Http;
using System.Threading.Tasks;
using RookieShop.Shared;
using RookieShop.Shared.Constants;
using RookieShop.Shared.DTOs.ProductDTOs;
using Newtonsoft.Json;
using System.Collections.Generic;
using System;
using System.Text;

namespace Rookie.CustomerSite.Services
{
    public class ProductReviewService : IProductReviewService
    {
        private readonly IHttpClientFactory _clientFactory;

        public ProductReviewService(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }
        public async Task<IEnumerable<ProductReviewDTO>> GetProductReviewAsync(int ProductId)
        {
            var client = _clientFactory.CreateClient(ServiceConstants.BACK_END_NAMED_CLIENT);
            var response = await client.GetAsync($"{EndpointConstants.GET_REVIEWS}\\{ProductId}");
            response.EnsureSuccessStatusCode();
            var productreviews = await response.Content.ReadAsAsync<IEnumerable<ProductReviewDTO>>();
            return productreviews;
        }

        public async Task<ProductReviewDTO> PostReview(ProductReviewRequest request)
        {
            var json = JsonConvert.SerializeObject(request);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            var client = _clientFactory.CreateClient(ServiceConstants.BACK_END_NAMED_CLIENT);
            var response = await client.PostAsync(EndpointConstants.POST_REVIEWS, data);
            response.EnsureSuccessStatusCode();
            var body = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<ProductReviewDTO>(body);          
        }
    }
}

using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RookieShop.Backend.Data;
using RookieShop.Backend.Models;
using RookieShop.Shared.DTOs.ProductDTOs;
using RookieShop.Shared.DTOs.ProductReviewDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;


namespace RookieShop.Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize("Bearer")]
    public class ReviewController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public ReviewController(ApplicationDbContext db, IMapper mapper, IHttpContextAccessor httpContextAccessor)
        {
            _db = db;
            _mapper = mapper;
            _httpContextAccessor = httpContextAccessor;
        }

        [HttpGet("GetReviews/{id}")]
        [AllowAnonymous]
        public async Task<IEnumerable<ProductReviewDTO>> GetReviews(int id)
        {
            var reviews = await _db.ProductReviews
                .Include(m => m.Product)
                .Where(m => m.ProductId.Equals(id))
                .OrderBy(m => m.DateReview)
                .AsNoTracking()
                .ToListAsync();

            var reviewRes = _mapper.Map<IEnumerable<ProductReviewDTO>>(reviews);
            return reviewRes;
        }

        [HttpPost("PostReview")]

        public async Task<ActionResult<ProductReviewDTO>> PostReview([FromBody]ProductReviewRequest reviewFormRequest)
        {
            var review = _mapper.Map<ProductReview>(reviewFormRequest);
            review.ReviewId = Guid.NewGuid().ToString();
            review.DateReview = DateTime.Now.Date;

            var userId = _httpContextAccessor.HttpContext.User.Identity.Name;
            review.UserId = userId;

            _db.ProductReviews.Add(review);
            await _db.SaveChangesAsync();

            var sumRating = _db.ProductReviews.Where(x => x.ProductId.Equals(review.ProductId)).Average(p => p.Rating);

            var product = await _db.Products.FindAsync(review.ProductId);
            product.Rating = Convert.ToInt32(sumRating);
            await _db.SaveChangesAsync();

            var reviewRes = _mapper.Map<ProductReviewDTO>(review);
            return reviewRes;
        }

        /*[HttpPost("PostReviewV2")]
        [AllowAnonymous]
        public async Task<IEnumerable<ProductReviewDTO>> PostReviewV2([FromForm] ReviewFormRequest reviewFormRequest)
        {
            var review = _mapper.Map<Review>(reviewFormRequest);
            review.ReviewId = Guid.NewGuid().ToString();
            review.DateReview = DateTime.Now.Date;
            review.UserId = "null";

            _db.Reviews.Add(review);
            await _db.SaveChangesAsync();

            var sumRating = _db.Reviews.Where(x => x.ProductId.Equals(review.ProductId)).Average(p => p.Rating);

            var product = await _db.Products.FindAsync(review.ProductId);
            product.Rating = Convert.ToInt32(sumRating);
            await _db.SaveChangesAsync();

            var reviews = await _db.Reviews
                .Include(review => review.Product)
                .Where(review => review.ProductId.Equals(reviewFormRequest.ProductId))
                .OrderBy(review => review.DateReview)
                .AsNoTracking()
                .ToListAsync();

            var reviewRes = _mapper.Map<IEnumerable<ProductReviewDTO>>(reviews);
            return reviewRes;
        }*/

    }
}

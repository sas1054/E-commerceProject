using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RookieShop.Backend.Data;
using RookieShop.Backend.Models;
using RookieShop.Shared.DTOs.ProductDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RookieShop.Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize("Bearer")]
    public class ProductsController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;

        public ProductsController(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }
        // GET: api/products
        [HttpGet]
        public async Task<IActionResult> GetAllProducts()
        {
            var objList = await _db.Products.Include(m => m.Category).OrderBy(m => m.ProductName).ToListAsync();
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Product, ProductDTOResponse>()
                .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(s => s.Category.CategoryName))
            )
            .CreateMapper();

            var objDTO = new List<ProductDTOResponse>();
            foreach (var item in objList)
            {                
                objDTO.Add(mapper.Map<ProductDTOResponse>(item));
            }
            return Ok(objDTO);
        }
        // GET: api/products/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductByID(int id)
        {
            var obj = await _db.Products.Include(m=> m.Category).FirstOrDefaultAsync(i =>i.Id== id);
            if (obj == null)
            {
                return NotFound();
            }
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Product, ProductDTOResponse>()
                .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(s => s.Category.CategoryName))
            )
            .CreateMapper();
            var objDTO = mapper.Map<ProductDTOResponse>(obj);
            return Ok(objDTO);
        }

        [HttpGet("GetProductByCategory/{CategoryId}")]
        public async Task<IActionResult> GetProductByCategory(int CategoryId)
        {
            var objList = await _db.Products.Include(m => m.Category).Where(m => m.CategoryId==CategoryId).OrderBy(m => m.ProductName).ToListAsync();
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Product, ProductDTOResponse>()
                .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(s => s.Category.CategoryName))
            )
            .CreateMapper();
            var objDTO = new List<ProductDTOResponse>();
            foreach (var item in objList)
            {
                objDTO.Add(mapper.Map<ProductDTOResponse>(item));
            }
            return Ok(objDTO);
        }

        [HttpGet("GetRelatedProduct/{id}")]
        public async Task<IActionResult> GetRelatedProduct(int id)
        {
            var targetProduct = await _db.Products.FirstOrDefaultAsync(m => m.Id == id);        
            var objList = await _db.Products.Include(m => m.Category).Where( m => m.CategoryId == targetProduct.CategoryId && targetProduct.Id == id && m.Id != id)
                .OrderBy(m => m.ProductName)
                .AsNoTracking()
                .ToListAsync();
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Product, ProductDTOResponse>()
                .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(s => s.Category.CategoryName))
            )
            .CreateMapper();
            var objDTO = new List<ProductDTOResponse>();
            /*foreach (var item in objList)
            {
                objDTO.Add();
            }*/
            return Ok(mapper.Map<ProductDTOResponse>(objList));
        }
        [HttpGet("SearchProduct/{name}")]
        public async Task<IActionResult> SearchProduct(string name)
        {
            var objList = await _db.Products
                .Include(m => m.Category)
                .Where(m => m.ProductName.Contains(name))
                .OrderBy(m => m.ProductName)
                .ToListAsync();
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Product, ProductDTOResponse>()
                .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(s => s.Category.CategoryName))
            )
            .CreateMapper();

            var objDTO = new List<ProductDTOResponse>();
            foreach (var item in objList)
            {
                objDTO.Add(mapper.Map<ProductDTOResponse>(item));
            }
            return Ok(objDTO);
        }

        // POST : api/products
        [HttpPost]
        public async Task<IActionResult> CreateProducts([FromBody] ProductDTORequest product)
        {
            if (product == null)
                return BadRequest();
            if (_db.Products.Any(m => m.ProductName.ToLower().Trim() == product.ProductName.ToLower().Trim()))
            {
                ModelState.AddModelError("", "Product Existed!");
                return StatusCode(404, ModelState);
            }
            var productObj = _mapper.Map<Product>(product);
            _db.Products.Add(productObj);
            await _db.SaveChangesAsync();

            return CreatedAtAction(nameof(GetProductByID), new { ProductID = productObj.Id }, productObj);
        }

        // PUT : api/products
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProduct(int id, [FromBody] ProductDTORequest product)
        {
            if (product ==null || id != product.Id)
            {
                return BadRequest();
            }

            var productObj = _mapper.Map<Product>(product);
            _db.Products.Update(productObj);
            await _db.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMenuItem(int id)
        {
            bool exits = _db.Products.Any(c => c.Id == id);
            if (!exits)
            {
                return NotFound();
            }

            var menuItemObj = await _db.Products.FindAsync(id);
            _db.Products.Remove(menuItemObj);
            await _db.SaveChangesAsync();

            return NoContent();
        }


    }


}

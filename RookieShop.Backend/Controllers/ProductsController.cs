using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RookieShop.Backend.Data;
using RookieShop.Backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RookieShop.Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;

        public ProductsController(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProducts()
        {
            var objList = await _db.Products.Include(m => m.Category).OrderBy(m =>m.ProductName).ToListAsync();
            var objDTO = new List<ProductDTOResponse>();
            foreach (var item in objList)
            {
                objDTO.Add(_mapper.Map<ProductDTOResponse>(item));
            }
            return Ok(objDTO);
        }


    }
    
}

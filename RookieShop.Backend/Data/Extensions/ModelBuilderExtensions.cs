using Microsoft.EntityFrameworkCore;
using RookieShop.Backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace RookieShop.Backend.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 10,
                    ProductName = "TestSeedData Product #1",
                    Price = 200,
                    Description = "TestSeedData Product #1",
                    isDeleted = false,
                    Quantity = 0,
                    ImageLink="",
                    CategoryId=1,
                    CreatedDate = new DateTime(2021,7,13)
                }
                );
        }
    }
}

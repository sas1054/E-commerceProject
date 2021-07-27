using Microsoft.AspNetCore.Identity;
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
        public static void SeedUser(this ModelBuilder modelBuilder)
        {
            const string ROLE_ID = "688cc203-353c-4fb9-a309-b2decc46707a";
            const string USER_ID = "4abead03-d561-44a3-8e59-af5243c7aebb";
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = ROLE_ID,
                Name = "admin",
                NormalizedName = "admin"
            });

            const string USER_ROLE = "b6ec3ad1-8b6e-4e19-87b8-e863b55526bc";

            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = USER_ROLE,
                Name = "User",
                NormalizedName = "User"
            });
            var hasher = new PasswordHasher<User>();
            modelBuilder.Entity<User>().HasData(
                new User
                        {
                        Id = USER_ID,
                        UserName = "admin",
                        NormalizedUserName = "admin",
                        Email = "admin@gmail.com",
                        NormalizedEmail = "admin@gmail.com",
                        EmailConfirmed = true,
                        PasswordHash = hasher.HashPassword(null, "admin"),
                        SecurityStamp = string.Empty,
                 
                        });
            

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = ROLE_ID,
                UserId = USER_ID, 
            });

        }
    
        public static void Seed(this ModelBuilder modelBuilder)
        {
            #region
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    ProductName = "Laptop ASUS",
                    Price = 2000,
                    Description = "Laptop ASUS cân mọi thể loại game, tự tin đánh bại tất cả các dòng laptop ngang tầm giá",
                    isDeleted = false,
                    Quantity = 3,
                    ImageLink = "",
                    CategoryId = 1,
                    CreatedDate = new DateTime(2021, 7, 14)
                },
                new Product
                {
                    Id = 2,
                    ProductName = "Laptop Vivo",
                    Price = 1000,
                    Description = "Laptop Vivo phù hợp cho dân văn phòng, xem phim lướt web đánh LOL vô tư",
                    isDeleted = false,
                    Quantity = 3,
                    ImageLink = "",
                    CategoryId = 1,
                    CreatedDate = new DateTime(2021, 7, 15)
                },
                new Product
                {
                    Id = 3,
                    ProductName = "Laptop trung quốc",
                    Price = 700,
                    Description = "Laptop trung quốc dành cho người có ngân khố eo hẹp, giá thành hợp lí",
                    isDeleted = false,
                    Quantity = 3,
                    ImageLink = "",
                    CategoryId = 1,
                    CreatedDate = new DateTime(2021, 7, 13)
                },
                new Product
                {
                    Id = 4,
                    ProductName = "Laptop cũ hàng 2nd số 001",
                    Price = 500,
                    Description = "Laptop cũ hàng dùng rồi số 1 dành cho người có ngân khố eo hẹp, giá thành hợp lí",
                    isDeleted = false,
                    Quantity = 3,
                    ImageLink = "",
                    CategoryId = 1,
                    CreatedDate = new DateTime(2021, 7, 13)
                },
                new Product
                {
                    Id = 5,
                    ProductName = "Laptop cũ hàng 2nd số 002",
                    Price = 400,
                    Description = "Laptop cũ hàng dùng rồi số 2 dành cho người có ngân khố eo hẹp, giá thành hợp lí",
                    isDeleted = false,
                    Quantity = 3,
                    ImageLink = "",
                    CategoryId = 1,
                    CreatedDate = new DateTime(2021, 7, 13)
                },
                new Product
                {
                    Id = 6,
                    ProductName = "Laptop cũ hàng 2nd số 003",
                    Price = 200,
                    Description = "Laptop cũ hàng dùng rồi số 3 dành cho người có ngân khố eo hẹp, giá thành hợp lí",
                    isDeleted = false,
                    Quantity = 3,
                    ImageLink = "",
                    CategoryId = 1,
                    CreatedDate = new DateTime(2021, 7, 13)
                },
                new Product
                {
                    Id = 7,
                    ProductName = "ROG Phone ASUS 144Hz",
                    Price = 1000,
                    Description = "Best gaming phone for rich gamers",
                    isDeleted = false,
                    Quantity = 3,
                    ImageLink = "",
                    CategoryId = 2,
                    CreatedDate = new DateTime(2021, 7, 13)
                },
                new Product
                {
                    Id = 8,
                    ProductName = "IPhèo mười hai Phlus",
                    Price = 1000,
                    Description = "You can buy another charger for 50$",
                    isDeleted = false,
                    Quantity = 3,
                    ImageLink = "",
                    CategoryId = 2,
                    CreatedDate = new DateTime(2021, 7, 16)
                },
                new Product
                {
                    Id = 9,
                    ProductName = "Samsung Phone",
                    Price = 700,
                    Description = "TestSeedData Product #1",
                    isDeleted = false,
                    Quantity = 0,
                    ImageLink = "",
                    CategoryId = 2,
                    CreatedDate = new DateTime(2021, 7, 13)
                },
                new Product
                {
                    Id = 10,
                    ProductName = "Realme Phone",
                    Price = 500,
                    Description = "The phone i'm currently using",
                    isDeleted = false,
                    Quantity = 0,
                    ImageLink="",
                    CategoryId = 2,
                    CreatedDate = new DateTime(2021,7,13)
                },
                new Product
                {
                    Id = 11,
                    ProductName = "XiaoMi Phone",
                    Price = 200,
                    Description = "Xiaomi phone for budget gamers",
                    isDeleted = false,
                    Quantity = 3,
                    ImageLink = "",
                    CategoryId = 2,
                    CreatedDate = new DateTime(2021, 7, 13)
                }
                ,
                new Product
                {
                    Id = 12,
                    ProductName = "Some china phone #1",
                    Price = 100,
                    Description = "China phone for normal using",
                    isDeleted = false,
                    Quantity = 3,
                    ImageLink = "",
                    CategoryId = 2,
                    CreatedDate = new DateTime(2021, 7, 13)
                }
                ,
                new Product
                {
                    Id = 13,
                    ProductName = "IPad",
                    Price = 700,
                    Description = "TestSeedData Product #1",
                    isDeleted = false,
                    Quantity = 0,
                    ImageLink = "",
                    CategoryId = 3,
                    CreatedDate = new DateTime(2021, 7, 13)
                }
                ,
                new Product
                {
                    Id = 14,
                    ProductName = "Samsung Tablet",
                    Price = 600,
                    Description = "TestSeedData Product #1",
                    isDeleted = false,
                    Quantity = 0,
                    ImageLink = "",
                    CategoryId = 3,
                    CreatedDate = new DateTime(2021, 7, 13)
                }
                ,
                new Product
                {
                    Id = 15,
                    ProductName = "Some tablet #1",
                    Price = 200,
                    Description = "TestSeedData Product #1",
                    isDeleted = false,
                    Quantity = 0,
                    ImageLink = "",
                    CategoryId = 3,
                    CreatedDate = new DateTime(2021, 7, 13)
                }
                ,
                new Product
                {
                    Id = 16,
                    ProductName = "Some tablet #2",
                    Price = 200,
                    Description = "TestSeedData Product #1",
                    isDeleted = false,
                    Quantity = 0,
                    ImageLink = "",
                    CategoryId = 3,
                    CreatedDate = new DateTime(2021, 7, 13)
                }
                ,
                new Product
                {
                    Id = 17,
                    ProductName = "Some tablet #3",
                    Price = 200,
                    Description = "TestSeedData Product #1",
                    isDeleted = false,
                    Quantity = 0,
                    ImageLink = "",
                    CategoryId = 3,
                    CreatedDate = new DateTime(2021, 7, 13)
                }
                ,
                new Product
                {
                    Id = 18,
                    ProductName = "Some tablet #4",
                    Price = 200,
                    Description = "TestSeedData Product #1",
                    isDeleted = false,
                    Quantity = 0,
                    ImageLink = "",
                    CategoryId = 3,
                    CreatedDate = new DateTime(2021, 7, 13)
                }
                
                );
            #endregion
            #region
            modelBuilder.Entity<Category>().HasData(
                    new Category
                    {
                        Id = 1,
                        CategoryName = "Laptop",
                        Description = "For all laptop"
                    },
                    new Category
                    {
                        Id = 2,
                        CategoryName = "Mobile Phone",
                        Description = "For all phone"
                    },
                    new Category
                    {
                        Id = 3,
                        CategoryName = "Tablet",
                        Description = "For all tablet"
                    }
                );
            #endregion
        }
    }
}

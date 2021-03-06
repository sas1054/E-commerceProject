// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RookieShop.Backend.Data;

namespace RookieShop.Backend.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = "688cc203-353c-4fb9-a309-b2decc46707a",
                            ConcurrencyStamp = "b62192c8-3a92-4f92-a98d-5d37c543d5a2",
                            Name = "admin",
                            NormalizedName = "admin"
                        },
                        new
                        {
                            Id = "b6ec3ad1-8b6e-4e19-87b8-e863b55526bc",
                            ConcurrencyStamp = "3893b6ae-4a33-424e-938c-a43bf13c9bed",
                            Name = "User",
                            NormalizedName = "User"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");

                    b.HasData(
                        new
                        {
                            UserId = "4abead03-d561-44a3-8e59-af5243c7aebb",
                            RoleId = "688cc203-353c-4fb9-a309-b2decc46707a"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("RookieShop.Backend.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryName = "Laptop",
                            Description = "For all laptop"
                        },
                        new
                        {
                            Id = 2,
                            CategoryName = "Mobile Phone",
                            Description = "For all phone"
                        },
                        new
                        {
                            Id = 3,
                            CategoryName = "Tablet",
                            Description = "For all tablet"
                        });
                });

            modelBuilder.Entity("RookieShop.Backend.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<bool>("isDeleted")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            CreatedDate = new DateTime(2021, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Laptop ASUS cân mọi thể loại game, tự tin đánh bại tất cả các dòng laptop ngang tầm giá",
                            ImageLink = "",
                            Price = 2000m,
                            ProductName = "Laptop ASUS",
                            Quantity = 3,
                            Rating = 0,
                            isDeleted = false
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            CreatedDate = new DateTime(2021, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Laptop Vivo phù hợp cho dân văn phòng, xem phim lướt web đánh LOL vô tư",
                            ImageLink = "",
                            Price = 1000m,
                            ProductName = "Laptop Vivo",
                            Quantity = 3,
                            Rating = 0,
                            isDeleted = false
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            CreatedDate = new DateTime(2021, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Laptop trung quốc dành cho người có ngân khố eo hẹp, giá thành hợp lí",
                            ImageLink = "",
                            Price = 700m,
                            ProductName = "Laptop trung quốc",
                            Quantity = 3,
                            Rating = 0,
                            isDeleted = false
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 1,
                            CreatedDate = new DateTime(2021, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Laptop cũ hàng dùng rồi số 1 dành cho người có ngân khố eo hẹp, giá thành hợp lí",
                            ImageLink = "",
                            Price = 500m,
                            ProductName = "Laptop cũ hàng 2nd số 001",
                            Quantity = 3,
                            Rating = 0,
                            isDeleted = false
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 1,
                            CreatedDate = new DateTime(2021, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Laptop cũ hàng dùng rồi số 2 dành cho người có ngân khố eo hẹp, giá thành hợp lí",
                            ImageLink = "",
                            Price = 400m,
                            ProductName = "Laptop cũ hàng 2nd số 002",
                            Quantity = 3,
                            Rating = 0,
                            isDeleted = false
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 1,
                            CreatedDate = new DateTime(2021, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Laptop cũ hàng dùng rồi số 3 dành cho người có ngân khố eo hẹp, giá thành hợp lí",
                            ImageLink = "",
                            Price = 200m,
                            ProductName = "Laptop cũ hàng 2nd số 003",
                            Quantity = 3,
                            Rating = 0,
                            isDeleted = false
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 2,
                            CreatedDate = new DateTime(2021, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Best gaming phone for rich gamers",
                            ImageLink = "",
                            Price = 1000m,
                            ProductName = "ROG Phone ASUS 144Hz",
                            Quantity = 3,
                            Rating = 0,
                            isDeleted = false
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 2,
                            CreatedDate = new DateTime(2021, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "You can buy another charger for 50$",
                            ImageLink = "",
                            Price = 1000m,
                            ProductName = "IPhèo mười hai Phlus",
                            Quantity = 3,
                            Rating = 0,
                            isDeleted = false
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 2,
                            CreatedDate = new DateTime(2021, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "TestSeedData Product #1",
                            ImageLink = "",
                            Price = 700m,
                            ProductName = "Samsung Phone",
                            Quantity = 0,
                            Rating = 0,
                            isDeleted = false
                        },
                        new
                        {
                            Id = 10,
                            CategoryId = 2,
                            CreatedDate = new DateTime(2021, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "The phone i'm currently using",
                            ImageLink = "",
                            Price = 500m,
                            ProductName = "Realme Phone",
                            Quantity = 0,
                            Rating = 0,
                            isDeleted = false
                        },
                        new
                        {
                            Id = 11,
                            CategoryId = 2,
                            CreatedDate = new DateTime(2021, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Xiaomi phone for budget gamers",
                            ImageLink = "",
                            Price = 200m,
                            ProductName = "XiaoMi Phone",
                            Quantity = 3,
                            Rating = 0,
                            isDeleted = false
                        },
                        new
                        {
                            Id = 12,
                            CategoryId = 2,
                            CreatedDate = new DateTime(2021, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "China phone for normal using",
                            ImageLink = "",
                            Price = 100m,
                            ProductName = "Some china phone #1",
                            Quantity = 3,
                            Rating = 0,
                            isDeleted = false
                        },
                        new
                        {
                            Id = 13,
                            CategoryId = 3,
                            CreatedDate = new DateTime(2021, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "TestSeedData Product #1",
                            ImageLink = "",
                            Price = 700m,
                            ProductName = "IPad",
                            Quantity = 0,
                            Rating = 0,
                            isDeleted = false
                        },
                        new
                        {
                            Id = 14,
                            CategoryId = 3,
                            CreatedDate = new DateTime(2021, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "TestSeedData Product #1",
                            ImageLink = "",
                            Price = 600m,
                            ProductName = "Samsung Tablet",
                            Quantity = 0,
                            Rating = 0,
                            isDeleted = false
                        },
                        new
                        {
                            Id = 15,
                            CategoryId = 3,
                            CreatedDate = new DateTime(2021, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "TestSeedData Product #1",
                            ImageLink = "",
                            Price = 200m,
                            ProductName = "Some tablet #1",
                            Quantity = 0,
                            Rating = 0,
                            isDeleted = false
                        },
                        new
                        {
                            Id = 16,
                            CategoryId = 3,
                            CreatedDate = new DateTime(2021, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "TestSeedData Product #1",
                            ImageLink = "",
                            Price = 200m,
                            ProductName = "Some tablet #2",
                            Quantity = 0,
                            Rating = 0,
                            isDeleted = false
                        },
                        new
                        {
                            Id = 17,
                            CategoryId = 3,
                            CreatedDate = new DateTime(2021, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "TestSeedData Product #1",
                            ImageLink = "",
                            Price = 200m,
                            ProductName = "Some tablet #3",
                            Quantity = 0,
                            Rating = 0,
                            isDeleted = false
                        },
                        new
                        {
                            Id = 18,
                            CategoryId = 3,
                            CreatedDate = new DateTime(2021, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "TestSeedData Product #1",
                            ImageLink = "",
                            Price = 200m,
                            ProductName = "Some tablet #4",
                            Quantity = 0,
                            Rating = 0,
                            isDeleted = false
                        });
                });

            modelBuilder.Entity("RookieShop.Backend.Models.ProductReview", b =>
                {
                    b.Property<string>("ReviewId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateReview")
                        .HasColumnType("datetime2");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ReviewId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductReviews");
                });

            modelBuilder.Entity("RookieShop.Backend.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new
                        {
                            Id = "4abead03-d561-44a3-8e59-af5243c7aebb",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "d7105a0d-0c43-4b3d-b771-169319d419bb",
                            Email = "admin@gmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "admin@gmail.com",
                            NormalizedUserName = "admin",
                            PasswordHash = "AQAAAAEAACcQAAAAEMHHweI2JnsUPIA9Zwagk10qbN/jP6zy8fwVQZImhQdWdC7bnitkTnEUt5XF365sQA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "admin"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("RookieShop.Backend.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("RookieShop.Backend.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RookieShop.Backend.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("RookieShop.Backend.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RookieShop.Backend.Models.Product", b =>
                {
                    b.HasOne("RookieShop.Backend.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("RookieShop.Backend.Models.ProductReview", b =>
                {
                    b.HasOne("RookieShop.Backend.Models.Product", "Product")
                        .WithMany("CustomerReviews")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("RookieShop.Backend.Models.Product", b =>
                {
                    b.Navigation("CustomerReviews");
                });
#pragma warning restore 612, 618
        }
    }
}

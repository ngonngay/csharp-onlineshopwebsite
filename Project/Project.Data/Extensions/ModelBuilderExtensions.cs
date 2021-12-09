using Project.Data.Entities;
using Project.Data.Enums;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;
using System.Linq;

namespace Project.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
       
        public static void Seed(this ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    Id = -1,
                    IsShowOnHome = true,
                    ParentId = null,
                    SortOrder = 1,
                    Status = Status.Active,
                    Name = "Jean",
                    Description = "Jean",
                },new Category()
                 {
                     Id = -2,
                     IsShowOnHome = true,
                     ParentId = null,
                     SortOrder = 2,
                     Status = Status.Active,
                     Name = "Váy",
                     Description = "Váy",

                 },new Category()
                 {
                     Id = -3,
                     IsShowOnHome = false,
                     ParentId = null,
                     SortOrder = 3,
                     Status = Status.Active,
                     Name = "StreetStyle",
                     Description = "StreetStyle",

                 },new Category()
                  {
                      Id = -4,
                      IsShowOnHome = false,
                      ParentId = null,
                      SortOrder = 3,
                      Status = Status.Active,
                      Name = "TShirt",
                      Description = "Áo Phông",

                  });
            modelBuilder.Entity<Product>().HasData(
               new Product()
               {
                   Id = 1,
                   DateCreated = DateTime.Now,
                   Name = "SKINNY",
                   Description = "99% Cotton, 1% Elastane . Bền Vững Khi Giặt Máy . Skinny Ôm Sát Và Tôn Lên Những Đường Nét Quyến Rũ Của Bạn",
                   //Details = "SẢN PHẨM ĐƯỢC CUNG CẤP BỞI TARTARUSS",
                   Price = 200000,
                   Stock = 0,
                   ViewCount = 0,
                   IsFeatured=true
                   //Categories=categories
               },
               new Product()
               {
                   Id = 2,
                   DateCreated = DateTime.Now,
                   Name = "ORGINAL SHORT",
                   Description = "100% Cotton . Sản Phẩm Mang Đậm Phong Cách Cá Tính Và Không Kém Phần Quyến Rũ. Orginal Được Thiết Kế Để Có Thể Ôm Sát Vòng Ba Và Tôn Lên Làn Da Của Bạn",
                   //Details = "SẢN PHẨM ĐƯỢC CUNG CẤP BỞI TARTARUSS",
                   Price = 200000,
                   Stock = 0,
                   ViewCount = 0,
                   IsFeatured = true
                   //Categories = categories
               },
               new Product()
               {
                   Id = -1,
                   DateCreated = DateTime.Now,
                   Name = "TOPS",
                   Description = "100% Cotton . TOPS Với Thiết Kế Cạp Cao Sẽ Mang Lại Cho Bạn Cảm Giác Tự tin , Thích Hợp Để Phối Với Những Dạng Áo ONTOP cá tính",
                   //Details = "SẢN PHẨM ĐƯỢC CUNG CẤP BỞI TARTARUSS",
                   Price = 200000,
                   Stock = 0,
                   ViewCount = 0,
                   IsFeatured = true
                   //Categories = categories
               },
               new Product()
               {
                   Id = -2,
                   DateCreated = DateTime.Now,
                   Name = "BOYFRIEND",
                   Description = "Vâng , Đúng Như Cái Tên Của Nó, BoyFriend Sẽ Là Người Bạn Đồng Hành Của Bạn Trong Mọi Thời Điểm Của Cuộc Sống, BOYFRIEND Được Thiết Kết Để Tạo Cho Bạn Cảm Giác Thoải Mái, Sang Trọng Và An Toàn",
                   //Details = "SẢN PHẨM ĐƯỢC CUNG CẤP BỞI TARTARUSS",
                   Price = 200000,
                   Stock = 0,
                   ViewCount = 0,
                   IsFeatured = true
                   //Categories = categories
               },
               new Product()
               {
                   Id = -3,
                   DateCreated = DateTime.Now,
                   Name = "EmDay",
                   Description = "Chủ nhật là Sunday \n Thứ hai là Monday \n Ngày nào cũng xinh đẹp là Emday",
                   //Details = "SẢN PHẨM ĐƯỢC CUNG CẤP BỞI TARTARUSS",
                   Price = 200000,
                   Stock = 0,
                   ViewCount = 0,
                   IsFeatured = true
                   //Categories=categories
               },
               new Product()
               {
                   Id = -4,
                   DateCreated = DateTime.Now,
                   Name = "Flash",
                   Description = "Một thoáng hương tình dịu ngọt \n Một chút nhẹ nhàng bay bổng và hết sức yêu kiều \n Một item thật sự gây lưu luyến đó các tình iuuu",
                   //Details = "SẢN PHẨM ĐƯỢC CUNG CẤP BỞI TARTARUSS",
                   Price = 200000,
                   Stock = 0,
                   ViewCount = 0,
                   IsFeatured = true
                   //Categories=categories
               },
               new Product()
               {
                   Id = -5,
                   DateCreated = DateTime.Now,
                   Name = "EmWear",
                   Description = "Emwear là thương hiệu quần jean và thời trang Nữ hằng ngày đa dụng . Sử dụng chính chất liệu co dãn cao cấp, thiết kế quyến rũ, sang trọng.",
                   //Details = "SẢN PHẨM ĐƯỢC CUNG CẤP BỞI TARTARUSS",
                   Price = 200000,
                   Stock = 0,
                   ViewCount = 0,
                   IsFeatured = true
                   //Categories=categories
               },
               new Product()
               {
                   Id = -6,
                   DateCreated = DateTime.Now,
                   Name = "Marid",
                   Description = "Cá tính là yếu tố tạo nên sự cuốn hút của Marid \n Marid sẽ mang lại cho người mặc một cảm giác trẻ trung, tươi mát, năng động",
                   //Details = "SẢN PHẨM ĐƯỢC CUNG CẤP BỞI TARTARUSS",
                   Price = 200000,
                   Stock = 0,
                   ViewCount = 0,
                   IsFeatured = true
                   //Categories=categories
               },
               new Product()
               {
                   Id = -7,
                   DateCreated = DateTime.Now,
                   Name = "BELLE",
                   Description = "Vẫn là một sản phẩm của bộ sưu tập jean tháng 7, BELLE sẽ ôm sát và tôn lên những đường cong quyến rũ của bạn. Bằng chất liệu co dãn ,BELLE sẽ không làm bạn bị khó chịu mất tự tin",
                   //Details = "SẢN PHẨM ĐƯỢC CUNG CẤP BỞI TARTARUSS",
                   Price = 200000,
                   Stock = 0,
                   ViewCount = 0,
                   IsFeatured = true
                   //Categories=categories
               },
               new Product()
               {
                   Id = -8,
                   DateCreated = DateTime.Now,
                   Name = "LIMMA Set",
                   Description = "Set đồ được cung cấp từ hãng thời trang nổi tiếng Tartarus, Đây sẽ là set đồ nên xuất hiện trong tủ đồ của bạn",
                   //Details = "SẢN PHẨM ĐƯỢC CUNG CẤP BỞI TARTARUSS",
                   Price = 200000,
                   Stock = 0,
                   ViewCount = 0,
                   IsFeatured = true
                   //Categories=categories
               },
               new Product()
               {
                   Id = -9,
                   DateCreated = DateTime.Now,
                   Name = "BNW",
                   Description = "Với tông màu trẻ trung, sản phẩm sẽ là người bạn đồng hành của bạn trong những buổi dạo phố cuối tuần",
                   //Details = "SẢN PHẨM ĐƯỢC CUNG CẤP BỞI TARTARUSS",
                   Price = 200000,
                   Stock = 0,
                   ViewCount = 0,
                   IsFeatured = true
                   //Categories=categories
               },
               new Product()
               {
                   Id = -10,
                   DateCreated = DateTime.Now,
                   Name = "MOON",
                   Description = "Đúng như tên gọi của nó, MOON sẽ thu hút mọi ánh nhìn của những người xung quanh bằng sự quyến rũ nhẹ nhàng",
                   //Details = "SẢN PHẨM ĐƯỢC CUNG CẤP BỞI TARTARUSS",
                   Price = 200000,
                   Stock = 0,
                   ViewCount = 0,
                   IsFeatured = true
                   //Categories=categories
               },
               new Product()
               {
                   Id = -11,
                   DateCreated = DateTime.Now,
                   Name = "JAQUAIN",
                   Description = "Sự kết hợp hài hòa các màu sắc với nhau, mang nét riêng đậm chất Pháp tạo nên sự rung cảm cho người nhìn",
                   //Details = "SẢN PHẨM ĐƯỢC CUNG CẤP BỞI TARTARUSS",
                   Price = 200000,
                   Stock = 0,
                   ViewCount = 0,
                   IsFeatured = true
                   //Categories=categories
               },
               new Product()
               {
                   Id = -12,
                   DateCreated = DateTime.Now,
                   Name = "ELiS",
                   Description = "Là Một sản phẩm được cung cấp bởi thương hiệu thời trang phụ nữ Tartarus , ELiS vừa mang chất Ý vừa mang chất Việt. Chúng tôi đảm bảo đây sẽ là sản phẩm xu hướng trong tương lai",
                   //Details = "SẢN PHẨM ĐƯỢC CUNG CẤP BỞI TARTARUSS",
                   Price = 200000,
                   Stock = 0,
                   ViewCount = 0,
                   IsFeatured = true
                   //Categories=categories
               },
               new Product()
               {
                   Id = -13,
                   DateCreated = DateTime.Now,
                   Name = "Smooth",
                   Description = "Mượn mà , mang lại cảm giác tươi mát, sản phẩm là lựa chọn hàng đâu cho mùa hè này ",
                   //Details = "SẢN PHẨM ĐƯỢC CUNG CẤP BỞI TARTARUSS",
                   Price = 200000,
                   Stock = 0,
                   ViewCount = 0,
                   IsFeatured = true
                   //Categories=categories
               });
            modelBuilder.Entity("CategoryProduct").HasData(
                      new Dictionary<string, object> { ["ProductsId"] = 1, ["CategoriesId"] = -1 },
                      new Dictionary<string, object> { ["ProductsId"] = 1, ["CategoriesId"] = -2 },
                      new Dictionary<string, object> { ["ProductsId"] = -2, ["CategoriesId"] = -1 },
                      new Dictionary<string, object> { ["ProductsId"] = -1, ["CategoriesId"] = -1 },
                      new Dictionary<string, object> { ["ProductsId"] = 2, ["CategoriesId"] = -1 },
                      new Dictionary<string, object> { ["ProductsId"] = -3, ["CategoriesId"] = -3 },
                      new Dictionary<string, object> { ["ProductsId"] = -3, ["CategoriesId"] = -4 },
                      new Dictionary<string, object> { ["ProductsId"] = -4, ["CategoriesId"] = -4 },
                      new Dictionary<string, object> { ["ProductsId"] = -5, ["CategoriesId"] = -4 },
                      new Dictionary<string, object> { ["ProductsId"] = -5, ["CategoriesId"] =-3 },
                      new Dictionary<string, object> { ["ProductsId"] = -6, ["CategoriesId"] =-1 },
                      new Dictionary<string, object> { ["ProductsId"] = -6, ["CategoriesId"] =-2 },
                      new Dictionary<string, object> { ["ProductsId"] = -6, ["CategoriesId"] =-3 },
                      new Dictionary<string, object> { ["ProductsId"] = -7, ["CategoriesId"] =-3 },
                      new Dictionary<string, object> { ["ProductsId"] = -8, ["CategoriesId"] =-4 },
                      new Dictionary<string, object> { ["ProductsId"] = -9, ["CategoriesId"] =-1 },
                      new Dictionary<string, object> { ["ProductsId"] = -10, ["CategoriesId"] =-1 },
                      new Dictionary<string, object> { ["ProductsId"] = -11, ["CategoriesId"] =-4},
                      new Dictionary<string, object> { ["ProductsId"] = -12, ["CategoriesId"] =-4},
                      new Dictionary<string, object> { ["ProductsId"] = -13, ["CategoriesId"] =-2},
                      new Dictionary<string, object> { ["ProductsId"] = -1, ["CategoriesId"] = -2 }
                    );
            modelBuilder.Entity<ProductImage>().HasData(
                new ProductImage()
                {
                    Id = -1,
                    ProductId = -1,
                    Caption = "Image",
                    DateCreated = DateTime.Now,
                    FileSize = 0,
                    ImagePath = "/user-content/jean/jean1.png",
                    IsDefault = true,
                    SortOrder = 0
                }, new ProductImage()
                {
                    Id = -2,
                    ProductId = -1,
                    Caption = "Image",
                    DateCreated = DateTime.Now,
                    FileSize = 0,
                    ImagePath = "/user-content/jean/jean2.png",
                    IsDefault = true,
                    SortOrder = 0
                }, new ProductImage()
                {
                    Id = -3,
                    ProductId = -1,
                    Caption = "Image",
                    DateCreated = DateTime.Now,
                    FileSize = 0,
                    ImagePath = "/user-content/jean/jean3.png",
                    IsDefault = true,
                    SortOrder = 0
                }, new ProductImage()
                {
                    Id = -4,
                    ProductId = -1,
                    Caption = "Image",
                    DateCreated = DateTime.Now,
                    FileSize = 0,
                    ImagePath = "/user-content/jean/jean4.png",
                    IsDefault = true,
                    SortOrder = 0
                }, new ProductImage()
                {
                    Id = -5,
                    ProductId = -1,
                    Caption = "Image",
                    DateCreated = DateTime.Now,
                    FileSize = 0,
                    ImagePath = "/user-content/jean/jean5.png",
                    IsDefault = true,
                    SortOrder = 0
                }, new ProductImage()
                {
                    Id = -6,
                    ProductId = -2,
                    Caption = "Image",
                    DateCreated = DateTime.Now,
                    FileSize = 0,
                    ImagePath = "/user-content/jean/jean6.png",
                    IsDefault = true,
                    SortOrder = 0
                }, new ProductImage()
                {
                    Id = -7,
                    ProductId = -2,
                    Caption = "Image",
                    DateCreated = DateTime.Now,
                    FileSize = 0,
                    ImagePath = "/user-content/jean/jean7.png",
                    IsDefault = true,
                    SortOrder = 0
                }, new ProductImage()
                {
                    Id = -8,
                    ProductId = -2,
                    Caption = "Image",
                    DateCreated = DateTime.Now,
                    FileSize = 0,
                    ImagePath = "/user-content/jean/jean8.png",
                    IsDefault = true,
                    SortOrder = 0
                }, new ProductImage()
                {
                    Id = -9,
                    ProductId = -2,
                    Caption = "Image",
                    DateCreated = DateTime.Now,
                    FileSize = 0,
                    ImagePath = "/user-content/jean/jean9.png",
                    IsDefault = true,
                    SortOrder = 0
                }, new ProductImage()
                {
                    Id = -10,
                    ProductId = -2,
                    Caption = "Image",
                    DateCreated = DateTime.Now,
                    FileSize = 0,
                    ImagePath = "/user-content/jean/jean10.png",
                    IsDefault = true,
                    SortOrder = 0
                }, new ProductImage()
                {
                    Id = -11,
                    ProductId = -3,
                    Caption = "Image",
                    DateCreated = DateTime.Now,
                    FileSize = 0,
                    ImagePath = "/user-content/tshirt/tshirt1.png",
                    IsDefault = true,
                    SortOrder = 0
                }, new ProductImage()
                {
                    Id = -12,
                    ProductId = -3,
                    Caption = "Image",
                    DateCreated = DateTime.Now,
                    FileSize = 0,
                    ImagePath = "/user-content/tshirt/tshirt2.png",
                    IsDefault = true,
                    SortOrder = 0
                }, new ProductImage()
                {
                    Id = -13,
                    ProductId = -3,
                    Caption = "Image",
                    DateCreated = DateTime.Now,
                    FileSize = 0,
                    ImagePath = "/user-content/tshirt/tshirt3.png",
                    IsDefault = true,
                    SortOrder = 0
                }, new ProductImage()
                {
                    Id = -14,
                    ProductId = -3,
                    Caption = "Image",
                    DateCreated = DateTime.Now,
                    FileSize = 0,
                    ImagePath = "/user-content/tshirt/tshirt4.png",
                    IsDefault = true,
                    SortOrder = 0
                }, new ProductImage()
                {
                    Id = -15,
                    ProductId = -3,
                    Caption = "Image",
                    DateCreated = DateTime.Now,
                    FileSize = 0,
                    ImagePath = "/user-content/tshirt/tshirt5.png",
                    IsDefault = true,
                    SortOrder = 0
                }, new ProductImage()
                {
                    Id = -16,
                    ProductId = -4,
                    Caption = "Image",
                    DateCreated = DateTime.Now,
                    FileSize = 0,
                    ImagePath = "/user-content/tshirt/tshirt6.png",
                    IsDefault = true,
                    SortOrder = 0
                }, new ProductImage()
                {
                    Id = -17,
                    ProductId = -4,
                    Caption = "Image",
                    DateCreated = DateTime.Now,
                    FileSize = 0,
                    ImagePath = "/user-content/tshirt/tshirt7.png",
                    IsDefault = true,
                    SortOrder = 0
                }, new ProductImage()
                {
                    Id = -18,
                    ProductId = -4,
                    Caption = "Image",
                    DateCreated = DateTime.Now,
                    FileSize = 0,
                    ImagePath = "/user-content/tshirt/tshirt8.png",
                    IsDefault = true,
                    SortOrder = 0
                }, new ProductImage()
                {
                    Id = -19,
                    ProductId = -4,
                    Caption = "Image",
                    DateCreated = DateTime.Now,
                    FileSize = 0,
                    ImagePath = "/user-content/tshirt/tshirt8.png",
                    IsDefault = true,
                    SortOrder = 0
                }, new ProductImage()
                {
                    Id = -20,
                    ProductId = -4,
                    Caption = "Image",
                    DateCreated = DateTime.Now,
                    FileSize = 0,
                    ImagePath = "/user-content/tshirt/tshirt9.png",
                    IsDefault = true,
                    SortOrder = 0
                }, new ProductImage()
                {
                    Id = -21,
                    ProductId = -4,
                    Caption = "Image",
                    DateCreated = DateTime.Now,
                    FileSize = 0,
                    ImagePath = "/user-content/tshirt/tshirt10.png",
                    IsDefault = true,
                    SortOrder = 0
                }, new ProductImage()
                {
                    Id = -22,
                    ProductId = -5,
                    Caption = "Image",
                    DateCreated = DateTime.Now,
                    FileSize = 0,
                    ImagePath = "/user-content/tshirt/tshirt11.png",
                    IsDefault = true,
                    SortOrder = 0
                }, new ProductImage()
                {
                    Id = -23,
                    ProductId = -5,
                    Caption = "Image",
                    DateCreated = DateTime.Now,
                    FileSize = 0,
                    ImagePath = "/user-content/tshirt/tshirt12.png",
                    IsDefault = true,
                    SortOrder = 0
                }, new ProductImage()
                {
                    Id = -24,
                    ProductId = -5,
                    Caption = "Image",
                    DateCreated = DateTime.Now,
                    FileSize = 0,
                    ImagePath = "/user-content/tshirt/tshirt13.png",
                    IsDefault = true,
                    SortOrder = 0
                }, new ProductImage()
                {
                    Id = -25,
                    ProductId = -5,
                    Caption = "Image",
                    DateCreated = DateTime.Now,
                    FileSize = 0,
                    ImagePath = "/user-content/tshirt/tshirt15.png",
                    IsDefault = true,
                    SortOrder = 0
                }, new ProductImage()
                {
                    Id = -26,
                    ProductId = -5,
                    Caption = "Image",
                    DateCreated = DateTime.Now,
                    FileSize = 0,
                    ImagePath = "/user-content/tshirt/tshirt14.png",
                    IsDefault = true,
                    SortOrder = 0
                }, new ProductImage()
                {
                    Id = -27,
                    ProductId = -6,
                    Caption = "Image",
                    DateCreated = DateTime.Now,
                    FileSize = 0,
                    ImagePath = "/user-content/tshirt/tshirt11.png",
                    IsDefault = true,
                    SortOrder = 0
                }, new ProductImage()
                {
                    Id = -28,
                    ProductId = -6,
                    Caption = "Image",
                    DateCreated = DateTime.Now,
                    FileSize = 0,
                    ImagePath = "/user-content/tshirt/tshirt12.png",
                    IsDefault = true,
                    SortOrder = 0
                }, new ProductImage()
                {
                    Id = -29,
                    ProductId = -6,
                    Caption = "Image",
                    DateCreated = DateTime.Now,
                    FileSize = 0,
                    ImagePath = "/user-content/tshirt/tshirt13.png",
                    IsDefault = true,
                    SortOrder = 0
                }, new ProductImage()
                {
                    Id = -30,
                    ProductId = -6,
                    Caption = "Image",
                    DateCreated = DateTime.Now,
                    FileSize = 0,
                    ImagePath = "/user-content/tshirt/tshirt15.png",
                    IsDefault = true,
                    SortOrder = 0
                }, new ProductImage()
                {
                    Id = -31,
                    ProductId = -6,
                    Caption = "Image",
                    DateCreated = DateTime.Now,
                    FileSize = 0,
                    ImagePath = "/user-content/tshirt/tshirt14.png",
                    IsDefault = true,
                    SortOrder = 0
                }, new ProductImage()
                {
                    Id = -32,
                    ProductId = -7,
                    Caption = "Image",
                    DateCreated = DateTime.Now,
                    FileSize = 0,
                    ImagePath = "/user-content/tshirt/tshirt11.png",
                    IsDefault = true,
                    SortOrder = 0
                }, new ProductImage()
                {
                    Id = -33,
                    ProductId = -7,
                    Caption = "Image",
                    DateCreated = DateTime.Now,
                    FileSize = 0,
                    ImagePath = "/user-content/tshirt/tshirt12.png",
                    IsDefault = true,
                    SortOrder = 0
                }, new ProductImage()
                {
                    Id = -34,
                    ProductId = -7,
                    Caption = "Image",
                    DateCreated = DateTime.Now,
                    FileSize = 0,
                    ImagePath = "/user-content/tshirt/tshirt13.png",
                    IsDefault = true,
                    SortOrder = 0
                }, new ProductImage()
                {
                    Id = -35,
                    ProductId = -7,
                    Caption = "Image",
                    DateCreated = DateTime.Now,
                    FileSize = 0,
                    ImagePath = "/user-content/tshirt/tshirt15.png",
                    IsDefault = true,
                    SortOrder = 0
                }, new ProductImage()
                {
                    Id = -36,
                    ProductId = -7,
                    Caption = "Image",
                    DateCreated = DateTime.Now,
                    FileSize = 0,
                    ImagePath = "/user-content/tshirt/tshirt14.png",
                    IsDefault = true,
                    SortOrder = 0
                }, new ProductImage()
                {
                    Id = -37,
                    ProductId = -8,
                    Caption = "Image",
                    DateCreated = DateTime.Now,
                    FileSize = 0,
                    ImagePath = "/user-content/tshirt/tshirt11.png",
                    IsDefault = true,
                    SortOrder = 0
                }, new ProductImage()
                {
                    Id = -38,
                    ProductId = -8,
                    Caption = "Image",
                    DateCreated = DateTime.Now,
                    FileSize = 0,
                    ImagePath = "/user-content/tshirt/tshirt12.png",
                    IsDefault = true,
                    SortOrder = 0
                }, new ProductImage()
                {
                    Id = -39,
                    ProductId = -8,
                    Caption = "Image",
                    DateCreated = DateTime.Now,
                    FileSize = 0,
                    ImagePath = "/user-content/tshirt/tshirt13.png",
                    IsDefault = true,
                    SortOrder = 0
                }, new ProductImage()
                {
                    Id = -40,
                    ProductId = -8,
                    Caption = "Image",
                    DateCreated = DateTime.Now,
                    FileSize = 0,
                    ImagePath = "/user-content/tshirt/tshirt15.png",
                    IsDefault = true,
                    SortOrder = 0
                }, new ProductImage()
                {
                    Id = -41,
                    ProductId = -8,
                    Caption = "Image",
                    DateCreated = DateTime.Now,
                    FileSize = 0,
                    ImagePath = "/user-content/tshirt/tshirt14.png",
                    IsDefault = true,
                    SortOrder = 0
                }, new ProductImage()
                {
                    Id = -42,
                    ProductId = -9,
                    Caption = "Image",
                    DateCreated = DateTime.Now,
                    FileSize = 0,
                    ImagePath = "/user-content/tshirt/tshirt11.png",
                    IsDefault = true,
                    SortOrder = 0
                }, new ProductImage()
                {
                    Id = -43,
                    ProductId = -9,
                    Caption = "Image",
                    DateCreated = DateTime.Now,
                    FileSize = 0,
                    ImagePath = "/user-content/tshirt/tshirt12.png",
                    IsDefault = true,
                    SortOrder = 0
                }, new ProductImage()
                {
                    Id = -44,
                    ProductId = -9,
                    Caption = "Image",
                    DateCreated = DateTime.Now,
                    FileSize = 0,
                    ImagePath = "/user-content/tshirt/tshirt13.png",
                    IsDefault = true,
                    SortOrder = 0
                }, new ProductImage()
                {
                    Id = -45,
                    ProductId = -9,
                    Caption = "Image",
                    DateCreated = DateTime.Now,
                    FileSize = 0,
                    ImagePath = "/user-content/tshirt/tshirt15.png",
                    IsDefault = true,
                    SortOrder = 0
                }, new ProductImage()
                {
                    Id = -46,
                    ProductId = -9,
                    Caption = "Image",
                    DateCreated = DateTime.Now,
                    FileSize = 0,
                    ImagePath = "/user-content/tshirt/tshirt14.png",
                    IsDefault = true,
                    SortOrder = 0
                }, new ProductImage()
                {
                    Id = -47,
                    ProductId = -10,
                    Caption = "Image",
                    DateCreated = DateTime.Now,
                    FileSize = 0,
                    ImagePath = "/user-content/tshirt/tshirt11.png",
                    IsDefault = true,
                    SortOrder = 0
                }, new ProductImage()
                {
                    Id = -48,
                    ProductId = -10,
                    Caption = "Image",
                    DateCreated = DateTime.Now,
                    FileSize = 0,
                    ImagePath = "/user-content/tshirt/tshirt12.png",
                    IsDefault = true,
                    SortOrder = 0
                }, new ProductImage()
                {
                    Id = -49,
                    ProductId = -10,
                    Caption = "Image",
                    DateCreated = DateTime.Now,
                    FileSize = 0,
                    ImagePath = "/user-content/tshirt/tshirt13.png",
                    IsDefault = true,
                    SortOrder = 0
                }, new ProductImage()
                {
                    Id = -50,
                    ProductId = -10,
                    Caption = "Image",
                    DateCreated = DateTime.Now,
                    FileSize = 0,
                    ImagePath = "/user-content/tshirt/tshirt15.png",
                    IsDefault = true,
                    SortOrder = 0
                }, new ProductImage()
                {
                    Id = -51,
                    ProductId = -10,
                    Caption = "Image",
                    DateCreated = DateTime.Now,
                    FileSize = 0,
                    ImagePath = "/user-content/tshirt/tshirt14.png",
                    IsDefault = true,
                    SortOrder = 0
                }, new ProductImage()
                {
                    Id = -52,
                    ProductId = -11,
                    Caption = "Image",
                    DateCreated = DateTime.Now,
                    FileSize = 0,
                    ImagePath = "/user-content/tshirt/tshirt11.png",
                    IsDefault = false,
                    SortOrder = 0
                }, new ProductImage()
                {
                    Id = -53,
                    ProductId = -11,
                    Caption = "Image",
                    DateCreated = DateTime.Now,
                    FileSize = 0,
                    ImagePath = "/user-content/tshirt/tshirt12.png",
                    IsDefault = true,
                    SortOrder = 0
                }, new ProductImage()
                {
                    Id = -54,
                    ProductId = -11,
                    Caption = "Image",
                    DateCreated = DateTime.Now,
                    FileSize = 0,
                    ImagePath = "/user-content/tshirt/tshirt13.png",
                    IsDefault = true,
                    SortOrder = 0
                }, new ProductImage()
                {
                    Id = -55,
                    ProductId = -11,
                    Caption = "Image",
                    DateCreated = DateTime.Now,
                    FileSize = 0,
                    ImagePath = "/user-content/tshirt/tshirt15.png",
                    IsDefault = true,
                    SortOrder = 0
                }, new ProductImage()
                {
                    Id = -56,
                    ProductId = -11,
                    Caption = "Image",
                    DateCreated = DateTime.Now,
                    FileSize = 0,
                    ImagePath = "/user-content/tshirt/tshirt14.png",
                    IsDefault = true,
                    SortOrder = 0
                }, new ProductImage()
                {
                    Id = -57,
                    ProductId = -12,
                    Caption = "Image",
                    DateCreated = DateTime.Now,
                    FileSize = 0,
                    ImagePath = "/user-content/tshirt/tshirt11.png",
                    IsDefault = true,
                    SortOrder = 0
                }, new ProductImage()
                {
                    Id = -58,
                    ProductId = -12,
                    Caption = "Image",
                    DateCreated = DateTime.Now,
                    FileSize = 0,
                    ImagePath = "/user-content/tshirt/tshirt12.png",
                    IsDefault = true,
                    SortOrder = 0
                }, new ProductImage()
                {
                    Id = -59,
                    ProductId = -12,
                    Caption = "Image",
                    DateCreated = DateTime.Now,
                    FileSize = 0,
                    ImagePath = "/user-content/tshirt/tshirt13.png",
                    IsDefault = true,
                    SortOrder = 0
                }, new ProductImage()
                {
                    Id = -60,
                    ProductId = -12,
                    Caption = "Image",
                    DateCreated = DateTime.Now,
                    FileSize = 0,
                    ImagePath = "/user-content/tshirt/tshirt15.png",
                    IsDefault = true,
                    SortOrder = 0
                }, new ProductImage()
                {
                    Id = -61,
                    ProductId = -12,
                    Caption = "Image",
                    DateCreated = DateTime.Now,
                    FileSize = 0,
                    ImagePath = "/user-content/tshirt/tshirt14.png",
                    IsDefault = true,
                    SortOrder = 0
                }, new ProductImage()
                {
                    Id = -62,
                    ProductId = -13,
                    Caption = "Image",
                    DateCreated = DateTime.Now,
                    FileSize = 0,
                    ImagePath = "/user-content/tshirt/tshirt11.png",
                    IsDefault = true,
                    SortOrder = 0
                }, new ProductImage()
                {
                    Id = -63,
                    ProductId = -13,
                    Caption = "Image",
                    DateCreated = DateTime.Now,
                    FileSize = 0,
                    ImagePath = "/user-content/tshirt/tshirt12.png",
                    IsDefault = true,
                    SortOrder = 0
                }, new ProductImage()
                {
                    Id = -64,
                    ProductId = -13,
                    Caption = "Image",
                    DateCreated = DateTime.Now,
                    FileSize = 0,
                    ImagePath = "/user-content/tshirt/tshirt13.png",
                    IsDefault = true,
                    SortOrder = 0
                }, new ProductImage()
                {
                    Id = -65,
                    ProductId = -13,
                    Caption = "Image",
                    DateCreated = DateTime.Now,
                    FileSize = 0,
                    ImagePath = "/user-content/tshirt/tshirt15.png",
                    IsDefault = true,
                    SortOrder = 0
                }, new ProductImage()
                {
                    Id = -66,
                    ProductId = -13,
                    Caption = "Image",
                    DateCreated = DateTime.Now,
                    FileSize = 0,
                    ImagePath = "/user-content/tshirt/tshirt14.png",
                    IsDefault = true,
                    SortOrder = 0
                }, new ProductImage()
                {
                    Id = -67,
                    ProductId = 1,
                    Caption = "Image",
                    DateCreated = DateTime.Now,
                    FileSize = 0,
                    ImagePath = "/user-content/default/product-1.jpg",
                    IsDefault = true,
                    SortOrder = 0
                }, new ProductImage()
                {
                    Id = -68,
                    ProductId = 1,
                    Caption = "Image",
                    DateCreated = DateTime.Now,
                    FileSize = 0,
                    ImagePath = "/user-content/default/product-2.jpg",
                    IsDefault = true,
                    SortOrder = 0
                }, new ProductImage()
                {
                    Id = -69,
                    ProductId = 1,
                    Caption = "Image",
                    DateCreated = DateTime.Now,
                    FileSize = 0,
                    ImagePath = "/user-content/default/product-3.jpg",
                    IsDefault = true,
                    SortOrder = 0
                }, new ProductImage()
                {
                    Id = -70,
                    ProductId = 1,
                    Caption = "Image",
                    DateCreated = DateTime.Now,
                    FileSize = 0,
                    ImagePath = "/user-content/default/product-4.jpg",
                    IsDefault = true,
                    SortOrder = 0
                }, new ProductImage()
                {
                    Id = -71,
                    ProductId = 1,
                    Caption = "Image",
                    DateCreated = DateTime.Now,
                    FileSize = 0,
                    ImagePath = "/user-content/default/product-5.jpg",
                    IsDefault = true,
                    SortOrder = 0
                }, new ProductImage()
                {
                    Id = -72,
                    ProductId = 2,
                    Caption = "Image",
                    DateCreated = DateTime.Now,
                    FileSize = 0,
                    ImagePath = "/user-content/default/product-6.jpg",
                    IsDefault = true,
                    SortOrder = 0
                }, new ProductImage()
                {
                    Id = -73,
                    ProductId = 2,
                    Caption = "Image",
                    DateCreated = DateTime.Now,
                    FileSize = 0,
                    ImagePath = "/user-content/default/product-7.jpg",
                    IsDefault = true,
                    SortOrder = 0
                }, new ProductImage()
                {
                    Id = -74,
                    ProductId = 2,
                    Caption = "Image",
                    DateCreated = DateTime.Now,
                    FileSize = 0,
                    ImagePath = "/user-content/default/product-8.jpg",
                    IsDefault = true,
                    SortOrder = 0
                }, new ProductImage()
                {
                    Id = -75,
                    ProductId = 2,
                    Caption = "Image",
                    DateCreated = DateTime.Now,
                    FileSize = 0,
                    ImagePath = "/user-content/default/product-9.jpg",
                    IsDefault = true,
                    SortOrder = 0
                }, new ProductImage()
                {
                    Id = -76,
                    ProductId = 2,
                    Caption = "Image",
                    DateCreated = DateTime.Now,
                    FileSize = 0,
                    ImagePath = "/user-content/default/product-10.jpg",
                    IsDefault = true,
                    SortOrder = 0
                }
             );

            
            //8D04DCE3-969A-435D-BBA4-DF3F325983DC
            //// any guid
            //string roleId ="8D04DCE2-969A-435D-BBA4-DF3F325983DC";
            //string adminId = "69BD714F-9576-45BA-B5B7-F00649BE00DE";
            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Id = "8D04DCE3-969A-435D-BBA4-DF3F325983DC",
                    Name = "admin",
                    NormalizedName = "ADMIN",
                }, new IdentityRole
                {
                    Id = "8D04DCE2-969A-435D-BBA4-DF3F325983DC",
                    Name = "editor",
                    NormalizedName = "EDITOR",
                }, new IdentityRole
                {
                    Id = "8D04DCC2-969A-435D-BBA4-DF3F315983DC",
                    Name = "customer",
                    NormalizedName = "CUSTOMER",
                }, new IdentityRole
                {
                    Id = "1D04DCC2-969A-435D-BBA4-DF3F315983DC",
                    Name = "staff",
                    NormalizedName = "STAFF",
                });

                var hasher = new PasswordHasher<AppUser>();
                for (int i = 0; i < 10; i++)
                {
                    modelBuilder.Entity<AppUser>().HasData(new AppUser
                    {
                        Id = "10BD711F-9576-45BA-B5B7-F00649BE0" + i + "DE",
                        UserName = "raw-account-customer" + i,
                        NormalizedUserName = "raw-account-customer" + i,
                        Email = "rawaccountcustomer" + i + "@gmail.com",
                        NormalizedEmail = "rawaccountcustomer" + i + "@gmail.com",
                        EmailConfirmed = true,
                        PasswordHash = hasher.HashPassword(null, "123456"),
                        SecurityStamp = string.Empty,
                        Birthday = DateTime.Now

                    });
                    modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                    new IdentityUserRole<string>()
                    {
                       RoleId = "8D04DCC2-969A-435D-BBA4-DF3F315983DC",
                       UserId = "10BD711F-9576-45BA-B5B7-F00649BE0" + i + "DE"
                    });
                    
                }
                for (int i = 0; i < 10; i++)
                {
                    modelBuilder.Entity<AppUser>().HasData(new AppUser
                    {
                        Id = "11BD711F-95" + i + "6-45BA-B5B7-F00649BE0" + i + "DE",
                        UserName = "raw-account-staff" + i,
                        NormalizedUserName = "raw-account-staff" + i,
                        Email = "rawaccountstaff" + i + "@gmail.com",
                        NormalizedEmail = "rawaccountstaff" + i + "@gmail.com",
                        EmailConfirmed = true,
                        PasswordHash = hasher.HashPassword(null, "123456"),
                        SecurityStamp = string.Empty,
                        Birthday = DateTime.Now

                    });
                    modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                    new IdentityUserRole<string>()
                    {
                        RoleId = "1D04DCC2-969A-435D-BBA4-DF3F315983DC",
                        UserId = "11BD711F-95" + i + "6-45BA-B5B7-F00649BE0" + i + "DE"
                    });

                }
            modelBuilder.Entity<AppUser>().HasData(new AppUser
                {
                    Id = "69BD714F-9576-45BA-B5B7-F00649BE00DE",
                    UserName = "Thang-dev",
                    NormalizedUserName = "admin",
                    Email = "thangnguyenquyetvlth@gmail.com",
                    NormalizedEmail = "thangnguyenquyetvlth@gmail.com",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "123456"),
                    SecurityStamp = string.Empty,
                    Birthday = DateTime.Now
                }, new AppUser
                {
                    Id = "69BD711F-9576-45BA-B5B7-F00649BE00DE",
                    UserName = "raw-account1",
                    NormalizedUserName = "raw-account1",
                    Email = "thangnguyenquyetvlth1@gmail.com",
                    NormalizedEmail = "thangnguyenquyetvlth1@gmail.com",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "123456"),
                    SecurityStamp = string.Empty,
                    Birthday = DateTime.Now
                }, new AppUser
                {
                    Id = "69BD712F-9576-45BA-B5B7-F00649BE00DE",
                    UserName = "raw-account2",
                    NormalizedUserName = "raw-account2",
                    Email = "thangnguyenquyetvlth2@gmail.com",
                    NormalizedEmail = "thangnguyenquyetvlth2@gmail.com",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "123456"),
                    SecurityStamp = string.Empty,
                    Birthday = DateTime.Now
                }, new AppUser
                {
                    Id = "61BD714F-9576-45BA-B5B7-F00649BE00DE",
                    UserName = "raw-account3",
                    NormalizedUserName = "raw-account3",
                    Email = "thangnguyenquyetvlth3@gmail.com",
                    NormalizedEmail = "thangnguyenquyetvlth3@gmail.com",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "123456"),
                    SecurityStamp = string.Empty,
                    Birthday = DateTime.Now
                }, new AppUser
                {
                    Id = "19BD714F-9576-45BA-B5B7-F00649BE00DE",
                    UserName = "raw-account4",
                    NormalizedUserName = "raw-account4",
                    Email = "thangnguyenquyetvlth4@gmail.com",
                    NormalizedEmail = "thangnguyenquyetvlth4@gmail.com",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "123456"),
                    SecurityStamp = string.Empty,
                    Birthday = DateTime.Now
                }, new AppUser
                {
                    Id = "65BD710F-9576-45BA-B5B7-F00649BE00DE",
                    UserName = "raw-account5",
                    NormalizedUserName = "raw-account5",
                    Email = "thangnguyenquyetvlth5@gmail.com",
                    NormalizedEmail = "thangnguyenquyetvlth5@gmail.com",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "123456"),
                    SecurityStamp = string.Empty,
                    Birthday = DateTime.Now
                }, new AppUser
                {
                    Id = "69BD714F-9576-45BA-B5B6-F00649BE01DE",
                    UserName = "raw-account6",
                    NormalizedUserName = "raw-account6",
                    Email = "thangnguyenquyetvlth6@gmail.com",
                    NormalizedEmail = "thangnguyenquyetvlth6@gmail.com",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "123456"),
                    SecurityStamp = string.Empty,
                    Birthday = DateTime.Now
                }, new AppUser
                {
                    Id = "09BD714F-9576-45BA-B5B7-F00649BE04DE",
                    UserName = "raw-account7",
                    NormalizedUserName = "raw-account7",
                    Email = "thangnguyenquyetvlth7@gmail.com",
                    NormalizedEmail = "thangnguyenquyetvlth7@gmail.com",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "123456"),
                    SecurityStamp = string.Empty,
                    Birthday = DateTime.Now
                }, new AppUser
                {
                    Id = "69BD114F-9576-45BA-B4B7-F00649BE00DE",
                    UserName = "raw-account8",
                    NormalizedUserName = "raw-account8",
                    Email = "thangnguyenquyetvlth8@gmail.com",
                    NormalizedEmail = "thangnguyenquyetvlth8@gmail.com",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "123456"),
                    SecurityStamp = string.Empty,
                    Birthday=DateTime.Now
                });
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>()
                {
                    RoleId = "8D04DCE3-969A-435D-BBA4-DF3F325983DC",
                    UserId = "69BD714F-9576-45BA-B5B7-F00649BE00DE"
                }, new IdentityUserRole<string>()
                {
                    RoleId = "8D04DCE2-969A-435D-BBA4-DF3F325983DC",
                    UserId = "69BD714F-9576-45BA-B5B7-F00649BE00DE"
                });
            modelBuilder.Entity<IdentityRoleClaim<string>>().HasData(new IdentityRoleClaim<string>()
            {
                Id = -1,
                RoleId = "8D04DCE3-969A-435D-BBA4-DF3F325983DC",
                ClaimType = "permission",
                ClaimValue = "manage.user"
            }) ;
            modelBuilder.Entity<Cart>().HasData(new Cart()
            {
                Id=1,
                UserId= "11BD711F-9506-45BA-B5B7-F00649BE00DE",
                ProductId=-2,
                Quantity=2,
                Price=20000,
                size="M",
                DateCreated=DateTime.Now
            }, new Cart()
            {
                Id = 1,
                UserId = "11BD711F-9506-45BA-B5B7-F00649BE00DE",
                ProductId = -1,
                Quantity = 2,
                Price = 20000,
                size="M",
                DateCreated = DateTime.Now
            });
            
            
            //seed data for address
            string json = string.Empty;
            // read json string from file
            using (StreamReader reader = new StreamReader("data.json"))
            {
                json = reader.ReadToEnd();
            }
            List<City> cities = new List<City>();
            var obj = JsonConvert.DeserializeObject<dynamic>(json);
            int fuck = 1;
            List<int> fuckLife = new List<int>();
            List<Ward> DeadWard = new List<Ward>();
            foreach (var cityite in obj)
            {
                var city = new City();
                city.CityId = cityite["Id"];
                city.Name = cityite["Name"];
                //seed data for city
                modelBuilder.Entity<City>().HasData(new City
                {
                    CityId = city.CityId,
                    Name = city.Name
                });
                //end seed for city
                var JDistricts = cityite["Districts"];//danh sách các phường/huyện của tỉnh dạng Json

                List<District> Districts = new List<District>();
                foreach (var districtIte in JDistricts)
                {
                    var district = new District();
                    district.CityId = city.CityId;
                    district.Id = districtIte["Id"];
                    district.Name = districtIte["Name"];
                    //seed data for district
                    modelBuilder.Entity<District>().HasData(new District
                    {
                        CityId = district.CityId,
                        Id = district.Id,
                        Name = district.Name
                    });
                    //end seed for dustrict
                    var JWards = districtIte["Wards"];//danh sách huyện/xã/tt của huyện dạng Json
                    List<Ward> Wards = new List<Ward>();
                    
                    foreach (var wardite in JWards)
                    {
                        Ward ward = new Ward();
                        ward.CityId = city.CityId;
                        ward.DistrictId = district.Id;
                        ward.Id = wardite["Id"];
                        ward.Name = wardite["Name"];
                        ward.Level = wardite["Level"];
                        //duyệt xong 1 huyện/xã/thị trấn
                        Wards.Add(ward);//thêm vào danh sách xã/thị trấn của 1 huyện
                        //seed data ward
                            modelBuilder.Entity<Ward>().HasData(new Ward
                            {
                                CityId = ward.CityId,
                                DistrictId = ward.DistrictId,
                                Id = ward.Id??(fuck++).ToString(),
                                Name = ward.Name,
                                Level = ward.Level,
                            });
                        if (!fuckLife.Any(x=>x==fuck))
                        {
                            fuckLife.Add(fuck);
                            DeadWard.Add(ward);
                        }
                        //end seed ward
                    }
                    district.Wards = Wards;//gắn vào danh sách xã/tt của huyện
                    Districts.Add(district);//thêm vào danh sách huyện  của tỉnh
                    
                }
                city.Districts = Districts;//gắn vào  danh sách  huyện của tỉnh
                cities.Add(city);//thêm thành phố/tỉnh này vào danh sách các thành phố tỉnh của quốc gia
                
            }
            var count = cities.Count();//đếm thành phố
            //end seed for address
            //seed data for address card
            modelBuilder.Entity<Address>().HasData(new Address()
            {
                AddressCardId=1,
                UserId = "11BD711F-9506-45BA-B5B7-F00649BE00DE",
                CityId= "01",
                City= "Thành phố Hà Nội",
                DistricstId="008",
                Districst= "Quận Hoàng Mai",
                WardsId= "00322",
                Ward= "Phường Hoàng Văn Thụ",
                FullName="Nguyễn Quyết Thắng",
                phoneNumber="0328025122",
                address="353 Đường Tam Trinh",
                status=0,
                isDefault=true
            });
            modelBuilder.Entity<OrderDetail>().HasData(new OrderDetail()
            {
                OrderId = 1,
                ProductId = -2,
                Quantity = 2,
                Price = 20000,
                size = "M",
                productName= "BOYFRIENDs"

            }, new OrderDetail()
            {
                OrderId = 1,
                ProductId = -1,
                Quantity = 2,
                Price = 20000,
                size = "M",
                productName= "TOPS"
            });
            modelBuilder.Entity<Order>().HasData(new Order()
            {
                Id = 1,
                OrderDate = DateTime.Now,
                total=40000,
                UserId = "11BD711F-9506-45BA-B5B7-F00649BE00DE",
                ShipName = "Nguyễn Quyết Thắng",
                ShipAddress = "353 Đường Tam Trinh",
                ShipEmail = "rawaccountstaff0@gmail.com",
                ShipPhoneNumber = "0328025122",
                Status = OrderStatus.New,
                CityId = "01",
                City= "Thành phố Hà Nội",
                DistricstId = "008",
                Districst = "Quận Hoàng Mai",
                WardsId = "00322",
                Wards = "Phường Hoàng Văn Thụ"
            });
            modelBuilder.Entity<Notification>().HasData(new Notification()
            {
                Id = 1,
                UserId = "11BD711F-9506-45BA-B5B7-F00649BE00DE",
                date=DateTime.Now,
                Type=NotificationType.Order,
                Targetint=1,
                content= "Đơn hàng #1 đã sẵn sàng để giao đến quý khách. Chúng tôi vừa bàn giao đơn hàng của quý khách đến đối tác vận chuyển eShops Team. Đơn hàng sẽ được giao trước 23:59 ngày 18/12/2020"
            }, new Notification()
            {
                Id = 2,
                UserId = "11BD711F-9506-45BA-B5B7-F00649BE00DE",
                date = DateTime.Now,
                Type = NotificationType.Promotion,
                Targetint = 1,
                content = "Bạn có một mã giảm giá chưa sử dụng"
            });
            modelBuilder.Entity<Promotion>().HasData(new Promotion() { 
                Id=1,
                ApplyCode= "11BD711F-9506-45BA-B5B7-F00649BE00DE",
                ApplyForAll=true,
                ApplyForProductIds=false,
                ApplyForCategoryIds=false,
                DiscountPercent=50,
                DiscountAmount=null,
                quantity=null,
                FromDate=DateTime.Now,
                ToDate=new DateTime(2022,12,31),
                MaximumDiscountAmountForPecentCoupon = 50000,
                Name = "Mã giảm giá 50% cho tất cả các sản phẩm trong cửa hàng",
                Description="Giảm giá 50% giá trị sản phẩm không quá 50.000 vnđ"
            }, new Promotion()
            {
                Id = 2,
                ApplyCode = "11BD711F-9506-45BA-B5B7-F00649BE01DE",
                ApplyForAll = true,
                ApplyForProductIds = false,
                ApplyForCategoryIds = false,
                DiscountPercent = null,
                DiscountAmount = null,
                MaximumDiscountPercentForAmountCoupon = 25,
                ProductsPromotionId = null,
                quantity = null,
                FromDate = DateTime.Now,
                ToDate = new DateTime(2022, 12, 31),
                Name = "Mã giảm giá 50.000 cho tất cả các sản phẩm trong cửa hàng",
                Description = "Giảm giá 50.000vnđ trên giá trị sản phẩm không quá  25% giá trị sản phẩm"
            }, new Promotion()
            {
                Id = 3,
                ApplyCode = "11BD711F-9506-45BA-B5B7-F00649BE02DE",
                ApplyForAll = false,
                ApplyForProductIds = true,
                ApplyForCategoryIds = false,
                DiscountPercent = 50,
                MaximumDiscountAmountForPecentCoupon=25000,
                DiscountAmount = null,
                ProductsPromotionId=null,
                quantity = null,
                FromDate = DateTime.Now,
                ToDate = new DateTime(2022, 12, 31),
                Name= "Mã giảm giá 50% cho  các sản phẩm có mã hợp lệ trong cửa hàng",
                Description = "Giảm giá 50% trên giá trị của  sản phẩm có mã hợp lệ không quá  25.000vnđ trên giá trị sản phẩm"
            }, new Promotion()
            {
                Id = 4,
                ApplyCode = "11BD711F-9506-45BA-B5B7-F00649BE03DE",
                ApplyForAll = false,
                ApplyForProductIds = true,
                ApplyForCategoryIds = false,
                ApplyForOrderTotal = false,
                DiscountPercent = null,
                MaximumDiscountAmountForPecentCoupon = null,
                DiscountAmount = 50000,
                MaximumDiscountPercentForAmountCoupon=25,
                ProductsPromotionId = null,
                quantity = null,
                FromDate = DateTime.Now,
                ToDate = new DateTime(2022, 12, 31),
                Name = "Mã giảm giá 50000 cho  các sản phẩm có mã hợp lệ trong cửa hàng",
                Description = "Giảm giá 50000 trên giá trị của  sản phẩm có mã hợp lệ không quá  25% trên giá trị sản phẩm"
            }, new Promotion()
            {
                Id = 5,
                ApplyCode = "11BD711F-9506-45BA-B5B7-F00649BE04DE",
                ApplyForAll = false,
                ApplyForProductIds = false,
                ApplyForCategoryIds = true,
                ApplyForOrderTotal = false,
                DiscountPercent = null,
                MaximumDiscountAmountForPecentCoupon = null,
                DiscountAmount = 50000,
                MaximumDiscountPercentForAmountCoupon = 10,
                ProductsPromotionId = null,
                quantity = null,
                FromDate = DateTime.Now,
                ToDate = new DateTime(2022, 12, 31),
                Name = "Mã giảm giá 50000 cho  các sản phẩm thuộc danh mục xxx trong cửa hàng",
                Description = "Giảm giá 50000 trên giá trị của  sản phẩm thuộc danh mục xxx không quá  10% trên giá trị sản phẩm"
            }, new Promotion()
            {
                Id = 6,
                ApplyCode = "11BD711F-9506-45BA-B5B7-F00649BE06DE",
                ApplyForAll = false,
                ApplyForProductIds = false,
                ApplyForCategoryIds = true,
                ApplyForOrderTotal = false,
                DiscountPercent = 50,
                MaximumDiscountAmountForPecentCoupon = 10000,
                DiscountAmount = null,
                MaximumDiscountPercentForAmountCoupon = null,
                ProductsPromotionId = null,
                quantity = null,
                FromDate = DateTime.Now,
                ToDate = new DateTime(2022, 12, 31),
                Name = "Mã giảm giá 50% cho  các sản phẩm thuộc danh mục xxx trong cửa hàng",
                Description = "Giảm giá 50% trên giá trị của  sản phẩm thuộc danh mục xxx không quá  10000 trên giá trị sản phẩm"
            }, new Promotion()
            {
                Id = 7,
                ApplyCode = "11BD711F-9506-45BA-B5B7-F00649BE07DE",
                ApplyForAll = false,
                ApplyForProductIds = false,
                ApplyForCategoryIds = false,
                ApplyForOrderTotal=true,
                MinimumTotalOrder=10000,
                DiscountPercent = 50,
                MaximumDiscountAmountForPecentCoupon = 10000,
                DiscountAmount = null,
                MaximumDiscountPercentForAmountCoupon = null,
                ProductsPromotionId = null,
                quantity = null,
                FromDate = DateTime.Now,
                ToDate = new DateTime(2022, 12, 31),
                Name = "Mã giảm giá 50% cho  đơn hàng từ 10.000",
                Description = "Giảm giá 50% trên giá trị của  đơn hàng từ 10.000 không quá 10.000"
            }, new Promotion()
            {
                Id = 8,
                ApplyCode = "11BD711F-9506-45BA-B5B7-F00649BE08DE",
                ApplyForAll = false,
                ApplyForProductIds = false,
                ApplyForCategoryIds = false,
                ApplyForOrderTotal = true,
                MinimumTotalOrder = 10000,
                DiscountPercent = null,
                MaximumDiscountAmountForPecentCoupon = null,
                DiscountAmount = 10000,
                MaximumDiscountPercentForAmountCoupon = 100,
                ProductsPromotionId = null,
                quantity = null,
                FromDate = DateTime.Now,
                ToDate = new DateTime(2022, 12, 31),
                Name = "Mã giảm giá 10.000vnđ cho  đơn hàng từ 10.000vnđ",
                Description = "Giảm giá 10.000vđ trên giá trị của  đơn hàng từ 10.000vnđ "
            });
            modelBuilder.Entity<ProductPromotion>().HasData(new ProductPromotion()
            {
                ProductId=-1,
                PromotionId=3
            }, new ProductPromotion()
            {
                ProductId = -2,
                PromotionId = 3
            }, new ProductPromotion()
            {
                ProductId = -3,
                PromotionId = 4
            }, new ProductPromotion()
            {
                ProductId = -4,
                PromotionId = 4
            });
            modelBuilder.Entity<CategoryPromotion>().HasData(new CategoryPromotion()
            {
                CategoryId = -1,
                PromotionId = 5
            }, new CategoryPromotion()
            {
                CategoryId = -4,
                PromotionId = 6
            });
        }
    }
}
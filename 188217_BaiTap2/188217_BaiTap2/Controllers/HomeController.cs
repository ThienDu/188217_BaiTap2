﻿using _188217_BaiTap2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;



namespace _188217_BaiTap2.Controllers
{

    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [Route("san-pham/id-/{id?}")]
        public IActionResult Index(int id = 1)
        {

            var products = new List<ProductsModel>()
            {
                new ProductsModel { ProductId = "1", Product_Name = "Đồ chơi trạm cảnh sát tuần tra và cứu hỏa biển Lego City 60308", Product_Price = 1119200, Product_Price_Old = 13990000, Product_Price_Percent = 20, Product_Category = "Đồ chơi Lego", Product_Age = 5, Product_BoxSize = "38x26x6", Product_Detail = 297, Product_Substance = "Plastic", Product_Weight = 724, Product_Trademark = "Lego (Đan Mạch)", Product_Note = "Có các chi tiết nhỏ, không dùng cho trẻ dưới 3 tuổi, tránh nguy cơ tiềm ẩn khi trẻ sử dụng sai", Product_MadeIn = "Trung Quốc", Product_Img8 = "img/do-choi-tram-canh-sat-tuan-tra-cuu-hoa-bien-lego-city-60308-6.jpg", Product_Img2 = "img/do-choi-tram-canh-sat-tuan-tra-cuu-hoa-bien-lego-city-60308-2.jpg", Product_Img3 = "img/do-choi-tram-canh-sat-tuan-tra-cuu-hoa-bien-lego-city-60308-3.jpg", Product_Img5 = "img/do-choi-tram-canh-sat-tuan-tra-cuu-hoa-bien-lego-city-60308-5.jpg", Product_Features = "Bé có thể sáng tạo và tưởng tượng câu chuyện của mình.", Product_Features_Type = " giúp rèn luyện tính rỉ mỉ, sáng tạo của bé khi lắp ráp.", Product_Features_Category = "không có góc nhọn, thành phần độc hại nên an toàn cho bé.", Product_Manual1 = "Lắp ráp các khớp nối với nhau theo hình trên bao bì", Product_Manual2 = "Có thể sáng tạo theo trí tưởng tượng của bé.", Product_Manual_Category = "không sử dụng pin", Product_Type = "Đồ chơi bé trai", Product_Type1 = "Đồ chơi lắp ráp", Product_Promotion_Date_End = "31/05", Product_Promotion_Content = "Nhập mã AVAKID giảm 10% tối đa 100.000đ cho đơn hàng từ 300.000đ trở lên khi thanh toán qua Ví Moca trên ứng dụng Grab" },
                new ProductsModel { ProductId = "22", Product_Name = "Đồ chơi xe địa hình cứu hộ Lego City 60301", Product_Price = 1119200, Product_Price_Old = 13990000, Product_Price_Percent = 20, Product_Category = "Đồ chơi Lego", Product_Age = 5, Product_BoxSize = "38x26x6", Product_Detail = 157, Product_Substance = "Plastic", Product_Weight = 724, Product_Trademark = "Lego (Đan Mạch)", Product_Note = "Có các chi tiết nhỏ, không dùng cho trẻ dưới 3 tuổi, tránh nguy cơ tiềm ẩn khi trẻ sử dụng sai", Product_MadeIn = "Trung Quốc", Product_Img8 = "img/do-choi-xe-dia-hinh-cuu-ho-lego-city-60301-201121-124424-600x600.jpg", Product_Img3 = "img/do-choi-tram-canh-sat-tuan-tra-cuu-hoa-bien-lego-city-60308-3.jpg", Product_Img5 = "img/do-choi-tram-canh-sat-tuan-tra-cuu-hoa-bien-lego-city-60308-5.jpg", Product_Features = "Bé có thể sáng tạo và tưởng tượng câu chuyện của mình.", Product_Features_Category = "không có góc nhọn, thành phần độc hại nên an toàn cho bé.", Product_Manual1 = "Lắp ráp các khớp nối với nhau theo hình trên bao bì", Product_Manual2 = "Có thể sáng tạo theo trí tưởng tượng của bé.", Product_Manual_Category = "không sử dụng pin", Product_Type = "Đồ chơi bé trai", Product_Type1 = "Đồ chơi lắp ráp", Product_Promotion_Date_End = "31/05", Product_Promotion_Content = "Nhập mã AVAKID giảm 10% tối đa 100.000đ cho đơn hàng từ 300.000đ trở lên khi thanh toán qua Ví Moca trên ứng dụng Grab" },
                new ProductsModel { ProductId = "33", Product_Name = "Đồ chơi trạm rửa xe thông minh Hot Wheels FTB66", Product_Price = 1079200, Product_Price_Old = 1290000, Product_Price_Percent = 20, Product_Category = "Đồ chơi Lego", Product_Age = 5, Product_BoxSize = "38x26x6", Product_Detail = 297, Product_Substance = "Plastic", Product_Weight = 724, Product_Trademark = "Lego (Đan Mạch)", Product_Note = "Có các chi tiết nhỏ, không dùng cho trẻ dưới 3 tuổi, tránh nguy cơ tiềm ẩn khi trẻ sử dụng sai", Product_MadeIn = "Trung Quốc", Product_Img8 = "img/do-choi-mo-hinh-tram-rua-xe-thong-minh-tuyet-dinh-hot-wheels-ftb66-181121-105405-600x600.jpg",  Product_Img3 = "img/do-choi-tram-canh-sat-tuan-tra-cuu-hoa-bien-lego-city-60308-3.jpg", Product_Img5 = "img/do-choi-tram-canh-sat-tuan-tra-cuu-hoa-bien-lego-city-60308-5.jpg",Product_Features = "Bé có thể sáng tạo và tưởng tượng câu chuyện của mình.", Product_Features_Category = "không có góc nhọn, thành phần độc hại nên an toàn cho bé.", Product_Manual1 = "Lắp ráp các khớp nối với nhau theo hình trên bao bì", Product_Manual2 = "Có thể sáng tạo theo trí tưởng tượng của bé.", Product_Manual_Category = "không sử dụng pin", Product_Type = "Đồ chơi bé trai", Product_Type1 = "Đồ chơi lắp ráp", Product_Promotion_Date_End = "31/05", Product_Promotion_Content = "Nhập mã AVAKID giảm 10% tối đa 100.000đ cho đơn hàng từ 300.000đ trở lên khi thanh toán qua Ví Moca trên ứng dụng Grab" },
                new ProductsModel { ProductId = "41", Product_Name = "Đồ chơi thùng gạch sáng tạo Lego Duplo 10913", Product_Price = 1119200, Product_Price_Old = 13990000, Product_Price_Percent = 20, Product_Category = "Đồ chơi Lego", Product_Age = 5, Product_BoxSize = "38x26x6", Product_Detail = 65, Product_Substance = "Plastic", Product_Weight = 724, Product_Trademark = "Lego (Đan Mạch)", Product_Note = "Có các chi tiết nhỏ, không dùng cho trẻ dưới 3 tuổi, tránh nguy cơ tiềm ẩn khi trẻ sử dụng sai", Product_MadeIn = "Trung Quốc", Product_Img8 = "img/do-choi-thung-gach-duplo-sang-tao-lego-duplo-10913-070322-100629-600x600.jpg",  Product_Img3 = "img/do-choi-tram-canh-sat-tuan-tra-cuu-hoa-bien-lego-city-60308-3.jpg", Product_Img5 = "img/do-choi-tram-canh-sat-tuan-tra-cuu-hoa-bien-lego-city-60308-5.jpg", Product_Features = "Bé có thể sáng tạo và tưởng tượng câu chuyện của mình.", Product_Features_Category = "không có góc nhọn, thành phần độc hại nên an toàn cho bé.", Product_Manual1 = "Lắp ráp các khớp nối với nhau theo hình trên bao bì", Product_Manual2 = "Có thể sáng tạo theo trí tưởng tượng của bé.", Product_Manual_Category = "không sử dụng pin", Product_Type = "Đồ chơi bé trai", Product_Type1 = "Đồ chơi lắp ráp", Product_Promotion_Date_End = "31/05", Product_Promotion_Content = "Nhập mã AVAKID giảm 10% tối đa 100.000đ cho đơn hàng từ 300.000đ trở lên khi thanh toán qua Ví Moca trên ứng dụng Grab" },
                new ProductsModel { ProductId = "53", Product_Name = "Đồ chơi phi cơ chiến đấu của Cole Lego Ninjago 71736", Product_Price = 1119200, Product_Price_Old = 13990000, Product_Price_Percent = 20, Product_Category = "Đồ chơi Lego", Product_Age = 5, Product_BoxSize = "38x26x6", Product_Detail = 449, Product_Substance = "Plastic", Product_Weight = 724, Product_Trademark = "Lego (Đan Mạch)", Product_Note = "Có các chi tiết nhỏ, không dùng cho trẻ dưới 3 tuổi, tránh nguy cơ tiềm ẩn khi trẻ sử dụng sai", Product_MadeIn = "Trung Quốc", Product_Img8 = "img/do-choi-phi-co-chien-dau-cua-cole-lego-ninjago-71736-070322-111209-600x600.jpg",  Product_Img3 = "img/do-choi-tram-canh-sat-tuan-tra-cuu-hoa-bien-lego-city-60308-3.jpg", Product_Img5 = "img/do-choi-tram-canh-sat-tuan-tra-cuu-hoa-bien-lego-city-60308-5.jpg", Product_Features = "Bé có thể sáng tạo và tưởng tượng câu chuyện của mình.", Product_Features_Category = "không có góc nhọn, thành phần độc hại nên an toàn cho bé.", Product_Manual1 = "Lắp ráp các khớp nối với nhau theo hình trên bao bì", Product_Manual2 = "Có thể sáng tạo theo trí tưởng tượng của bé.", Product_Manual_Category = "không sử dụng pin", Product_Type = "Đồ chơi bé trai", Product_Type1 = "Đồ chơi lắp ráp", Product_Promotion_Date_End = "31/05", Product_Promotion_Content = "Nhập mã AVAKID giảm 10% tối đa 100.000đ cho đơn hàng từ 300.000đ trở lên khi thanh toán qua Ví Moca trên ứng dụng Grab" },
                new ProductsModel { ProductId = "63", Product_Name = "Đồ chơi tàu chiến hạm bay Bounty Lego Ninjago 71749", Product_Price = 1119200, Product_Price_Old = 13990000, Product_Price_Percent = 20, Product_Category = "Đồ chơi Lego", Product_Age = 5, Product_BoxSize = "38x26x6", Product_Detail = 149, Product_Substance = "Plastic", Product_Weight = 724, Product_Trademark = "Lego (Đan Mạch)", Product_Note = "Có các chi tiết nhỏ, không dùng cho trẻ dưới 3 tuổi, tránh nguy cơ tiềm ẩn khi trẻ sử dụng sai", Product_MadeIn = "Trung Quốc", Product_Img8 = "img/do-choi-tau-chien-ham-bay-bounty-lego-ninjago-71749-070322-110850-600x600.jpg",  Product_Img3 = "img/do-choi-tram-canh-sat-tuan-tra-cuu-hoa-bien-lego-city-60308-3.jpg", Product_Img5 = "img/do-choi-tram-canh-sat-tuan-tra-cuu-hoa-bien-lego-city-60308-5.jpg", Product_Features = "Bé có thể sáng tạo và tưởng tượng câu chuyện của mình.", Product_Features_Category = "không có góc nhọn, thành phần độc hại nên an toàn cho bé.", Product_Manual1 = "Lắp ráp các khớp nối với nhau theo hình trên bao bì", Product_Manual2 = "Có thể sáng tạo theo trí tưởng tượng của bé.", Product_Manual_Category = "không sử dụng pin", Product_Type = "Đồ chơi bé trai", Product_Type1 = "Đồ chơi lắp ráp", Product_Promotion_Date_End = "31/05", Product_Promotion_Content = "Nhập mã AVAKID giảm 10% tối đa 100.000đ cho đơn hàng từ 300.000đ trở lên khi thanh toán qua Ví Moca trên ứng dụng Grab" },
                new ProductsModel { ProductId = "47", Product_Name = "Đồ chơi cắm trại ngoài trời Lego Friends 41392LG", Product_Price = 1119200, Product_Price_Old = 13990000, Product_Price_Percent = 20, Product_Category = "Đồ chơi Lego", Product_Age = 5, Product_BoxSize = "38x26x6", Product_Detail = 241, Product_Substance = "Plastic", Product_Weight = 724, Product_Trademark = "Lego (Đan Mạch)", Product_Note = "Có các chi tiết nhỏ, không dùng cho trẻ dưới 3 tuổi, tránh nguy cơ tiềm ẩn khi trẻ sử dụng sai", Product_MadeIn = "Trung Quốc", Product_Img8 = "img/do-choi-cam-trai-ngoai-troi-lego-friends-41392lg-130322-112928-600x600.jpg",  Product_Img3 = "img/do-choi-tram-canh-sat-tuan-tra-cuu-hoa-bien-lego-city-60308-3.jpg", Product_Img5 = "img/do-choi-tram-canh-sat-tuan-tra-cuu-hoa-bien-lego-city-60308-5.jpg", Product_Features = "Bé có thể sáng tạo và tưởng tượng câu chuyện của mình.", Product_Features_Category = "không có góc nhọn, thành phần độc hại nên an toàn cho bé.", Product_Manual1 = "Lắp ráp các khớp nối với nhau theo hình trên bao bì", Product_Manual2 = "Có thể sáng tạo theo trí tưởng tượng của bé.", Product_Manual_Category = "không sử dụng pin", Product_Type = "Đồ chơi bé trai", Product_Type1 = "Đồ chơi lắp ráp", Product_Promotion_Date_End = "31/05", Product_Promotion_Content = "Nhập mã AVAKID giảm 10% tối đa 100.000đ cho đơn hàng từ 300.000đ trở lên khi thanh toán qua Ví Moca trên ứng dụng Grab" },


            };
            var result = products.Where(p => p.ProductId == id.ToString()).ToList();

            return View(result[0]);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }




      
    }


   
   

}



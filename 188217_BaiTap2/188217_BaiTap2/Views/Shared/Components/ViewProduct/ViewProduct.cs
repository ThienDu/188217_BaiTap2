using _188217_BaiTap2.Models;
using Microsoft.AspNetCore.Mvc;

namespace _188217_BaiTap2.Views.Shared.Components.ViewProducts
{
    public class ViewProduct : ViewComponent
    {
        public IViewComponentResult Invoke(ProductsModel product  )
        {
            var productDetail = product;    

            return View<ProductsModel>(productDetail);

        }
    }


}
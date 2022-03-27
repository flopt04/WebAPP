using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPP.Models;

namespace WebAPP.Controllers
{
    public class ShopsCartsController : Controller
    {
        public IActionResult Index()
        {
            List<ShopCart> list = new List<ShopCart>();
            list.Add(new ShopCart { carrinho_ID = 1 });

            return View();
        }
    }
}

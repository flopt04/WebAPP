using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPP.Models;


namespace WebAPP.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            List<Products> list = new List<Products>();
            list.Add(new Products
            {
                cod_Produto = 1,
                nomeProduto = "MS ZIPER COAT // GREEN",
                preco = 75,
                quantidade = 250,
                sexo = "Unisexo",
                tamanho = "M",
                taxaIVA = 23,
                tipo = "JACKETS"
            });
            list.Add(new Products
            {
                cod_Produto = 2,
                nomeProduto = "MS VINTAGE BASKET PRINT HOODIE // ECRU",
                preco = 55,
                quantidade = 100,
                sexo = "Unisexo",
                tamanho = "M",
                taxaIVA = 23,
                tipo = "HOODIES"
            });

            return View(list);
        }
    }
}

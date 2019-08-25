using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Serwis.Models;
using System.Linq;
using System.Threading.Tasks;

namespace Serwis.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            //List<string> results = new List<string>();
            //
            //foreach (Product p in Product.GetProducts())
            //{
            //    string name = p?.Name;
            //    decimal? price = p?.Price;
            //    string relatedName = p?.Related?.Name ?? "brak";
            //    results.Add(string.Format($"Produkt: {name}, cena: {price}, powi¹zany: {relatedName}"));
            //}

            Product myProduct = new Product("Kajak", "Jednoosobowa ³ódka", 275M, "Sporty wodne");
            Product myProduct2 = new Product("Jacht", "Du¿a ³ódka", 2750M, "Rekreacja");
            ViewBag.StockLevel = 2;

            return View(new Product[] { myProduct, myProduct2 });
        }
    }
}
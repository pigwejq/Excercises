using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Serwis.Models;

namespace Serwis.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            List<string> results = new List<string>();

            foreach (Product p in Product.GetProducts())
            {
                string name = p?.Name;
                decimal? price = p?.Price;
                string relatedName = p?.Related?.Name ?? "brak";
                results.Add(string.Format($"Produkt: {name}, cena: {price}, powi¹zany: {relatedName}"));
            }
            return View(results);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParfumShopApp.Models;
using System.Collections.Generic;

namespace ParfumShopApp.Services
{
    public class ProductService
    {
        static ProductService _instance;

        public static ProductService Instance
        {
            get { return _instance ?? (_instance = new ProductService()); }
        }

        public List<Product> GetProducts()
        {
            return new List<Product> {
              new Product {
                  Name = "Emporio Armani - Because It's You For Her",
                  Image = "armani_beauty.jpg",
                  Description = "Parfum",
                  Price = 80,
              },
              new Product {
                  Name = "Carolina Herrera - Good Girl",
                  Image = "carolina_herrera.jpg",
                  Description = "Parfum",
                  Price = 82,
              },
              new Product {
                  Name = "Lancome - La Vie est Belle",
                  Image = "lancome.jpg",
                  Description = "Parfum",
                  Price = 137,
              },
              new Product {
                  Name = "Mugler - Alien",
                  Image = "mugler.jpg",
                  Description = "Parfum",
                  Price = 101,
              },
              new Product {
                  Name = "Tom Ford - Tobacco Vanille",
                  Image = "tom_ford.jpg",
                  Description = "Parfum",
                  Price = 219,
              },
              new Product {
                  Name = "Yves Saint Laurent - Black Opium",
                  Image = "ysl.jpg",
                  Description = "Parfum",
                  Price = 98,
              },
           };
        }
    }
}

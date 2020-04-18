using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiProject.Controllers
{
    [ApiController]
    [Route("products")]
    public class ProductController: ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Product>> GetAll()
        {
            return Products;
        }

        private static List<Product> Products = new List<Product>
        {
            new Product
            {
                Id= 1,
                Name= "Guitarra Electrica",
                Price= 400,
                Description= "Ideal Para aprender a tocar"
            },
            new Product
            {
                Id= 2,
                Name = "Amplificador Guitarra",
                Price= 1200,
                Description = "Ideal para comenzar"
            },
        };
    }
}
